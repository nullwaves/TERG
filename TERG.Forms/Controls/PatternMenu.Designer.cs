namespace TERG.Forms.Controls
{
    partial class PatternMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupPatternMenu = new System.Windows.Forms.GroupBox();
            this.SplitPatternMenu = new System.Windows.Forms.SplitContainer();
            this.ListPatterns = new System.Windows.Forms.ListBox();
            this.GroupPatternMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPatternMenu)).BeginInit();
            this.SplitPatternMenu.Panel1.SuspendLayout();
            this.SplitPatternMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupPatternMenu
            // 
            this.GroupPatternMenu.AutoSize = true;
            this.GroupPatternMenu.Controls.Add(this.SplitPatternMenu);
            this.GroupPatternMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPatternMenu.Location = new System.Drawing.Point(0, 0);
            this.GroupPatternMenu.Name = "GroupPatternMenu";
            this.GroupPatternMenu.Size = new System.Drawing.Size(498, 402);
            this.GroupPatternMenu.TabIndex = 1;
            this.GroupPatternMenu.TabStop = false;
            this.GroupPatternMenu.Text = "Patterns";
            // 
            // SplitPatternMenu
            // 
            this.SplitPatternMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitPatternMenu.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitPatternMenu.Location = new System.Drawing.Point(3, 16);
            this.SplitPatternMenu.Name = "SplitPatternMenu";
            // 
            // SplitPatternMenu.Panel1
            // 
            this.SplitPatternMenu.Panel1.Controls.Add(this.ListPatterns);
            this.SplitPatternMenu.Panel1MinSize = 150;
            this.SplitPatternMenu.Size = new System.Drawing.Size(492, 383);
            this.SplitPatternMenu.SplitterDistance = 150;
            this.SplitPatternMenu.TabIndex = 0;
            // 
            // ListPatterns
            // 
            this.ListPatterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPatterns.Location = new System.Drawing.Point(0, 0);
            this.ListPatterns.Name = "ListPatterns";
            this.ListPatterns.Size = new System.Drawing.Size(150, 383);
            this.ListPatterns.TabIndex = 0;
            this.ListPatterns.SelectedIndexChanged += new System.EventHandler(this.ListPatterns_SelectedIndexChanged);
            // 
            // PatternMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupPatternMenu);
            this.Name = "PatternMenu";
            this.Size = new System.Drawing.Size(498, 402);
            this.GroupPatternMenu.ResumeLayout(false);
            this.SplitPatternMenu.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitPatternMenu)).EndInit();
            this.SplitPatternMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupPatternMenu;
        private System.Windows.Forms.SplitContainer SplitPatternMenu;
        private System.Windows.Forms.ListBox ListPatterns;
    }
}
