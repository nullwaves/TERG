using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TERGEngine;
using TERGEngine.Reference;

namespace TERG
{
    public partial class ReferenceEditor : Form
    {
        private List<DistributionRow> DTBLRows = new List<DistributionRow>();
        private int DTBLIndexInEditor = -1;
        private Engine engine;

        public ReferenceEditor()
        {
            InitializeComponent();
        }

        private void ReferenceEditor_Load(object sender, EventArgs e)
        {
            DTBLcomboReferenceType.Items.Add("POOL");
            DTBLcomboReferenceType.Items.Add("PATT");
            DTBLcomboReferenceType.Items.Add("RINT");
            DTBLcomboReferenceType.Items.Add("RPAT");
            DTBLcomboReferenceType.Items.Add("IPAT");
            DTBLcomboReferenceType.Items.Add("DTBL");
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
                form.engine = e;
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
                    #region IPAT
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
                    #endregion
                    #region DTBL
                    case "DTBL":

                        //Convert to type
                        DistributionTableReference dtblr = (DistributionTableReference)r;

                        // Setup form
                        if (!n)
                        {
                            form.DTBL_setRows(dtblr.Rows);
                            form.DTBLlstRows_SelectedIndexChanged(form, new EventArgs());
                        }
                        else
                        {
                            form.DTBL_setRows(new List<DistributionRow>() { new DistributionRow() { Start = 1, End = 100, Value = "Empty" } });
                        }

                        result = form.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            dtblr.Rows = form.DTBLRows;
                        }

                        if (dtblr.Rows.Count < 1) dtblr.Rows.Add(new DistributionRow());

                        return dtblr;
                        #endregion
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
            if (!int.TryParse(RINTtextMin.Text, out _))
            {
                MessageBox.Show("Invalid data in Minimum Value field, please correct before continuing");
                return;
            }
            if (!int.TryParse(RINTtextMax.Text, out _))
            {
                MessageBox.Show("Invalid data in Maximum Value field, please correct before continuing");
                return;
            }
            if (!int.TryParse(RINTtextMinLength.Text, out _))
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
            if (!int.TryParse(IPATtextMin.Text, out _))
            {
                MessageBox.Show("Invalid data in Minimum Iterations field, please correct before continuing.");
                return;
            }
            if (!int.TryParse(IPATtextMax.Text, out _))
            {
                MessageBox.Show("Invalid data in Maximum Iterations field, please correct before continuing.");
                return;
            }
            if (IPATcomboPattern.SelectedIndex != -1)
            {
                if (!IPATcheckRandom.Checked)
                {
                    IPATtextMax.Text = IPATtextMin.Text;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void IPATcheckRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (!IPATcheckRandom.Checked)
            {
                IPATtextMax.Text = IPATtextMin.Text;
            }
            IPATtextMax.Enabled = IPATcheckRandom.Checked;
        }
        #endregion

        #region DTBL Functions
        private void DTBLbtnOk_Click(object sender, EventArgs e)
        {
            DTBL_saveCurrentRow();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void DTBL_setRows(List<DistributionRow> rows)
        {
            DTBLRows = rows;
            DTBLRows = DTBLRows.OrderBy(x => x.Start).ToList();
            DTBL_updateList();
        }

        private void DTBL_updateList()
        {
            DTBLlstRows.Items.Clear();
            foreach (var row in DTBLRows)
            {
                DTBLlstRows.Items.Add(row.ToString(engine));
            }
            //DTBLlstRows.SelectedIndex = -1;
            //DTBLIndexInEditor = -1;

        }

        private void DTBL_saveCurrentRow()
        {
            if (DTBLIndexInEditor != -1)
            {
                if (!DTBLchkUsePattern.Checked)
                {
                    DTBLRows[DTBLIndexInEditor].Value = DTBLtxtValue.Text;
                    DTBLRows[DTBLIndexInEditor].Reference = null;
                }
                else if (DTBLRows[DTBLIndexInEditor].Reference.GetType() != null)
                {
                    DTBLRows[DTBLIndexInEditor].Value = null;
                }
                else
                {
                    DTBLRows[DTBLIndexInEditor].Reference = null;
                    DTBLRows[DTBLIndexInEditor].Value = "Empty";
                }
                DTBLRows[DTBLIndexInEditor].Start = int.Parse(DTBLtxtStart.Text);
                DTBLRows[DTBLIndexInEditor].End = int.Parse(DTBLtxtEnd.Text);
            }
        }

        private void DTBLlstRows_SelectedIndexChanged(object sender, EventArgs e)
        {
            DTBL_saveCurrentRow();
            if (DTBLlstRows.SelectedIndex != -1)
            {
                DTBLIndexInEditor = DTBLlstRows.SelectedIndex;
                DTBLtxtStart.Text = DTBLRows[DTBLIndexInEditor].Start.ToString();
                DTBLtxtStart.Enabled = true;
                DTBLtxtEnd.Text = DTBLRows[DTBLIndexInEditor].End.ToString();
                DTBLtxtEnd.Enabled = true;
                if (DTBLRows[DTBLIndexInEditor].Value != null)
                {
                    DTBLtxtValue.Text = DTBLRows[DTBLIndexInEditor].Value;
                    DTBLtxtValue.Enabled = true;
                    DTBLchkUsePattern.Checked = false;
                    DTBLcomboReferenceType.SelectedIndex = -1;
                    DTBLcomboReferenceType.Enabled = false;
                }
                else
                {
                    DTBLtxtValue.Text = DTBLRows[DTBLIndexInEditor].Reference.ToString();
                    DTBLchkUsePattern.Checked = true;
                    DTBLcomboReferenceType.SelectedItem = DTBLRows[DTBLIndexInEditor].Reference.Type;
                    DTBLcomboReferenceType.Enabled = true;
                }
            }
            else
            {
                DTBLIndexInEditor = -1;
                DTBLtxtStart.Text = "";
                DTBLtxtStart.Enabled = false;
                DTBLtxtEnd.Text = "";
                DTBLtxtEnd.Enabled = false;
                DTBLtxtValue.Text = "";
                DTBLtxtValue.Enabled = false;
                DTBLchkUsePattern.Checked = false;
                DTBLcomboReferenceType.SelectedIndex = -1;
                DTBLcomboReferenceType.Enabled = false;
            }
        }

        private void DTBLchkUsePattern_CheckedChanged(object sender, EventArgs e)
        {
            if (DTBLchkUsePattern.Checked)
            {
                var rr = DTBLRows[DTBLIndexInEditor].Reference;
                DTBLtxtValue.Text = rr != null ? rr.ToString() : string.Empty;
                DTBLtxtValue.Enabled = false;
                DTBLcomboReferenceType.Enabled = true;
            }
            else
            {
                DTBLtxtValue.Text = "";
                DTBLtxtValue.Enabled = true;
                DTBLcomboReferenceType.Enabled = false;
            }
        }

        private void DTBLbtnAddRow_Click(object sender, EventArgs e)
        {
            var prev = DTBLRows[DTBLRows.Count - 1];
            if (prev.End - prev.Start > 1)
            {
                DTBL_saveCurrentRow();
                DTBLRows[DTBLRows.Count - 1].End -= (prev.End - prev.Start) / 2;
                DistributionRow row = new DistributionRow
                {
                    Start = DTBLRows[DTBLRows.Count - 1].End + 1
                };
                DTBLRows.Add(row);
                DTBL_setRows(DTBLRows);
                DTBLlstRows.SelectedIndex = DTBLRows.Count - 1;
            }
            else
            {
                _ = MessageBox.Show("Cannot fit another row at the end", "TERG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DTBLbtnRemoveRow_Click(object sender, EventArgs e)
        {
            if (DTBLIndexInEditor != -1)
            {
                DTBLRows.RemoveAt(DTBLIndexInEditor);
                DTBL_setRows(DTBLRows);
            }
        }

        private void DTBLtxtStart_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(DTBLtxtStart.Text, out int start))
            {
                /*
                if (DTBLIndexInEditor != 0 || start == 1)
                {
                    if (start <= DTBLRows[DTBLIndexInEditor].End)
                    {
                    */
                DTBLRows[DTBLIndexInEditor].Start = start;
                DTBL_updateList();
                /*
                    }
                    else
                    {
                        MessageBox.Show("Starting point cannot be greater than endpoint.", "TERG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DTBLtxtStart.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Starting point for first row must be 1.", "TERG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DTBLtxtStart.Focus();
                }
                */
            }
            else
            {
                MessageBox.Show("Starting point for row must be an integer 1-100", "TERG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DTBLtxtStart.Focus();
            }
        }

        private void DTBLtxtEnd_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(DTBLtxtEnd.Text, out int end))
            {
                /*
                if (DTBLIndexInEditor != DTBLRows.Count - 1 || end == 100)
                {
                */
                    if (end >= DTBLRows[DTBLIndexInEditor].Start)
                    {
                        DTBLRows[DTBLIndexInEditor].End = end;
                        DTBL_updateList();
                    }
                    else
                    {
                        MessageBox.Show("Ending point cannot be less than starting point.", "TERG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        DTBLtxtEnd.Focus();
                    }
                /*
                }
                else
                {
                    MessageBox.Show("Ending point for last row must be 100.", "TERG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DTBLtxtEnd.Focus();
                }
                */
            }
            else
            {
                MessageBox.Show("Ending point for row must be an integer 1-100", "TERG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DTBLtxtEnd.Focus();
            }
        }

        private void DTBLtxtValue_Leave(object sender, EventArgs e)
        {
            DTBLRows[DTBLIndexInEditor].Value = DTBLtxtValue.Text;
            DTBL_updateList();
        }

        private void DTBLbtnEditRowPattern_Click(object sender, EventArgs e)
        {
            if (DTBLIndexInEditor != -1)
            {
                if (DTBLRows[DTBLIndexInEditor].Reference != null && DTBLRows[DTBLIndexInEditor].Reference.Type == DTBLcomboReferenceType.Text)
                {
                    // Edit existing reference
                    var res = Show(false, engine, DTBLRows[DTBLIndexInEditor].Reference);
                    DTBLRows[DTBLIndexInEditor].Reference = res;
                }
                else
                {
                    IReference res;
                    switch (DTBLcomboReferenceType.Text)
                    {
                        case "POOL":
                            if (engine.Pools.Count < 1)
                            {
                                MessageBox.Show("No pools to reference.");
                                return;
                            }
                            res = Show(true, engine, new PoolReference());
                            break;
                        case "PATT":
                            res = Show(true, engine, new PatternReference());
                            break;
                        case "RINT":
                            res = Show(true, engine, new RandomIntegerReference());
                            break;
                        case "RPAT":
                            res = Show(true, engine, new RandomPatternReference());
                            break;
                        case "IPAT":
                            res = Show(true, engine, new IteratedPatternReference());
                            break;
                        case "DTBL":
                            res = Show(true, engine, new DistributionTableReference());
                            break;
                        default:
                            return;
                    }
                    if (res != null)
                    {
                        DTBLRows[DTBLIndexInEditor].Reference = res;
                        DTBLtxtValue.Text = res.ToString(engine);
                        DTBL_updateList();
                    }
                }
            }
        }
        #endregion
    }
}
