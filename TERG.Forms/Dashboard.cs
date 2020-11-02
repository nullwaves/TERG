using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TERG.Core;
using TERG.Core.Models;
using TERG.Forms.Controls;

namespace TERG.Forms
{
    public partial class Dashboard : Form
    {
        private Engine engine;

        private IEnumerable<Pattern> Patterns => engine.GetPatterns();
        private IEnumerable<Pool> Pools => engine.GetPools();

        private readonly string DBFileLocation = (string)Properties.Settings.Default["DatabaseFileLocation"];
        private PoolMenu PoolMenu;
        private PatternMenu PatternMenu;

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
                    _ = MessageBox.Show(ex.ToString());
                    Close();
                }
            }
            else
            {
                engine = new Engine();
                SaveDatabase();
            }

            PoolMenu = new PoolMenu(engine)
            {
                Dock = DockStyle.Fill
            };
            tabPoolEditor.Controls.Add(PoolMenu);

            PatternMenu = new PatternMenu(engine)
            {
                Dock = DockStyle.Fill
            };
            tabPatternEditor.Controls.Add(PatternMenu);
        }

        private void SaveDatabase()
        {
            _ = SaveDatabase(DBFileLocation);
        }

        private bool SaveDatabase(string file)
        {
            bool result = engine.Save(file);
            string message = result ? "Database Saved" : "ERROR: Could not save database!";
            PushDatabaseStatus(message);
            return true;
        }

        private void PushDatabaseStatus(string Status)
        {
            statusDatabase.Text = DateTime.Now + " " + Status;
            Console.WriteLine(statusDatabase.Text);
            txtEventLog.Text += statusDatabase.Text + "\r\n";
            txtEventLog.ScrollToCaret();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ab = new TERGAboutBox())
            {
                _ = ab.ShowDialog();
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
                    Pool newPool = engine.AddPool(new Pool() { Name = name });
                    PushDatabaseStatus($"Added pool [{newPool.ID}] {newPool.Name}");
                    SaveDatabase();
                    ((PoolMenu)tabPoolEditor.Controls[0]).RefreshPoolList();
                }
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
                    ((PatternMenu)tabPatternEditor.Controls[0]).RefreshPatternList();
                }
                else
                {
                    PushDatabaseStatus("Failed to add Pattern");
                }
            }
        }

        private void PatternRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PatternMenu.Selected != null)
            {
                _ = MessageBox.Show(engine.Composer.Compose(PatternMenu.Selected, 1, Composer.HeaderAndFooterSetting.ALL).First());
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
                    _ = MessageBox.Show("Restarting...");
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
        }

        private void BtnRunExport_Click(object sender, EventArgs e)
        {
            if (comboExportPattern.SelectedItem.GetType() == typeof(Pattern))
            {
                if (!int.TryParse(textExportIterations.Text, out int it))
                {
                    it = 1;
                }
                Pattern p = (Pattern)comboExportPattern.SelectedItem;

                List<string> results = engine.Composer.Compose(p, it, Composer.HeaderAndFooterSetting.NONE);

                textExport.Clear();

                foreach (string result in results)
                {
                    textExport.Text += result + Environment.NewLine + (checkExportSeperators.Checked ? "----END OF RESULT----" + Environment.NewLine : string.Empty);
                }
                PushDatabaseStatus("Generated " + results.Count + " iterations of " + p.Name);
            }
        }

        private void BtnExportOut_Click(object sender, EventArgs e)
        {
            if (comboExportPattern.SelectedItem.GetType() == typeof(Pattern))
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
                    if (!int.TryParse(textExportIterations.Text, out int it))
                    {
                        it = 1;
                    }
                    Pattern p = (Pattern)comboExportPattern.SelectedItem;

                    List<string> results = engine.Composer.Compose(p, it, Composer.HeaderAndFooterSetting.NONE);

                    foreach (string result in results)
                    {
                        string value = result + Environment.NewLine + (checkExportSeperators.Checked ? "----END OF RESULT----" + Environment.NewLine : string.Empty);
                        o.WriteLine(value);
                        o.Flush();
                    }
                    o.Close();
                    PushDatabaseStatus($"Wrote {it} iterations of {p.Name} to {save.FileName}");
                }
                save.Dispose();
            }
        }
    }
}