using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TERG.Core.Interfaces;

namespace TERG.Forms.Controls.ReferenceEditors
{
    public partial class ReferenceEditor : UserControl
    {
        public static readonly Dictionary<string, Type> TypeMap = new Dictionary<string, Type>()
        {
            {"POOL", typeof(POOLEditor)},
            //{"PATT", typeof(PatternReference)},
            //{"IPAT", typeof(IteratedPatternReference)},
            //{"RPAT", typeof(RandomPatternReference)},
            //{"RINT", typeof(RandomIntegerReference)},
            {"DTBL", typeof(DTBLEditor)}
        };

        public event EventHandler ReferenceSaved;

        private IReferenceTypeEditor CurrentEditor;

        public ReferenceEditor()
        {
            InitializeComponent();
        }

        public bool LoadReference(IReference reference)
        {
            if(reference == null)
            {
                return false;
            }
            CurrentEditor = (IReferenceTypeEditor)Activator.CreateInstance(TypeMap[reference.Type]);
            CurrentEditor.LoadReference(reference);
            return true;
        }

        public IReference GetReference() => CurrentEditor.GetReference();

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            ReferenceSaved(sender, e);
        }
    }
}