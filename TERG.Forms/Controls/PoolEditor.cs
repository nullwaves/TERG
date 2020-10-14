using System;
using System.Windows.Forms;
using TERG.Core.Models;

namespace TERG.Forms.Controls
{
    public partial class PoolEditor : UserControl
    {
        public event EventHandler<Pool> PoolSaved;

        public event EventHandler<Pool> PoolDeleted;

        private Pool CurrentPool;

        public PoolEditor()
        {
            CurrentPool = null;
            InitializeComponent();
        }

        internal bool LoadPool(Pool p)
        {
            CurrentPool = p;
            RefreshPool();
            return true;
        }

        internal void RefreshPool()
        {
            TextBoxPoolID.Text = CurrentPool.ID.ToString();
            TextBoxPoolName.Text = CurrentPool.Name;
            TextBoxList.Lines = CurrentPool.List;
            TextBoxPoolName.Enabled = true;
            TextBoxList.Enabled = true;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            CurrentPool.Name = TextBoxPoolName.Text.Trim();
            CurrentPool.List = TextBoxList.Lines;
            PoolSaved(this, CurrentPool);
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshPool();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            PoolDeleted(this, CurrentPool);
            ResetFields();
        }

        private void ResetFields()
        {
            CurrentPool = null;
            TextBoxPoolID.Text = string.Empty;
            TextBoxPoolName.Text = string.Empty;
            TextBoxList.Text = string.Empty;
            TextBoxPoolName.Enabled = false;
            TextBoxList.Enabled = false;
        }
    }
}