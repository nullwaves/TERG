using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using TERGEngine;
using TERGEngine.Reference;

namespace TERG
{
    public partial class frmMain : Form
    {
        private Engine engine;

        // Variables for Pool Editor
        private int IndexInPoolEditor = -1;
        private bool FlagPoolChanged = false;

        //Variables for Pattern Editor
        private int IndexInPatternEditor = -1;
        private bool FlagPatternChanged = false;

        private string DBFileLocation = (string)Properties.Settings.Default["DatabaseFileLocation"];

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(DBFileLocation))
            {
                PushDatabaseStatus("Database exists; Attempting to parse");

                try
                {
                    engine = Engine.Load(DBFileLocation);
                    PushDatabaseStatus("Database loaded from [" + Path.GetFullPath(DBFileLocation) + "]. Pools: " + engine.Pools.Count + " Patterns: " + engine.Patterns.Count);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    this.Close();
                }
            }
            else
            {
                engine = new Engine();
                SaveDatabase();
            }

            comboAddReferenceType.Items.Add("POOL");
            comboAddReferenceType.Items.Add("PATT");
            comboAddReferenceType.Items.Add("RINT");
            comboAddReferenceType.Items.Add("RPAT");
            comboAddReferenceType.Items.Add("IPAT");

            /* Load Lists */
            LoadPoolLists();
            LoadPatternLists();
        }

        private void LoadPatternLists()
        {
            listPatterns.Items.Clear();                                    // Clear Patterns list
            comboExportPattern.Items.Clear();
            foreach (Pattern p in engine.Patterns)
            {
                listPatterns.Items.Add(p.Name);                             // Add each Pattern back to the list
                comboExportPattern.Items.Add(p.Name);
            }
            listPatterns.ClearSelected();                                   // Unload any Pattern's that could've been leftover

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

            if (IndexInPatternEditor != -1)                                 // 3, 2, 1, Let's Jam!
            {
                Pattern p = engine.Patterns[IndexInPatternEditor];          // Fetch pattern for easy reference
                textPatternName.Text = p.Name;                              // Fill TextBox textPatternName
                foreach (IReference r in p.References)
                {
                    listPatternReferences.Items.Add(r.ToString(engine));          // Add Each Reference to the ListBox for References
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
            // Load Pool Names
            listPools.Items.Clear();
            comboPoolParent.Items.Clear();
            comboPoolParent.Items.Add("None");
            foreach (Pool pool in engine.Pools)
            {
                listPools.Items.Add(pool.Name);
                comboPoolParent.Items.Add(pool.Name);
            }
            listPools.ClearSelected();

            LoadPool();
        }

        private void LoadPool()
        {
            // Disable everything
            btnDeletePool.Enabled = false;
            textPoolName.Enabled = false;
            textBoxPoolEditor.Enabled = false;
            comboPoolParent.Enabled = false;

            if (IndexInPoolEditor != -1)
            {
                Pool p = engine.Pools[IndexInPoolEditor];

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
                    comboPoolParent.SelectedIndex = comboPoolParent.Items.IndexOf(engine.FindPoolById(p.ParentID).Name);
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
            if (!engine.Patterns[IndexInPatternEditor].Name.Equals(name))
            {
                string oldName = engine.Patterns[IndexInPatternEditor].Name;
                engine.Patterns[IndexInPatternEditor].Name = name;
                PushDatabaseStatus("Updated pattern name from [" + oldName + "] to [" + name + "]");
            }

            SaveDatabase();
            LoadPatternLists();
            listPatterns.SelectedIndex = IndexInPatternEditor;
            FlagPatternChanged = false;
        }

        private void SavePool()
        {
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

        private void listPools_SelectedIndexChanged(object sender, EventArgs e)
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TERGAboutBox().ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDatabase();
        }

        private void addNewPoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputBoxResult result = InputBox.Show("New Pool name:", this.Text);
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

        private void textBoxPoolEditor_TextChanged(object sender, EventArgs e)
        {
            if (IndexInPoolEditor != -1)
            {
                FlagPoolChanged = true;
            }
        }

        private void textPoolName_TextChanged(object sender, EventArgs e)
        {
            if (IndexInPoolEditor != -1)
            {
                FlagPoolChanged = true;
            }
        }

        private void comboPoolParent_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnSavePool_Click(object sender, EventArgs e)
        {
            SavePool();
        }

        private void btnRefreshPool_Click(object sender, EventArgs e)
        {
            LoadPool();
        }

        private void listPatterns_SelectedIndexChanged(object sender, EventArgs e)
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

        private void listPatternReferences_DoubleClick(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1 && listPatternReferences.SelectedIndex != -1)
            {
                int index = listPatternReferences.SelectedIndex;

                IReference r = engine.Patterns[IndexInPatternEditor].References[index];

                switch (r.Type)
                {
                    case "POOL":
                        PoolReference pool = (PoolReference)ReferenceEditor.Show(false, engine, r);
                        engine.Patterns[IndexInPatternEditor].References[index] = pool;
                        break;
                    case "PATT":
                        PatternReference patt = (PatternReference)ReferenceEditor.Show(false, engine, r);
                        engine.Patterns[IndexInPatternEditor].References[index] = patt;
                        break;
                    case "RINT":
                        RandomIntegerReference rint = (RandomIntegerReference)ReferenceEditor.Show(false, engine, r);
                        engine.Patterns[IndexInPatternEditor].References[index] = rint;
                        break;
                    case "RPAT":
                        RandomPatternReference rpat = (RandomPatternReference)ReferenceEditor.Show(false, engine, r);
                        engine.Patterns[IndexInPatternEditor].References[index] = rpat;
                        break;
                    case "IPAT":
                        IteratedPatternReference ipat = (IteratedPatternReference)ReferenceEditor.Show(false, engine, r);
                        engine.Patterns[IndexInPatternEditor].References[index] = ipat;
                        break;
                    default:
                        MessageBox.Show("Invalid Reference Type: " + r.Type);
                        return;
                }

                PushDatabaseStatus("Updated Reference in Pattern [" + engine.Patterns[IndexInPatternEditor].Name + "]");
                SaveDatabase();
                LoadPattern();
            }
        }

        private void addNewPatternToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputBoxResult result = InputBox.Show("New Pattern Name:", this.Text);
            if (result.OK)
            {
                string name = result.Text.Trim();
                if (name.Length > 0)
                {
                    engine.Patterns.Add(new Pattern(engine.GetNextPatternID(), name));
                    PushDatabaseStatus("Added pattern \"" + name + "\"");
                    SaveDatabase();
                    LoadPatternLists();
                }
            }
        }

        private void btnOpenTemplateEditor_Click(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1)
            {
                Pattern patt = engine.Patterns[IndexInPatternEditor];
                BaseEditorResult result = BaseEditor.Show(patt.Name, patt.Base);

                if (result.OK)
                {
                    engine.Patterns[IndexInPatternEditor].Base = result.Text;
                    PushDatabaseStatus("Updated template for [" + patt.Name + "]");
                    SaveDatabase();
                }
            }
        }

        private void btnAddReference_Click(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1 && comboAddReferenceType.Text.Length == 4)
            {
                string s = comboAddReferenceType.Items[comboAddReferenceType.SelectedIndex].ToString();
                switch (s)
                {
                    case "POOL":
                        if (engine.Pools.Count < 1)
                        {
                            MessageBox.Show("No pools to reference.");
                            return;
                        }
                        PoolReference pool = (PoolReference)ReferenceEditor.Show(true, engine, new PoolReference());
                        engine.Patterns[IndexInPatternEditor].References.Add(pool);
                        break;
                    case "PATT":
                        PatternReference patt = (PatternReference)ReferenceEditor.Show(true, engine, new PatternReference());
                        engine.Patterns[IndexInPatternEditor].References.Add(patt);
                        break;
                    case "RINT":
                        RandomIntegerReference rint = (RandomIntegerReference)ReferenceEditor.Show(true, engine, new RandomIntegerReference());
                        engine.Patterns[IndexInPatternEditor].References.Add(rint);
                        break;
                    case "RPAT":
                        RandomPatternReference rpat = (RandomPatternReference)ReferenceEditor.Show(true, engine, new RandomPatternReference());
                        engine.Patterns[IndexInPatternEditor].References.Add(rpat);
                        break;
                    case "IPAT":
                        IteratedPatternReference ipat = (IteratedPatternReference)ReferenceEditor.Show(true, engine, new IteratedPatternReference());
                        engine.Patterns[IndexInPatternEditor].References.Add(ipat);
                        break;
                    default:
                        return;
                }
                PushDatabaseStatus("Added Reference of type [" + s + "] to pattern [" + engine.Patterns[IndexInPatternEditor].Name + "]");
                SaveDatabase();
                LoadPattern();
            }
        }

        private void patternRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1)
            {
                MessageBox.Show(engine.Patterns[IndexInPatternEditor].Fill(engine));
            }
        }

        private void btnDeletePool_Click(object sender, EventArgs e)
        {
            if (IndexInPoolEditor != -1)
            {
                int PoolID = engine.Pools[IndexInPoolEditor].ID;

                int pattConflicts = 0;
                int poolConflicts = 0;

                // Check how many patterns reference this pool
                foreach (Pattern p in engine.Patterns)
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
                InputBoxResult result = InputBox.Show("Type the pool name to confirm deletion.", this.Text);
                if (result.OK && result.Text == engine.Pools[IndexInPoolEditor].Name)
                {
                    // Delete any patterns references to this pool
                    foreach (Pattern p in engine.Patterns)
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

        private void btnDeletePattern_Click(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1)
            {
                int PatternID = engine.Patterns[IndexInPatternEditor].ID;

                int pattConflicts = 0;

                // Check for any patterns that reference this pattern
                foreach (Pattern p in engine.Patterns)
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
                InputBoxResult result = InputBox.Show("Type the pattern name to continue with deletion.", this.Text);
                if (result.OK && result.Text == engine.Patterns[IndexInPatternEditor].Name)
                {
                    foreach (Pattern p in engine.Patterns)
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

                    string oldName = engine.Patterns[IndexInPatternEditor].Name;

                    engine.Patterns.RemoveAt(IndexInPatternEditor);
                    IndexInPatternEditor = -1;
                    PushDatabaseStatus("Deleted Pattern [" + oldName + "]");
                    SaveDatabase();
                    LoadPatternLists();
                }
            }
        }

        private void changeDatabaseLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.DefaultExt = ".db";
            dialog.FileName = DBFileLocation;
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

        private void btnMoveRefUp_Click(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1 && listPatternReferences.SelectedIndex > 0)
            {
                int index = listPatternReferences.SelectedIndex;
                IReference temp = engine.Patterns[IndexInPatternEditor].References[index];
                engine.Patterns[IndexInPatternEditor].References[index] = engine.Patterns[IndexInPatternEditor].References[index - 1];
                engine.Patterns[IndexInPatternEditor].References[index - 1] = temp;
                SaveDatabase();
                LoadPattern();
                listPatternReferences.SelectedIndex = index - 1;
            }
        }

        private void btnMoveRefDown_Click(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1 &&
                listPatternReferences.Items.Count > 1 &&
                listPatternReferences.SelectedIndex < listPatternReferences.Items.Count - 1)
            {
                int index = listPatternReferences.SelectedIndex;
                IReference temp = engine.Patterns[IndexInPatternEditor].References[index];
                engine.Patterns[IndexInPatternEditor].References[index] = engine.Patterns[IndexInPatternEditor].References[index + 1];
                engine.Patterns[IndexInPatternEditor].References[index + 1] = temp;
                SaveDatabase();
                LoadPattern();
                listPatternReferences.SelectedIndex = index - 1;
            }
        }

        private void btnDeleteReference_Click(object sender, EventArgs e)
        {
            if (IndexInPatternEditor != -1 &&
                listPatternReferences.SelectedIndex != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you'd like to delete this reference?", this.Text, MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    engine.Patterns[IndexInPatternEditor].References.RemoveAt(listPatternReferences.SelectedIndex);
                    PushDatabaseStatus("Deleted reference in pattern [" + engine.Patterns[IndexInPatternEditor].Name + "]");
                    SaveDatabase();
                    LoadPattern();
                }
            }
        }

        private void btnRunExport_Click(object sender, EventArgs e)
        {
            if (comboExportPattern.SelectedIndex != -1)
            {
                int it = 1;
                if (!(int.TryParse(textExportIterations.Text, out it)))
                {
                    MessageBox.Show("Invalid number of iterations. Defaulting to 1.");
                }
                Pattern p = engine.Patterns[comboExportPattern.SelectedIndex];

                textExport.Clear();

                for (int i = 0; i < it; i++)
                {
                    textExport.Text += p.Fill(engine);
                    textExport.Text += Environment.NewLine;
                    if (checkExportSeperators.Checked)
                    {
                        textExport.Text += "--" + Environment.NewLine;
                    }
                }
            }
        }

        private void textPatternName_TextChanged(object sender, EventArgs e)
        {
            FlagPatternChanged = true;
        }

        private void btnExportOut_Click(object sender, EventArgs e)
        {
            if (comboExportPattern.SelectedIndex != -1)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Text File|*.txt";
                save.AddExtension = true;

                DialogResult res = save.ShowDialog();

                if (res == DialogResult.OK)
                {
                    // Open file for writing
                    if(!File.Exists(save.FileName))
                    {
                        File.Create(save.FileName).Close();
                    }
                    StreamWriter o = new StreamWriter(save.FileName);

                    // Running
                    int it = 1;
                    if (!(int.TryParse(textExportIterations.Text, out it)))
                    {
                        MessageBox.Show("Invalid number of iterations. Defaulting to 1.");
                    }
                    Pattern p = engine.Patterns[comboExportPattern.SelectedIndex];

                    for (int i = 0; i < it; i++)
                    {
                        o.Write(p.Fill(engine) + Environment.NewLine);
                        if (checkExportSeperators.Checked)
                        {
                            o.WriteLine("-----------------------------------");
                        }
                    }

                    o.Flush();
                    o.Close();
                    PushDatabaseStatus("Wrote " + it + " iterations of " + p.Name + " to " + save.FileName);
                }
            }
        }
    }
}

