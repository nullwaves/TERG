using System.Linq;
using System.Windows.Forms;
using TERG.Core;
using TERG.Core.Models;

namespace TERG.Forms.Controls
{
    public partial class PoolMenu : UserControl
    {
        private readonly Engine Engine;

        private object SelectedPool => ListboxPools.SelectedItem;

        private PoolMenu()
        {
        }

        public PoolMenu(Engine e)
        {
            Engine = e;

            InitializeComponent();

            RefreshPoolList();
        }

        public void RefreshPoolList()
        {
            int oldId = SelectedPool != null ? ((Pool)SelectedPool).ID : -1;
            ListboxPools.Items.Clear();
            ListboxPools.Items.AddRange(Engine.GetPools().ToArray());
            ListboxPools.SelectedIndex = oldId != -1 ? ListboxPools.Items.IndexOf(Engine.GetPoolByID(oldId)) : -1;
        }
    }
}