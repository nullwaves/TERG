using System.Windows.Forms;
using TERG.Core.Models;

namespace TERG.Forms.Controls
{
    public partial class PoolEditor : UserControl
    {
        private Pool CurrentPool;

        public PoolEditor()
        {
            CurrentPool = null;
            InitializeComponent();
        }

        internal bool LoadPool(Pool p)
        {
            CurrentPool = p;
            TextBoxPoolID.Text = p.ID.ToString();
            TextBoxPoolName.Text = p.Name;
            TextBoxList.Lines = p.List;
            return true;
        }
    }
}