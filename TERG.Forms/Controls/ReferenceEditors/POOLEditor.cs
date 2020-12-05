using System.Windows.Forms;
using System.Linq;
using TERG.Core.Interfaces;
using TERG.Core.Models.References;

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
            throw new System.NotImplementedException();
        }

        public bool LoadReference(IReference reference)
        {
            CurrentReference = (PoolReference)reference;
            ComboPools.SelectedIndex = ComboPools.Items.IndexOf(Dashboard.Engine.GetPoolByID(CurrentReference.PoolID));
        }
    }
}
