using TERG.Core.Interfaces;

namespace TERG.Forms.Controls.ReferenceEditors
{
    internal interface IReferenceTypeEditor
    {
        IReference GetReference();

        bool LoadReference(IReference reference);
    }
}