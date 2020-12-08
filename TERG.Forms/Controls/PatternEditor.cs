using System;
using System.Linq;
using System.Windows.Forms;
using TERG.Core;
using TERG.Core.Interfaces;
using TERG.Core.Models;

namespace TERG.Forms.Controls
{
    public partial class PatternEditor : UserControl
    {
        public event EventHandler<Pattern> PatternSaved;

        public event EventHandler<Pattern> PatternDeleted;

        private Pattern CurrentPattern;

        public PatternEditor()
        {
            CurrentPattern = null;
            InitializeComponent();
            ComboReferenceType.DataSource = ReferenceFactory.typeMap.Keys.ToArray();
            ResetFields();
        }

        internal bool LoadPattern(Pattern pattern)
        {
            CurrentPattern = pattern;
            RefreshPattern();
            return true;
        }

        internal void RefreshPattern()
        {
            ResetFields();
            TextBoxID.Text = CurrentPattern.ID.ToString();
            TextBoxName.Text = CurrentPattern.Name;
            TextBoxName.Enabled = true;
            ComboReferenceType.Enabled = true;
            ButtonNewReference.Enabled = true;
            ButtonReferenceUp.Enabled = true;
            ButtonReferenceDown.Enabled = true;
            ListReferences.Items.AddRange(CurrentPattern.References.ToArray());
        }

        internal void ResetFields()
        {
            TextBoxID.Text = "";
            TextBoxName.Text = "";
            TextBoxName.Enabled = false;
            ComboReferenceType.Enabled = false;
            ButtonNewReference.Enabled = false;
            ButtonReferenceUp.Enabled = false;
            ButtonReferenceDown.Enabled = false;
            ListReferences.Items.Clear();
        }

        private void ButtonEditHeader_Click(object sender, EventArgs e)
        {
            BaseEditorResult result = BaseEditor.Show(CurrentPattern.Name, CurrentPattern.Header);
            CurrentPattern.Header = result.OK ? result.Text : CurrentPattern.Header;
            PatternSaved(this, CurrentPattern);
        }

        private void ButtonEditBody_Click(object sender, EventArgs e)
        {
            BaseEditorResult result = BaseEditor.Show(CurrentPattern.Name, CurrentPattern.Body);
            CurrentPattern.Body = result.OK ? result.Text : CurrentPattern.Body;
            PatternSaved(this, CurrentPattern);
        }

        private void ButtonEditFooter_Click(object sender, EventArgs e)
        {
            BaseEditorResult result = BaseEditor.Show(CurrentPattern.Name, CurrentPattern.Footer);
            CurrentPattern.Footer = result.OK ? result.Text : CurrentPattern.Footer;
            PatternSaved(this, CurrentPattern);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            CurrentPattern.Name = TextBoxName.Text.Trim();
            PatternSaved(this, CurrentPattern);
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshPattern();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            PatternDeleted(this, CurrentPattern);
            ResetFields();
        }

        private void ButtonReferenceUp_Click(object sender, EventArgs e)
        {
            int index = ListReferences.SelectedIndex;

            if (index > 0)
            {
                IReference temp = CurrentPattern.References[index];
                CurrentPattern.References[index] = CurrentPattern.References[index - 1];
                CurrentPattern.References[index - 1] = temp;
                RefreshPattern();
                PatternSaved(this, CurrentPattern);
            }
        }

        private void ButtonReferenceDown_Click(object sender, EventArgs e)
        {
            int index = ListReferences.SelectedIndex;

            if (index < ListReferences.Items.Count - 1 && index >= 0)
            {
                IReference temp = CurrentPattern.References[index];
                CurrentPattern.References[index] = CurrentPattern.References[index + 1];
                CurrentPattern.References[index + 1] = temp;
                RefreshPattern();
                PatternSaved(this, CurrentPattern);
            }
        }

        private void ButtonNewReference_Click(object sender, EventArgs e)
        {
            try
            {
                IReference newReference = ReferenceFactory.Create(ComboReferenceType.Text);
                newReference = EditorBox.ShowEditor($"New Reference @{CurrentPattern.References.Count} in {CurrentPattern}", newReference);
                CurrentPattern.References.Add(newReference);
                RefreshPattern();
                PatternSaved(this, CurrentPattern);
            }
            catch { }
        }
    }
}