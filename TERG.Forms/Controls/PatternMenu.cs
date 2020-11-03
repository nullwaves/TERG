using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TERG.Core;
using TERG.Core.Models;

namespace TERG.Forms.Controls
{
    public partial class PatternMenu : UserControl
    {
        private readonly Engine Engine;
        private readonly PatternEditor _editor;

        private IEnumerable<Pattern> Patterns => Engine.GetPatterns();
        private Pattern SelectedPattern => ListPatterns.SelectedItem != null ? (Pattern)ListPatterns.SelectedItem : null;

        public Pattern Selected => SelectedPattern;

        private PatternMenu()
        {
        }

        public PatternMenu(Engine engine)
        {
            Engine = engine;

            InitializeComponent();

            RefreshPatternList();

            _editor = new PatternEditor()
            {
                Dock = DockStyle.Fill
            };
            _editor.PatternSaved += new EventHandler<Pattern>(PatternMenu_PatternSaved);
            _editor.PatternDeleted += new EventHandler<Pattern>(PatternMenu_PatternDeleted);
            SplitPatternMenu.Panel2.Controls.Add(_editor);
        }

        private void PatternMenu_PatternDeleted(object sender, Pattern p)
        {
            if (Engine.RemovePattern(p.ID))
            {
                RefreshPatternList();
            }
        }

        private void PatternMenu_PatternSaved(object sender, Pattern p)
        {
            if (Engine.UpdatePattern(p))
            {
                RefreshPatternList();
            }
        }

        public void RefreshPatternList()
        {
            int oldId = SelectedPattern != null ? SelectedPattern.ID : -1;
            ListPatterns.Items.Clear();
            ListPatterns.Items.AddRange(Patterns.ToArray());
            ListPatterns.SelectedIndex = oldId != -1 ? ListPatterns.Items.IndexOf(Engine.GetPatternByID(oldId)) : -1;
        }

        private void ListPatterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListPatterns.SelectedIndex >= 0)
            {
                _editor.LoadPattern(SelectedPattern);
            }
        }
    }
}