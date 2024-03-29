﻿using System;
using System.Windows.Forms;

namespace TERG.Forms
{
    public partial class BaseEditor : Form
    {
        public string PoolName;
        public string[] InitBaseText;

        public BaseEditor()
        {
            InitializeComponent();
        }

        public static BaseEditorResult Show(string poolName, string[] baseText)
        {
            using (BaseEditor form = new BaseEditor())
            {
                form.PoolName = poolName;
                form.InitBaseText = baseText;
                form.lblPoolName.Text = "Pool: [" + poolName + "]";
                form.textBoxBase.Lines = baseText;

                DialogResult result = form.ShowDialog();

                BaseEditorResult retval = new BaseEditorResult();

                if (result == DialogResult.OK)
                {
                    retval.OK = true;
                    retval.Text = form.textBoxBase.Lines;
                }

                return retval;
            }
        }

        private void btnSavePool_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnRefreshPool_Click(object sender, EventArgs e)
        {
            lblPoolName.Text = "Pool: [" + PoolName + "]";
            textBoxBase.Lines = InitBaseText;
        }

        private void btnInsertReference_Click(object sender, EventArgs e)
        {
            textBoxBase.Paste("[@]");
        }
    }

    public class BaseEditorResult
    {
        public bool OK;
        public string[] Text;
    }
}
