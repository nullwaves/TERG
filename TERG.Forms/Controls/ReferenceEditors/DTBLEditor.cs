using System.Windows.Forms;
using TERG.Core.Interfaces;
using TERG.Core.Models.References;
using TERG.Core.Services;

namespace TERG.Forms.Controls.ReferenceEditors
{
    public partial class DTBLEditor : UserControl, IReferenceTypeEditor
    {
        private DistributionTableReference CurrentReference;
        private bool RowSelected => ListRows.SelectedIndex > -1;
        private DistributionRow SelectedRow => RowSelected ? CurrentReference.Rows[ListRows.SelectedIndex] : null;
        private ShorthandService Shorthand => Dashboard.Engine.ShorthandService;

        public DTBLEditor()
        {
            InitializeComponent();
        }

        public IReference GetReference()
        {
            return CurrentReference;
        }

        public bool LoadReference(IReference reference)
        {
            try
            {
                CurrentReference = (DistributionTableReference)reference;
            }
            catch
            {
                return false;
            }

            RefreshRows();
            return true;
        }

        public void LoadRow(DistributionRow row)
        {
            TextBoxRowStart.Text = row.Start.ToString();
            TextBoxRowStart.Enabled = true;
            TextBoxRowEnd.Text = row.End.ToString();
            TextBoxRowValue.Text = row.Value ?? Shorthand.PrettyReference(row.Reference);
            CheckBoxUseReference.Checked = row.Reference != null;
            TextBoxRowValue.Enabled = !CheckBoxUseReference.Checked;
        }

        public void RefreshRows()
        {
            ListRows.Items.Clear();

            foreach (var row in CurrentReference.Rows)
            {
                ListRows.Items.Add(Shorthand.PrettyDistributionRow(row));
            }
        }

        public void SaveCurrentRow()
        {
            if (RowSelected)
            {
                SelectedRow.Start = int.Parse(TextBoxRowStart.Text);
                SelectedRow.End = int.Parse(TextBoxRowEnd.Text);
                if (!CheckBoxUseReference.Checked)
                {
                    SelectedRow.Value = TextBoxRowValue.Text;
                    SelectedRow.Reference = null;
                }
                else
                {
                    SelectedRow.Value = SelectedRow.Reference != null ? null : "Empty";
                }
            }
        }

        private void ListRows_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SaveCurrentRow();
            if (RowSelected)
            {
                LoadRow(SelectedRow);
            }
        }
    }
}