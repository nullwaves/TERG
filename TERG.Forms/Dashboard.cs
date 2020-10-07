using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TERG.Core;
using TERG.Core.Interfaces;
using TERG.Core.Models;
using TERG.Core.Models.References;

namespace TERG.Forms
{
    public partial class Dashboard : Form
    {
        private Engine engine;

        private IEnumerable<Pattern> Patterns => engine.GetPatterns();
        private IEnumerable<Pool> Pools => engine.GetPools();

        // Variables for Pool Editor
        private int IndexInPoolEditor = -1;

        private bool FlagPoolChanged = false;

        //Variables for Pattern Editor
        private int IndexInPatternEditor = -1;

        private bool FlagPatternChanged = false;

        private readonly string DBFileLocation = (string)Properties.Settings.Default["DatabaseFileLocation"];

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (File.Exists(DBFileLocation))
            {
                PushDatabaseStatus("Database exists; Attempting to parse");

                try
                {
                    engine = Engine.Load(DBFileLocation);
                    PushDatabaseStatus($"Database loaded from [{Path.GetFullPath(DBFileLocation)}]. Pools: {Pools.Count()} Patterns: {Patterns.Count()}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    Close();
                }
            }
            else
            {
                engine = new Engine();
                SaveDatabase();
            }

            listPatterns.DisplayMember = "Name";
            comboExportPattern.DisplayMember = "Name";
            listPools.DisplayMember = "Name";
            comboPoolParent.DisplayMember = "Name";
            comboAddReferenceType.Items.AddRange(ReferenceFactory.typeMap.Keys.ToArray<string>());

            /* Load Lists */
            LoadPoolLists();
            LoadPatternLists();
        }

        private void LoadPatternLists()
        {
            // Clear old lists
            listPatterns.Items.Clear();
            listPatterns.ClearSelected();
            comboExportPattern.Items.Clear();

            // Add updated list of items
            listPatterns.Items.AddRange(Patterns.ToArray());
            comboExportPattern.Items.Add(Patterns.ToArray());

            // Reload any current pattern/clear fields
            LoadPattern();
        }

        private void LoadPattern()
        {
            btnOpenTemplateEditor.Enabled = false;                          // Disable Template editor while we're loading
            btnAddReference.Enabled = false;                                // And any other buttons that modify the pattern
            btnDeletePattern.Enabled = false;
            listPatternReferences.Enabled = false;
            textPatternName.Enabled = false;
            btnMoveRefDown.Enabled = false;
            btnMoveRefUp.Enabled = false;
            btnDeleteReference.Enabled = false;
            textPatternName.Clear();                                        // Clear Name field
            listPatternReferences.Items.Clear();                            // Clear Reference list

            if (listPatterns.SelectedItem.GetType() == typeof(Pattern))
            {
                Pattern p = (Pattern)listPatterns.SelectedItem;
                textPatternName.Text = p.Name;
                foreach (IReference r in p.References)
                {
                    _ = listPatternReferences.Items.Add(r.ToString(engine));
                }

                btnDeletePattern.Enabled = true;
                btnOpenTemplateEditor.Enabled = true;                       // Enable access to the Template Editor
                btnAddReference.Enabled = true;
                listPatternReferences.Enabled = true;
                textPatternName.Enabled = true;
                btnMoveRefDown.Enabled = true;
                btnMoveRefUp.Enabled = true;
                btnDeleteReference.Enabled = true;

                FlagPatternChanged = false;
            }
        }

        private void LoadPoolLists()
        {
            // Clear Old Lists
            listPools.Items.Clear();
            listPools.ClearSelected();
            comboPoolParent.Items.Clear();

            // Add updated list of items
            comboPoolParent.Items.Add("None");
            listPools.Items.AddRange(Pools.ToArray());
            comboPoolParent.Items.Add(Pools.ToArray());

            // Reload any current pool/clear fields
            LoadPool();
        }

        private void LoadPool()
        {
            // Disable everything
            btnDeletePool.Enabled = false;
            textPoolName.Enabled = false;
            textBoxPoolEditor.Enabled = false;
            comboPoolParent.Enabled = false;

            if (listPools.SelectedItem.GetType() == typeof(Pool))
            {
                Pool p = (Pool)listPools.SelectedItem;

                textBoxPoolEditor.Clear();
                textBoxPoolEditor.Lines = p.List;

                textPoolName.Clear();
                textPoolName.Text = p.Name;

                if (p.ParentID == -1)
                {
                    comboPoolParent.SelectedIndex = 0;
                }
                else
                {
                    int indexOfParent = comboPoolParent.Items.IndexOf(Pools.Where(x => x.ID == p.ParentID).First());
                    comboPoolParent.SelectedIndex = indexOfParent;
                }

                // Enable everything
                btnDeletePool.Enabled = true;
                textPoolName.Enabled = true;
                textBoxPoolEditor.Enabled = true;
                comboPoolParent.Enabled = true;
                FlagPoolChanged = false;
            }
            else
            {
                textBoxPoolEditor.Clear();
                textPoolName.Clear();
                comboPoolParent.SelectedIndex = 0;
            }
        }

        private void SavePattern()
        {
            // Save Pattern Name
            string name = textPatternName.Text.Trim();
            Pattern selectedItem = (Pattern)listPatterns.SelectedItem;
            if (!selectedItem.Name.Equals(name))
            {
                string oldName = selectedItem.Name;
                Patterns.ToArray()[IndexInPatternEditor].Name = name;
                PushDatabaseStatus("Updated pattern name from [" + oldName + "] to [" + name + "]");
            }

            SaveDatabase();
            LoadPatternLists();
            listPatterns.SelectedIndex = IndexInPatternEditor;
            FlagPatternChanged = false;
        }

        private void SavePool()
        {
            var updatedPool = new Pool();
            // Save Pool Items
            string[] update = textBoxPoolEditor.Lines;
            for (int i = 0; i < update.Length; i++)
            {
                update[i] = update[i].Trim();
            }
            engine.Pools[IndexInPoolEditor].List = update;
            PushDatabaseStatus("Pool [" + engine.Pools[IndexInPoolEditor].Name + "] has been updated");

            // Save Pool Name
            string name = textPoolName.Text.Trim();
            if (!engine.Pools[IndexInPoolEditor].Name.Equals(name))
            {
                string oldName = engine.Pools[IndexInPoolEditor].Name;
                engine.Pools[IndexInPoolEditor].Name = name;
                PushDatabaseStatus("Updated pool name from [" + oldName + "] to [" + name + "]");
            }

            // Save Parent Pool

            int newParentID;
            if (comboPoolParent.SelectedIndex == -1 || comboPoolParent.SelectedIndex == 0)
            {
                newParentID = -1;
            }
            else
            {
                newParentID = engine.Pools[comboPoolParent.SelectedIndex - 1].ID;
            }
            if (engine.Pools[IndexInPoolEditor].ParentID != newParentID)
            {
                string oldParent;
                if (engine.Pools[IndexInPoolEditor].ParentID != -1)
                {
                    oldParent = engine.FindPoolById(engine.Pools[IndexInPoolEditor].ParentID).Name;
                }
                else
                {
                    oldParent = "None";
                }
                string newParent;
                if (newParentID == -1)
                {
                    newParent = "None";
                }
                else
                {
                    newParent = engine.FindPoolById(newParentID).Name;
                }
                engine.Pools[IndexInPoolEditor].ParentID = newParentID;
                PushDatabaseStatus("Updated [" + engine.Pools[IndexInPoolEditor].Name + "] Parent from [" + oldParent + "] to [" + newParent + "]");
            }

            SaveDatabase();
            LoadPoolLists();
            listPools.SelectedIndex = IndexInPoolEditor;
            FlagPoolChanged = false;
        }

        private void SaveDatabase()
        {
            SaveDatabase(DBFileLocation);
        }

        private bool SaveDatabase(string file)
        {
            PushDatabaseStatus("Preparing to save database");

            //Check to see if database exists
            if (!File.Exists(file))
            {
                //It doesn't exist, so we make one
                PushDatabaseStatus("Database does not exist; Attempting to create");
                try
                {
                    File.Create(file).Close();
                    PushDatabaseStatus("Database created");
                }
                catch (Exception e)
                {
                    //Unless we don't.
                    PushDatabaseStatus("Error Creating Database: " + e.Message);
                    MessageBox.Show(e.Message);
                    return false;
                }
            }

            //Save the data to the file.
            engine.Save(file);
            PushDatabaseStatus("Database saved");
            return true;
        }

        private void PushDatabaseStatus(string Status)
        {
            statusDatabase.Text = DateTime.Now + " " + Status;
            Console.WriteLine(statusDatabase.Text);
            txtEventLog.Text += statusDatabase.Text + "\r\n";
            txtEventLog.ScrollToCaret();
        }

        private void ListPools_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IndexInPoolEditor == listPools.SelectedIndex) return;

            int newIndex = listPools.SelectedIndex;

            if (IndexInPoolEditor != -1)
            {
                //If the pool has been modified we want to check to see if changes should be saved
                if (FlagPoolChanged)
                {
                    DialogResult result = MessageBox.Show(
                        "You have unsaved changes to a pool. Would you like to save these before continuing?",
                        Text,
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:                              // Save changes and proceed
                            SavePool();
                            break;

                        case DialogResult.No:                               //Don't Save Changes, just skip to loading the next pool
                            break;

                        default:                                            //Neither, reset the index back to the previous and abort mission
                            listPools.SelectedIndex = IndexInPoolEditor;
                            return;
                    }
                }
            }

            listPools.SelectedIndex = newIndex;
            IndexInPoolEditor = listPools.SelectedIndex;
            LoadPool();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ab = new TERGAboutBox())
            {
                ab.ShowDialog();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDatabase();
        }

        private void AddNewPoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputBoxResult result = InputBox.Show("New Pool name:", Text);
            if (result.OK)
            {
                string name = result.Text.Trim();
                if (name.Length > 0)
                {
                    engine.Pools.Add(new Pool(engine.GetNextPoolID(), name));
                    PushDatabaseStatus("Added pool \"" + result.Text + "\"");
                    SaveDatabase();
                    LoadPoolLists();
                }
            }
        }

        private void TextBoxPoolEditor_TextChanged(object sender, EventArgs e)
        {
            if (IndexInPoolEditor != -1)
            {
                FlagPoolChanged = true;
            }
        }

        private void TextPoolName_TextChanged(object sender, EventArgs e)
        {
            if (IndexInPoolEditor != -1)
            {
                FlagPoolChanged = true;
            }
        }

        private void ComboPoolParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IndexInPoolEditor != -1)
            {
                FlagPoolChanged = true;
                if (comboPoolParent.SelectedIndex == 0)
                {
                    comboPoolParent.SelectedIndex = -1;
                }
            }
        }

        private void BtnSavePool_Click(object sender, EventArgs e)
        {
            SavePool();
        }

        private void BtnRefreshPool_Click(object sender, EventArgs e)
        {
            LoadPool();
        }

        private void ListPatterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IndexInPatternEditor == listPatterns.SelectedIndex) return;

            int newIndex = listPatterns.SelectedIndex;

            if (IndexInPatternEditor != -1)
            {
                //If the pool has been modified we want to check to see if changes should be saved
                if (FlagPatternChanged)
                {
                    DialogResult result = MessageBox.Show(
                        "You have unsaved changes to a pattern. Would you like to save these before continuing?",
                        Text,
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:                              // Save changes and proceed
                            SavePattern();
                            break;

                        case DialogResult.No:                               //Don't Save Changes, just skip to loading the next pool
                            break;

                        default:                                            //Neither, reset the index back to the previous and abort mission
                            listPatterns.SelectedIndex = IndexInPatternEditor;
                            return;
                    }
                }
            }

            listPatterns.SelectedIndex = newIndex;
            IndexInPatternEditor = listPatterns.SelectedIndex;
            LoadPattern();
        }

        private void ListPatternReferences_DoubleClick(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1 && listPatternReferences.SelectedIndex != -1)
            {
                int index = listPatternReferences.SelectedIndex;

                IReference r = ReferenceEditor.Show(false, engine, Patterns.ToArray()[IndexInPatternEditor].References[index]);
                Patterns.ToArray()[IndexInPatternEditor].References[index] = r;
                PushDatabaseStatus("Updated Reference in Pattern [" + Patterns.ToArray()[IndexInPatternEditor].Name + "]");
                SaveDatabase();
                LoadPattern();
            }
        }

        private void AddNewPatternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputBoxResult result = InputBox.Show("New Pattern Name:", Text);
            if (result.OK)
            {
                string name = result.Text.Trim();
                var ret = engine.AddPattern(new Pattern() { Name = name });
                if (ret.ID > 0)
                {
                    PushDatabaseStatus($"Added pattern [{ret.ID}] {ret.Name}");
                    SaveDatabase();
                    LoadPatternLists();
                }
                else
                {
                    PushDatabaseStatus("Failed to add Pattern");
                }
            }
        }

        private void BtnOpenTemplateEditor_Click(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1)
            {
                Pattern patt = Patterns.ToArray()[IndexInPatternEditor];
                BaseEditorResult result = BaseEditor.Show(patt.Name, patt.Body);

                if (result.OK)
                {
                    Patterns.ToArray()[IndexInPatternEditor].Body = result.Text;
                    PushDatabaseStatus("Updated template for [" + patt.Name + "]");
                    SaveDatabase();
                }
            }
        }

        private void BtnAddReference_Click(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1 && comboAddReferenceType.Text.Length == 4)
            {
                string s = comboAddReferenceType.Text.Trim();
                IReference nref = ReferenceFactory.Create(s);
                nref = ReferenceEditor.Show(true, engine, nref);
                Patterns.ToArray()[IndexInPatternEditor].References.Add(nref);
                PushDatabaseStatus("Added Reference of type [" + s + "] to pattern [" + Patterns.ToArray()[IndexInPatternEditor].Name + "]");
                SaveDatabase();
                LoadPattern();
            }
        }

        private void PatternRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1)
            {
                MessageBox.Show(Patterns.ToArray()[IndexInPatternEditor].Fill(engine));
            }
        }

        private void BtnDeletePool_Click(object sender, EventArgs e)
        {
            if (IndexInPoolEditor != -1)
            {
                int PoolID = engine.Pools[IndexInPoolEditor].ID;

                int pattConflicts = 0;
                int poolConflicts = 0;

                // Check how many patterns reference this pool
                foreach (Pattern p in Patterns)
                {
                    foreach (IReference r in p.References)
                    {
                        if (r.Type == "POOL")
                        {
                            if (((PoolReference)r).PoolID == PoolID)
                            {
                                pattConflicts++;
                            }
                        }
                    }
                }

                // Check how many children this pool has
                foreach (Pool p in engine.Pools)
                {
                    if (p.ParentID == PoolID)
                    {
                        poolConflicts++;
                    }
                }

                MessageBox.Show("Deleting this pool will affect and possibly break " + pattConflicts + " Patterns and will clear the parent property of " + poolConflicts + " Pools.");
                InputBoxResult result = InputBox.Show("Type the pool name to confirm deletion.", Text);
                if (result.OK && result.Text == engine.Pools[IndexInPoolEditor].Name)
                {
                    // Delete any patterns references to this pool
                    foreach (Pattern p in Patterns)
                    {
                        List<IReference> removal = new List<IReference>();
                        foreach (IReference r in p.References)
                        {
                            if (r.Type == "POOL")
                            {
                                if (((PoolReference)r).PoolID == PoolID)
                                {
                                    removal.Add(r);
                                }
                            }
                        }
                        foreach (IReference r in removal)
                        {
                            p.References.Remove(r);
                        }
                    }

                    // Clear parentids for any former children
                    foreach (Pool p in engine.Pools)
                    {
                        if (p.ParentID == PoolID)
                        {
                            p.ParentID = -1;
                        }
                    }

                    string oldName = engine.Pools[IndexInPoolEditor].Name;

                    engine.Pools.RemoveAt(IndexInPoolEditor);
                    IndexInPoolEditor = -1;
                    PushDatabaseStatus("Deleted Pool [" + oldName + "]");
                    SaveDatabase();
                    LoadPoolLists();
                }
            }
        }

        private void BtnDeletePattern_Click(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1)
            {
                int PatternID = Patterns.ToArray()[IndexInPatternEditor].ID;

                int pattConflicts = 0;

                // Check for any patterns that reference this pattern
                foreach (Pattern p in Patterns)
                {
                    for (int i = 0; i < p.References.Count; i++)
                    {
                        if (p.References[i].Type == "PATT")
                        {
                            PatternReference r = (PatternReference)p.References[i];
                            if (r.PatternID == PatternID)
                            {
                                pattConflicts++;
                            }
                        }
                    }
                }

                MessageBox.Show("Deleting this pattern will affect " + pattConflicts + " Patterns.");
                InputBoxResult result = InputBox.Show("Type the pattern name to continue with deletion.", Text);
                if (result.OK && result.Text == Patterns.ToArray()[IndexInPatternEditor].Name)
                {
                    foreach (Pattern p in Patterns)
                    {
                        for (int i = 0; i < p.References.Count; i++)
                        {
                            if (p.References[i].Type == "PATT")
                            {
                                PatternReference r = (PatternReference)p.References[i];
                                if (r.PatternID == PatternID)
                                {
                                    p.References.RemoveAt(i);
                                    i--;
                                }
                            }
                        }
                    }

                    Pattern oldpatt = Patterns.ToArray()[IndexInPatternEditor];

                    engine.RemovePattern(PatternID);
                    IndexInPatternEditor = -1;
                    PushDatabaseStatus($"Deleted Pattern [{oldpatt.Name}]");
                    SaveDatabase();
                    LoadPatternLists();
                }
            }
        }

        private void ChangeDatabaseLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog { AddExtension = true, DefaultExt = ".db", FileName = DBFileLocation })
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Implement
                    Properties.Settings.Default["DatabaseFileLocation"] = Path.GetFullPath(dialog.FileName);
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Restarting...");
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
        }

        private void BtnMoveRefUp_Click(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1 && listPatternReferences.SelectedIndex > 0)
            {
                int index = listPatternReferences.SelectedIndex;
                IReference temp = Patterns.ToArray()[IndexInPatternEditor].References[index];
                Patterns.ToArray()[IndexInPatternEditor].References[index] = Patterns.ToArray()[IndexInPatternEditor].References[index - 1];
                Patterns.ToArray()[IndexInPatternEditor].References[index - 1] = temp;
                SaveDatabase();
                LoadPattern();
                listPatternReferences.SelectedIndex = index - 1;
            }
        }

        private void BtnMoveRefDown_Click(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1 &&
                listPatternReferences.Items.Count > 1 &&
                listPatternReferences.SelectedIndex < listPatternReferences.Items.Count - 1)
            {
                int index = listPatternReferences.SelectedIndex;
                IReference temp = Patterns.ToArray()[IndexInPatternEditor].References[index];
                Patterns.ToArray()[IndexInPatternEditor].References[index] = Patterns.ToArray()[IndexInPatternEditor].References[index + 1];
                Patterns.ToArray()[IndexInPatternEditor].References[index + 1] = temp;
                SaveDatabase();
                LoadPattern();
                listPatternReferences.SelectedIndex = index + 1;
            }
        }

        private void BtnDeleteReference_Click(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1 &&
                listPatternReferences.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you'd like to delete this reference?", Text, MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    Patterns.ToArray()[IndexInPatternEditor].References.RemoveAt(listPatternReferences.SelectedIndex);
                    PushDatabaseStatus("Deleted reference in pattern [" + Patterns.ToArray()[IndexInPatternEditor].Name + "]");
                    SaveDatabase();
                    LoadPattern();
                }
            }
        }

        private void BtnRunExport_Click(object sender, EventArgs e)
        {
            if (comboExportPattern.SelectedIndex != -1)
            {
                if (!(int.TryParse(textExportIterations.Text, out int it)))
                {
                    it = 1;
                }
                Pattern p = Patterns.ToArray()[comboExportPattern.SelectedIndex];

                textExport.Clear();

                List<string> results = engine.Composer.Compose(p, it, Composer.HeaderAndFooterSetting.NONE);

                foreach (string result in results)
                {
                    textExport.Text += result + Environment.NewLine + ((checkExportSeperators.Checked) ? "----END OF RESULT----" + Environment.NewLine : string.Empty);
                }
                PushDatabaseStatus("Generated " + results.Count + " iterations of " + p.Name);
            }
        }

        private void TextPatternName_TextChanged(object sender, EventArgs e)
        {
            FlagPatternChanged = true;
        }

        private void BtnExportOut_Click(object sender, EventArgs e)
        {
            if (comboExportPattern.SelectedIndex != -1)
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "Text File|*.txt",
                    AddExtension = true
                };

                DialogResult res = save.ShowDialog();

                if (res == DialogResult.OK)
                {
                    // Open file for writing
                    if (!File.Exists(save.FileName))
                    {
                        File.Create(save.FileName).Close();
                    }
                    StreamWriter o = new StreamWriter(save.FileName);

                    // Running
                    if (!(int.TryParse(textExportIterations.Text, out int it)))
                    {
                        MessageBox.Show("Invalid number of iterations. Defaulting to 1.");
                    }
                    Pattern p = Patterns.ToArray()[comboExportPattern.SelectedIndex];

                    List<string> results = engine.Composer.Compose(p, it, Composer.HeaderAndFooterSetting.NONE);

                    foreach (string result in results)
                    {
                        string value = result + Environment.NewLine + (checkExportSeperators.Checked ? "----END OF RESULT----" + Environment.NewLine : string.Empty);
                        o.WriteLine(value);
                        o.Flush();
                    }
                    o.Close();
                    PushDatabaseStatus("Wrote " + it + " iterations of " + p.Name + " to " + save.FileName);
                }
                save.Dispose();
            }
        }

        private void BtnCopyPattern_Click(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1)
            {
                Pattern patt = Patterns.ToArray()[IndexInPatternEditor];
                Pattern npat = new Pattern()
                {
                    ID = -1,
                    Name = $"Copy of {patt.Name}",
                    Desc = patt.Desc,
                    Header = patt.Header,
                    Body = patt.Body,
                    Footer = patt.Footer,
                    References = patt.References
                };
                var ret = engine.AddPattern(npat);
                if (ret.ID > 0)
                {
                    PushDatabaseStatus("Copied pattern \"" + patt.Name + "\"");
                    SaveDatabase();
                    LoadPatternLists();
                }
            }
            else
            {
                _ = MessageBox.Show("No pattern selected", "TERG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}