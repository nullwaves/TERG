using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TERG.Core;
using TERG.Core.Interfaces;
using TERG.Core.Models;
using TERG.Core.Models.References;

namespace TERG.Forms
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
            DTBLcomboReferenceType.Items.AddRange(ReferenceFactory.typeMap.Keys.ToArray());
        }

        /*
         * Show(
         *      bool        n:  A New reference
         *      Engine      e:  TERG.Core loaded
         *      Reference   r:  Reference to be edited
        */

        public static IReference Show(bool newFlag, Engine e, IReference r)
        {
            using (ReferenceEditor form = new ReferenceEditor())
            {
                DialogResult result;
                form.SetPage(r.Type);
                form.engine = e;

                switch (r.Type)
                {
                    case "POOL":
                        // Convert to type
                        PoolReference poolr = (PoolReference)r;

                        // Setup form
                        form.POOLcomboPool.DisplayMember = "Name";
                        form.POOLcomboPool.Items.AddRange(e.GetPools().ToArray());
                        form.POOLcomboPool.SelectedIndex = newFlag ? 0 : form.POOLcomboPool.Items.IndexOf(e.GetPoolByID(poolr.PoolID));

                        // Show Form and return results
                        result = form.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            // All's good return the new reference
                            poolr.PoolID = ((Pool)form.POOLcomboPool.SelectedItem).ID;
                        }

                        return poolr;

                    case "PATT":
                        // Convert to type
                        PatternReference pattr = (PatternReference)r;

                        // Setup form
                        form.PATTcomboPattern.DisplayMember = "Name";
                        form.PATTcomboPattern.Items.AddRange(e.GetPatterns().ToArray());
                        form.PATTcomboPattern.SelectedIndex = newFlag ? 0 : form.PATTcomboPattern.Items.IndexOf(e.GetPatternByID(pattr.PatternID));

                        // Show form and return results
                        result = form.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            pattr.PatternID = ((Pattern)form.PATTcomboPattern.SelectedItem).ID;
                        }

                        return pattr;

                    case "RINT":
                        // Convert to type
                        RandomIntegerReference rintr = (RandomIntegerReference)r;

                        // Setup form
                        if (newFlag)
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

                    case "RPAT":
                        // Convert to type
                        RandomPatternReference rpatr = (RandomPatternReference)r;

                        // Setup form
                        form.RPATlistPatterns.DisplayMember = "Name";
                        form.RPATlistPatterns.Items.AddRange(e.GetPatterns().ToArray());
                        form.RPATlistSelected.DisplayMember = "Name";
                        foreach (int id in rpatr.PatternList)
                        {
                            form.RPATlistSelected.Items.Add(e.GetPatternByID(id));
                        }

                        result = form.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            var plist = new List<int>();
                            foreach (Pattern p in form.RPATlistSelected.Items)
                            {
                                plist.Add(p.ID);
                            }

                            rpatr.PatternList = plist;
                        }

                        return rpatr;

                    case "IPAT":

                        // Convert to type
                        IteratedPatternReference ipatr = (IteratedPatternReference)r;

                        // Setup form
                        form.IPATcomboPattern.Items.AddRange(e.GetPatterns().ToArray());
                        var pat = e.GetPatternByID(ipatr.PatternID);
                        form.IPATcomboPattern.SelectedIndex = pat != null ? form.IPATcomboPattern.Items.IndexOf(pat.Name) : 0;
                        form.IPATtextMin.Text = ipatr.MinimumIterations.ToString();
                        form.IPATtextMax.Text = ipatr.MaximumIterations.ToString();
                        form.IPATcheckRandom.Checked = ipatr.Random;

                        // Show form and return results
                        result = form.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            ipatr.PatternID = ((Pattern)form.IPATcomboPattern.SelectedItem).ID;
                            ipatr.MinimumIterations = int.Parse(form.IPATtextMin.Text);
                            ipatr.MaximumIterations = int.Parse(form.IPATtextMax.Text);
                        }

                        return ipatr;

                    case "DTBL":

                        //Convert to type
                        DistributionTableReference dtblr = (DistributionTableReference)r;

                        // Setup form
                        if (!newFlag)
                        {
                            form.DTBL_setRows(dtblr.Rows);
                            form.DTBLlstRows_SelectedIndexChanged(form, new EventArgs());
                        }
                        else
                        {
                            form.DTBL_setRows(new List<DistributionRow>() { new DistributionRow() });
                        }

                        result = form.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            dtblr.Rows = form.DTBLRows;
                        }

                        if (dtblr.Rows.Count < 1) dtblr.Rows.Add(new DistributionRow());

                        return dtblr;
                }

                throw new Exception("Invalid Reference Type: " + r.Type);
            }
        }

        private void SetPage(string type)
        {
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
            if (PATTcomboPattern.SelectedItem.GetType() == typeof(Pattern))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Must have a valid pattern selected.");
            }
        }

        private void POOLbtnOK_Click(object sender, EventArgs e)
        {
            if (POOLcomboPool.SelectedItem.GetType() == typeof(Pool))
            {
                DialogResult = DialogResult.OK;
                Close();
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

            DialogResult = DialogResult.OK;
            Close();
        }

        private void RPATbtnOK_Click(object sender, EventArgs e)
        {
            if (RPATlistSelected.Items.Count < 1)
            {
                MessageBox.Show("Must have at least 1 pattern selected.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void RPATbtnAdd_Click(object sender, EventArgs e)
        {
            if (RPATlistPatterns.SelectedItem.GetType() == typeof(Pattern))
            {
                var pattern = RPATlistPatterns.SelectedItem;
                if (!RPATlistSelected.Items.Contains(pattern))
                {
                    RPATlistSelected.Items.Add(pattern);
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
            DialogResult r = MessageBox.Show("Are you sure you'd like to clear all selected patterns?", Text, MessageBoxButtons.YesNoCancel);

            if (r == DialogResult.Yes)
            {
                RPATlistSelected.Items.Clear();
            }
        }

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
            if (IPATcomboPattern.SelectedItem.GetType() == typeof(Pattern))
            {
                if (!IPATcheckRandom.Checked)
                {
                    IPATtextMax.Text = IPATtextMin.Text;
                }
                DialogResult = DialogResult.OK;
                Close();
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

        private void DTBLbtnOk_Click(object sender, EventArgs e)
        {
            DTBL_saveCurrentRow();
            DialogResult = DialogResult.OK;
            Close();
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
                DTBLlstRows.Items.Add(engine.ShorthandService.PrettyDistributionRow(row));
            }
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
                DTBLRows[DTBLIndexInEditor].Start = start;
                DTBL_updateList();
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
                    IReference res = Show(true, engine, ReferenceFactory.Create(DTBLcomboReferenceType.Text));
                    if (res != null)
                    {
                        DTBLRows[DTBLIndexInEditor].Reference = res;
                        DTBLtxtValue.Text = engine.ShorthandService.PrettyReference(res);
                        DTBL_updateList();
                    }
                }
            }
        }
    }
}