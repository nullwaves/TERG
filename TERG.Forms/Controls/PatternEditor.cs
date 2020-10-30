using System.Windows.Forms;
using TERG.Core.Models;

namespace TERG.Forms.Controls
{
    public partial class PatternEditor : UserControl
    {
        private Pattern CurrentPattern;

        public PatternEditor()
        {
            CurrentPattern = null;
            InitializeComponent();
        }

        internal bool LoadPattern(Pattern pattern)
        {
            CurrentPattern = pattern;
            RefreshPattern();
            return true;
        }

        internal void RefreshPattern()
        {
            TextBoxID.Text = CurrentPattern.ID.ToString();
            TextBoxName.Text = CurrentPattern.Name;
        }

        private void ButtonEditHeader_Click(object sender, System.EventArgs e)
        {
            BaseEditorResult result = BaseEditor.Show(CurrentPattern.Name, CurrentPattern.Header);
            CurrentPattern.Header = result.OK ? result.Text : CurrentPattern.Header;
        }

        private void ButtonEditBody_Click(object sender, System.EventArgs e)
        {
            BaseEditorResult result = BaseEditor.Show(CurrentPattern.Name, CurrentPattern.Body);
            CurrentPattern.Body = result.OK ? result.Text : CurrentPattern.Body;
        }

        private void ButtonEditFooter_Click(object sender, System.EventArgs e)
        {
            BaseEditorResult result = BaseEditor.Show(CurrentPattern.Name, CurrentPattern.Footer);
            CurrentPattern.Footer = result.OK ? result.Text : CurrentPattern.Footer;
        }
    }
}