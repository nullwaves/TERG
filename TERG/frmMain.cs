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

namespace TERG
{
    public partial class frmMain : Form
    {
        private Dictionary<String, List<string>> Pools;

        public frmMain()
        {
            InitializeComponent();
            Pools = new Dictionary<string, List<string>>();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(File.Exists("./terg.db"))
            {
                PushDatabaseStatus("Database exists; Attempting to parse");
                try {
                    Pools = JsonConvert.DeserializeObject<Dictionary<String, List<string>>>(File.ReadAllText("./terg.db"));
                    PushDatabaseStatus("Database loaded");
                } catch(Exception ex)
                {
                    
                    MessageBox.Show(ex.Message);
                }
            }

            if(Pools.Count < 1)
            {
                PushDatabaseStatus("Database empty; Adding default pool");
                List<string> debug = new List<string>();
                debug.Add("Red");
                debug.Add("Green");
                debug.Add("Blue");
                debug.Add("Black");
                debug.Add("White");
                Pools.Add("Colors", debug);
                SaveDatabase();
            }

            /* Load Lists */
            LoadListBoxes();
        }

        private void LoadListBoxes()
        {
            int index = listPools.SelectedIndex;

            // Load Pool Names
            listPools.Items.Clear();
            listPools.Items.AddRange(Pools.Keys.ToArray<string>());
            listPools.ClearSelected();

            listPools.SelectedIndex = index;
        }

        private void SaveDatabase()
        {
            PushDatabaseStatus("Preparing to save database");

            FileStream fs;

            if(!File.Exists("./terg.db"))
            {
                PushDatabaseStatus("Database does not exist; Attempting to create");
                try
                {
                    fs = File.Create("./terg.db");
                    PushDatabaseStatus("Database created");
                } catch (Exception e)
                {
                    PushDatabaseStatus("Error Creating Database: " + e.Message);
                    MessageBox.Show(e.Message);
                    return;
                }
            } else
            {
                PushDatabaseStatus("Database exists; attempting to open");
                try
                {
                    fs = File.OpenWrite("./terg.db");
                } catch (Exception e)
                {
                    PushDatabaseStatus("Error Opening Database: " + e.Message);
                    MessageBox.Show(e.Message);
                    return;
                }
            }

            try
            {
                StreamWriter writer = new StreamWriter(fs);
                writer.Write(JsonConvert.SerializeObject(Pools));
                writer.Dispose();
                writer.Close();
                PushDatabaseStatus("Database saved");
            } catch (Exception e)
            {
                PushDatabaseStatus("Error Writing Database: " + e.Message);
                MessageBox.Show(e.Message);
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
            listPoolItems.Items.Clear();
            if (listPools.SelectedIndex == -1) return;
            List<string> tmp;
            Pools.TryGetValue(listPools.SelectedItem.ToString(), out tmp);
            listPoolItems.Items.AddRange(tmp.ToArray<string>());
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
            if(result.OK)
            {
                if (Pools.ContainsKey(result.Text))
                {
                    MessageBox.Show("That pool already exists.");
                    return;
                } else
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
