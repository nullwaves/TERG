using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TERG.Core;
using TERG.Core.Models;

namespace TERG.Forms.Controls
{
    public partial class PoolMenu : UserControl
    {
        private readonly Engine Engine;

        private Pool SelectedPool => ListboxPools.SelectedItem != null ? (Pool)ListboxPools.SelectedItem : null;
        private IEnumerable<Pool> Pools => Engine.GetPools();
        private readonly PoolEditor _editor;

        private PoolMenu()
        {
        }

        public PoolMenu(Engine e)
        {
            Engine = e;

            InitializeComponent();

            RefreshPoolList();
            _editor = new PoolEditor
            {
                Dock = DockStyle.Fill
            };
            _editor.PoolSaved += new EventHandler<Pool>(PoolEditor_PoolSaved);
            _editor.PoolDeleted += new EventHandler<Pool>(PoolEditor_PoolDeleted);
            PoolMenuSplit.Panel2.Controls.Add(_editor);
        }

        private void PoolEditor_PoolDeleted(object sender, Pool pool)
        {
            if (Engine.RemovePool(pool.ID))
            {
                ListboxPools.SelectedIndex = -1;
                RefreshPoolList();
            }
        }

        private void PoolEditor_PoolSaved(object sender, Pool pool)
        {
            if (Engine.UpdatePool(pool))
            {
                RefreshPoolList();
            }
        }

        public void RefreshPoolList()
        {
            int oldId = SelectedPool != null ? SelectedPool.ID : -1;
            ListboxPools.Items.Clear();
            ListboxPools.Items.AddRange(Pools.ToArray());
            ListboxPools.SelectedIndex = oldId != -1 ? ListboxPools.Items.IndexOf(Engine.GetPoolByID(oldId)) : -1;
        }

        private void ListboxPools_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (ListboxPools.SelectedIndex > -1)
            {
                _editor.LoadPool(SelectedPool);
            }
        }
    }
}