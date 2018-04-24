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
            if (File.Exists("./terg.db"))
            {
                PushDatabaseStatus("Database exists; Attempting to parse");

                engine.Load("./terg.db");
                PushDatabaseStatus("Database loaded. Pools: " + engine.Pools.Count + " Patterns: " + engine.Patterns.Count);
            }

            /* Load Lists */
            LoadListBoxes();
        }

        private void LoadListBoxes()
        {
            // Load Pool Names
            listPools.Items.Clear();
            foreach(Pool pool in engine.Pools)
            {
                listPools.Items.Add(pool.Name);
            }
            listPools.ClearSelected();
        }

        private void SaveDatabase()
        {
            PushDatabaseStatus("Preparing to save database");

            if (!File.Exists("./terg.db"))
            {
                PushDatabaseStatus("Database does not exist; Attempting to create");
                try
                {
                    File.Create("./terg.db");
                    PushDatabaseStatus("Database created");
                }
                catch (Exception e)
                {
                    PushDatabaseStatus("Error Creating Database: " + e.Message);
                    MessageBox.Show(e.Message);
                    return;
                }
            }
            else
            {
                engine.Save("./terg.db");
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
            if(IndexInPoolEditor != -1)
            {
                //Pool is selected already, fetch and clean data to check for updates
                string[] update = textBoxPoolEditor.Lines;
                for (int i = 0; i < update.Length; i++)
                {
                    update[i] = update[i].Trim();
                }

                //If the pool has been modified we want to check to see if changes should be saved
                if (engine.Pools[IndexInPoolEditor].List != update)
                {
                    DialogResult result = MessageBox.Show("You have unsaved changes to a pool. Would you like to save these before continuing?", Text, MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
                    switch(result)
                    {
                        case DialogResult.Yes:
                            //Save Changes
                            engine.Pools[IndexInPoolEditor].List = update;
                            PushDatabaseStatus("Pool [" + engine.Pools.[IndexInPoolEditor].Name + "] has been updated");
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
                if (Pools.ContainsKey(result.Text))
                {
                    MessageBox.Show("That pool already exists.");
                    return;
                }
                else
                {
                    Pools.Add(result.Text, new List<string>());
                    PushDatabaseStatus("Added pool \"" + result.Text + "\"");
                    SaveDatabase();
                    LoadListBoxes();
                }
            }
        }

        private void addItemToPoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If no pool is selected don't display the input
            if (listPools.SelectedIndex == -1)
            {
                MessageBox.Show("No Pool Selected!");
                return;
            }

            String pool = listPools.Items[listPools.SelectedIndex].ToString();

            InputBoxResult result = InputBox.Show("Item to add to " + pool + ":", this.Text);
            if (result.OK)
            {
                if (Pools[pool].Contains(result.Text))
                {
                    MessageBox.Show("That item already exists in the " + pool + " pool.");
                    return;
                }
                else
                {
                    Pools[pool].Add(result.Text);
                    PushDatabaseStatus("Added \"" + result.Text + "\" to " + pool);
                    SaveDatabase();
                    LoadListBoxes();
                }
            }
        }

        private void addMultipleToPoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO Add MultiInputBox dialog class
        }
    }
}
