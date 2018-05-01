using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
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


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists("terg.db"))
            {
                PushDatabaseStatus("Database exists; Attempting to parse");

                try
                {
                    engine = Engine.Load("terg.db");
                    PushDatabaseStatus("Database loaded. Pools: " + engine.Pools.Count + " Patterns: " + engine.Patterns.Count);
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

            /* Load Lists */
            LoadPoolLists();
            LoadPatternLists();
        }

        private void LoadPatternLists()
        {
            listPatterns.Items.Clear();
            foreach (Pattern p in engine.Patterns)
            {
                listPatterns.Items.Add(p.Name);
            }
            listPatterns.ClearSelected();
        }

        private void LoadPattern()
        {
            // Clean up first.
            btnOpenTemplateEditor.Enabled = false;
            textPatternName.Clear();
            listPatternReferences.Items.Clear();

            if (IndexInPatternEditor != -1)
            {
                Pattern p = engine.Patterns[IndexInPatternEditor];          // Fetch pattern for easy reference
                textPatternName.Text = p.Name;                              // Fill TextBox textPatternName
                foreach (IReference r in p.References)
                {
                    listPatternReferences.Items.Add(r.ToString());          // Add Each Reference to the ListBox for References
                }

                btnOpenTemplateEditor.Enabled = true;                       // Enable access to the Template Editor
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
        }

        private void LoadPool()
        {
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

                FlagPoolChanged = false;
            }
            else
            {
                textBoxPoolEditor.Clear();
                textPoolName.Clear();
                comboPoolParent.SelectedIndex = 0;
            }
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
            PushDatabaseStatus("Preparing to save database");

            //Check to see if database exists
            if (!File.Exists("terg.db"))
            {
                //It doesn't exist, so we make one
                PushDatabaseStatus("Database does not exist; Attempting to create");
                try
                {
                    File.Create("terg.db").Close();
                    PushDatabaseStatus("Database created");
                }
                catch (Exception e)
                {
                    //Unless we don't.
                    PushDatabaseStatus("Error Creating Database: " + e.Message);
                    MessageBox.Show(e.Message);
                    return;
                }
            }

            //Save the data to the file.
            engine.Save("terg.db");
            PushDatabaseStatus("Database saved");

        }

        private void PushDatabaseStatus(string Status)
        {
            statusDatabase.Text = DateTime.Now + " " + Status;
            Console.WriteLine(statusDatabase.Text);
            txtEventLog.Text += statusDatabase.Text + "\r\n";
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
                    DialogResult result = MessageBox.Show("You have unsaved changes to a pool. Would you like to save these before continuing?", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            //Save Changes
                            SavePool();
                            break;
                        case DialogResult.No:
                            //Don't Save Changes, just skip to loading the next pool
                            break;
                        default:
                            //Neither, reset the index back to the previous and abort mission
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
                if (result.Text.Trim().Length > 0)
                {
                    engine.Pools.Add(new Pool(engine.GetNextPoolID(), result.Text));
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

        }
    }
}
