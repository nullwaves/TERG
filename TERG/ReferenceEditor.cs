using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TERGEngine;
using TERGEngine.Reference;
using static System.Windows.Forms.TabControl;

namespace TERG
{
    public partial class ReferenceEditor : Form
    {
        public ReferenceEditor()
        {
            InitializeComponent();
        }

        /* 
         * Show(
         *      bool        n:  A New reference
         *      int         t:  Reference Type
         *      Engine      e:  TERGEngine loaded
         *      Reference   r:  Reference to be edited
        */
        public static IReference Show(bool n, Engine e, IReference r)
        {
            using (ReferenceEditor form = new ReferenceEditor())
            {
                DialogResult result;
                form.SetPage(r.Type);
                switch (r.Type)
                {
                    #region PoolRef
                    case "POOL":

                        // Convert to type
                        PoolReference poolr = (PoolReference)r;

                        // Setup form
                        foreach (Pool p in e.Pools)
                        {
                            form.POOLcomboPool.Items.Add(p.Name);
                        }
                        if (!n)
                        {
                            form.POOLcomboPool.SelectedIndex = form.POOLcomboPool.Items.IndexOf(e.FindPoolById(poolr.PoolID).Name);
                        }
                        else
                        {
                            form.POOLcomboPool.SelectedIndex = 0;
                        }

                        // Show Form and return results
                        result = form.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            // All's good return the new reference
                            poolr.PoolID = e.Pools[form.POOLcomboPool.SelectedIndex].ID;
                        }

                        return poolr;
                    #endregion
                    #region PatternRef
                    case "PATT":

                        // Convert to type
                        PatternReference pattr = (PatternReference)r;

                        // Setup form
                        foreach (Pattern p in e.Patterns)
                        {
                            form.PATTcomboPattern.Items.Add(p.Name);
                        }
                        if (!n)
                        {
                            form.PATTcomboPattern.SelectedIndex = form.PATTcomboPattern.Items.IndexOf(e.FindPatternById(pattr.PatternID).Name);
                        }
                        else
                        {
                            form.PATTcomboPattern.SelectedIndex = 0;
                        }

                        // Show form and return results
                        result = form.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            pattr.PatternID = e.Patterns[form.PATTcomboPattern.SelectedIndex].ID;
                        }

                        return pattr;
                    #endregion
                    #region RIntegerRef
                    case "RINT":

                        // Convert to type
                        RandomIntegerReference rintr = (RandomIntegerReference)r;

                        // Setup form
                        if (n)
                        {
                            form.RINTtextMin.Text = "0";
                            form.RINTtextMax.Text = "9";
                            form.RINTtextMinLength.Text = "0";
                        }
                        else
                        {
                            form.RINTtextMin.Text = rintr.Min.ToString();
                            form.RINTtextMax.Text = rintr.Max.ToString();
                            form.RINTtextMinLength.Text = rintr.MinLength.ToString();
                        }

                        result = form.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            rintr.Min = int.Parse(form.RINTtextMin.Text);
                            rintr.Max = int.Parse(form.RINTtextMax.Text);
                            rintr.MinLength = int.Parse(form.RINTtextMinLength.Text);
                        }

                        return rintr;
                    #endregion
                    #region RPAT
                    case "RPAT":
                        // Convert to type
                        RandomPatternReference rpatr = (RandomPatternReference)r;

                        // Setup form
                        foreach (Pattern p in e.Patterns)
                        {
                            form.RPATlistPatterns.Items.Add(p.Name);
                        }

                        if (!n)
                        {
                            foreach (int id in rpatr.PatternList)
                            {
                                form.RPATlistSelected.Items.Add(e.FindPatternById(id).Name);
                            }
                        }

                        result = form.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            var plist = new List<int>();
                            foreach (string s in form.RPATlistSelected.Items)
                            {
                                int index = form.RPATlistPatterns.Items.IndexOf(s);
                                plist.Add(e.Patterns[index].ID);
                            }

                            rpatr.PatternList = plist;
                        }

                        return rpatr;
                    #endregion
                    case "IPAT":

                        // Convert to type
                        IteratedPatternReference ipatr = (IteratedPatternReference)r;

                        // Setup form
                        foreach (Pattern p in e.Patterns)
                        {
                            form.IPATcomboPattern.Items.Add(p.Name);
                        }
                        if (!n)
                        {
                            form.IPATcomboPattern.SelectedIndex = form.IPATcomboPattern.Items.IndexOf(e.FindPatternById(ipatr.PatternID).Name);
                            form.IPATtextMin.Text = ipatr.MinimumIterations.ToString();
                            form.IPATtextMax.Text = ipatr.MaximumIterations.ToString();
                            form.IPATcheckRandom.Checked = ipatr.Random;
                        }
                        else
                        {
                            form.IPATcomboPattern.SelectedIndex = 0;
                            form.IPATtextMin.Text = "1";
                            form.IPATtextMax.Text = "1";
                            form.IPATcheckRandom.Checked = false;
                        }

                        // Show form and return results
                        result = form.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            ipatr.PatternID = e.Patterns[form.IPATcomboPattern.SelectedIndex].ID;
                            ipatr.MinimumIterations = int.Parse(form.IPATtextMin.Text);
                            ipatr.MaximumIterations = int.Parse(form.IPATtextMax.Text);
                        }

                        return ipatr;
                }

                throw new Exception("Invalid Reference Type: " + r.Type);
            }
        }

        private void SetPage(string type)
        {
            // tabControl.TabPages.Clear();
            // tabControl.TabPages.Add(Tabs[Tabs.IndexOfKey(type.ToUpper())]);
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                if (tabControl.TabPages[i].Text == type)
                {
                    TabPage use = tabControl.TabPages[i];
                    tabControl.TabPages.Clear();
                    tabControl.TabPages.Add(use);
                    return;
                }
            }
        }

        private void PATTbtnOK_Click(object sender, EventArgs e)
        {
            if (PATTcomboPattern.SelectedIndex != -1)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Must have a valid pattern selected.");
            }
        }

        private void POOLbtnOK_Click(object sender, EventArgs e)
        {
            if (POOLcomboPool.SelectedIndex != -1)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Must have a valid pool selected.");
            }
        }

        private void RINTbtnOK_Click(object sender, EventArgs e)
        {
            int test;
            if (!int.TryParse(RINTtextMin.Text, out test))
            {
                MessageBox.Show("Invalid data in Minimum Value field, please correct before continuing");
                return;
            }
            if (!int.TryParse(RINTtextMax.Text, out test))
            {
                MessageBox.Show("Invalid data in Maximum Value field, please correct before continuing");
                return;
            }
            if (!int.TryParse(RINTtextMinLength.Text, out test))
            {
                MessageBox.Show("Invalid data in Minimum Length field, please correct before continuing");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #region RPAT Functions
        private void RPATbtnOK_Click(object sender, EventArgs e)
        {
            if (RPATlistSelected.Items.Count < 1)
            {
                MessageBox.Show("Must have at least 1 pattern selected.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void RPATbtnAdd_Click(object sender, EventArgs e)
        {
            if (RPATlistPatterns.SelectedIndex != -1)
            {
                string s = RPATlistPatterns.Items[RPATlistPatterns.SelectedIndex].ToString();
                if (!(RPATlistSelected.Items.Contains(s)))
                {
                    RPATlistSelected.Items.Add(s);
                }
            }
        }

        private void RPATbtnRemove_Click(object sender, EventArgs e)
        {
            if (RPATlistSelected.SelectedIndex != -1)
            {
                RPATlistSelected.Items.RemoveAt(RPATlistSelected.SelectedIndex);
            }
        }

        private void RPATbtnClear_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you'd like to clear all selected patterns?", this.Text, MessageBoxButtons.YesNoCancel);

            if (r == DialogResult.Yes)
            {
                RPATlistSelected.Items.Clear();
            }
        }
        #endregion RPAT Functions

        #region IPAT Functions
        private void IPATbtnOK_Click(object sender, EventArgs e)
        {
            int test;
            if (!int.TryParse(IPATtextMin.Text, out test))
            {
                MessageBox.Show("Invalid data in Minimum Iterations field, please correct before continuing.");
                return;
            }
            if (!int.TryParse(IPATtextMax.Text, out test))
            {
                MessageBox.Show("Invalid data in Maximum Iterations field, please correct before continuing.");
                return;
            }
            if (IPATcomboPattern.SelectedIndex != -1)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void IPATcheckRandom_CheckedChanged(object sender, EventArgs e)
        {
            if(!IPATcheckRandom.Checked)
            {
                IPATtextMax.Text = IPATtextMin.Text;
            }
            IPATtextMax.Enabled = IPATcheckRandom.Checked;
        }
        #endregion
    }
}
