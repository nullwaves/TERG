using System.Windows.Forms;
using TERG.Core.Interfaces;
using TERG.Core.Models.References;
using TERG.Core.Models;

namespace TERG.Forms.Controls.ReferenceEditors
{
    public partial class POOLEditor : UserControl, IReferenceTypeEditor
    {
        private PoolReference CurrentReference;

        public POOLEditor()
        {
            InitializeComponent();
            ComboPools.DataSource = Dashboard.Engine.GetPools();
        }

        public IReference GetReference()
        {
            try
            {
                CurrentReference.PoolID = ((Pool)ComboPools.SelectedItem).ID;
            }
            catch
            {
                CurrentReference.PoolID = -1;
            }
            return CurrentReference;
        }

        public bool LoadReference(IReference reference)
        {
            try
            {
                CurrentReference = (PoolReference)reference;
            }
            catch
            {
                return false;
            }
            ComboPools.SelectedIndex = CurrentReference.PoolID == -1 ? -1 : ComboPools.Items.IndexOf(Dashboard.Engine.GetPoolByID(CurrentReference.PoolID));
            return true;
        }
    }
}
