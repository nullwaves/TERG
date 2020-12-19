using System;
using System.Windows.Forms;
using TERG.Core.Interfaces;
using TERG.Forms.Controls.ReferenceEditors;

namespace TERG.Forms
{
    public partial class EditorBox : Form
    {
        public EditorBox()
        {
            InitializeComponent();
        }

        public static IReference ShowEditor(string title, IReference reference)
        {
            using (EditorBox editor = new EditorBox() { Text = title })
            {
                ReferenceEditor referenceEditor = new ReferenceEditor()
                {
                    Dock = DockStyle.Fill
                };
                referenceEditor.ReferenceSaved += new EventHandler(editor.EditorBox_ReferenceSaved);
                editor.Controls.Add(referenceEditor);
                referenceEditor.LoadReference(reference);
                DialogResult result = editor.ShowDialog();
                return result == DialogResult.OK ? referenceEditor.GetReference() : reference;
            }
        }

        private void EditorBox_ReferenceSaved(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
