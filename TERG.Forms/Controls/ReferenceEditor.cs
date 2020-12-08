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

        private IReference CurrentReference;
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
            CurrentReference = reference;
            CurrentEditor = (IReferenceTypeEditor)Activator.CreateInstance(TypeMap[CurrentReference.Type]);
            CurrentEditor.LoadReference(CurrentReference);
            return true;
        }
    }
}