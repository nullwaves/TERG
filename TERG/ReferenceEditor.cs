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
        public const int POOL = 10;
        public const int PATT = 20;

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

                        // Show form and return results
                        result = form.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            pattr.PatternID = e.Patterns[form.PATTcomboPattern.SelectedIndex].ID;
                        }

                        return pattr;
                        #endregion
                }

                throw new Exception("Invalid Reference Type: " + r.Type);
            }
        }

        private void SetPage(string type)
        {
            // tabControl.TabPages.Clear();
            // tabControl.TabPages.Add(Tabs[Tabs.IndexOfKey(type.ToUpper())]);
            for(int i = 0; i < tabControl.TabPages.Count; i++)
            {
                if(tabControl.TabPages[i].Text == type)
                {
                    TabPage use = tabControl.TabPages[i];
                    tabControl.TabPages.Clear();
                    tabControl.TabPages.Add(use);
                    return;
                }
            }
        }

        private void ReferenceEditor_Load(object sender, EventArgs e)
        {
        }

        private void PATTbtnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void POOLbtnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
