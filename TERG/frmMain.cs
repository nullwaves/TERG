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

namespace TERG
{
    public partial class frmMain : Form
    {
        private Engine engine;
        private int IndexInPoolEditor = -1;

        public frmMain()
        {
            InitializeComponent();
            engine = new Engine();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists("terg.db"))
            {
                PushDatabaseStatus("Database exists; Attempting to parse");

                engine = engine.Load("terg.db");
                PushDatabaseStatus("Database loaded. Pools: " + engine.Pools.Count + " Patterns: " + engine.Patterns.Count);
            }

            /* Load Lists */
            LoadListBoxes();
        }

        private void LoadListBoxes()
        {
            // Load Pool Names
            listPools.Items.Clear();
            foreach (Pool pool in engine.Pools)
            {
                listPools.Items.Add(pool.Name);
            }
            listPools.ClearSelected();
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
                    File.Create("terg.db");
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
            else
            {
                //Save the data to the file.
                engine.Save("terg.db");
                PushDatabaseStatus("Database saved");
            }
        }

        private void PushDatabaseStatus(string Status)
        {
            statusDatabase.Text = DateTime.Now + " " + Status;
            Console.WriteLine(statusDatabase.Text);
            txtEventLog.Text += statusDatabase.Text + "\r\n";
        }

        private void listPools_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IndexInPoolEditor != -1)
            {
                //Pool is selected already, fetch and clean data to check for updates
                string[] update = textBoxPoolEditor.Lines;
                for (int i = 0; i < update.Length; i++)
                {
                    update[i] = update[i].Trim();
                }

                //If the pool has been modified we want to check to see if changes should be saved
                if (!engine.Pools[IndexInPoolEditor].List.Equals(update))
                {
                    DialogResult result = MessageBox.Show("You have unsaved changes to a pool. Would you like to save these before continuing?", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            //Save Changes
                            engine.Pools[IndexInPoolEditor].List = update;
                            SaveDatabase();
                            PushDatabaseStatus("Pool [" + engine.Pools[IndexInPoolEditor].Name + "] has been updated");
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

            //Should now be able to load data
            textBoxPoolEditor.Clear();
            textBoxPoolEditor.Lines = engine.Pools[listPools.SelectedIndex].List;
            IndexInPoolEditor = listPools.SelectedIndex;
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
                    LoadListBoxes();
                }
            }
        }
    }
}
