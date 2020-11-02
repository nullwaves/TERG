using System;

namespace TERG.Forms
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDatabaseLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPatternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patternRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tERGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabEventLog = new System.Windows.Forms.TabPage();
            this.txtEventLog = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControlEditors = new System.Windows.Forms.TabControl();
            this.tabPoolEditor = new System.Windows.Forms.TabPage();
            this.tabPatternEditor = new System.Windows.Forms.TabPage();
            this.tabExport = new System.Windows.Forms.TabPage();
            this.btnExportOut = new System.Windows.Forms.Button();
            this.checkExportSeperators = new System.Windows.Forms.CheckBox();
            this.textExport = new System.Windows.Forms.TextBox();
            this.btnRunExport = new System.Windows.Forms.Button();
            this.textExportIterations = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboExportPattern = new System.Windows.Forms.ComboBox();
            this.mainStatusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabEventLog.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabControlEditors.SuspendLayout();
            this.tabExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDatabase});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 566);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(760, 22);
            this.mainStatusStrip.SizingGrip = false;
            this.mainStatusStrip.TabIndex = 2;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // statusDatabase
            // 
            this.statusDatabase.Name = "statusDatabase";
            this.statusDatabase.Size = new System.Drawing.Size(119, 17);
            this.statusDatabase.Text = "7/23/2017 5:26:22 PM";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databseToolStripMenuItem,
            this.runToolStripMenuItem,
            this.tERGToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databseToolStripMenuItem
            // 
            this.databseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.changeDatabaseLocationToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewPoolToolStripMenuItem,
            this.addNewPatternToolStripMenuItem});
            this.databseToolStripMenuItem.Name = "databseToolStripMenuItem";
            this.databseToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.databseToolStripMenuItem.Text = "Databse";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // changeDatabaseLocationToolStripMenuItem
            // 
            this.changeDatabaseLocationToolStripMenuItem.Name = "changeDatabaseLocationToolStripMenuItem";
            this.changeDatabaseLocationToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.changeDatabaseLocationToolStripMenuItem.Text = "Change Database";
            this.changeDatabaseLocationToolStripMenuItem.Click += new System.EventHandler(this.ChangeDatabaseLocationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // addNewPoolToolStripMenuItem
            // 
            this.addNewPoolToolStripMenuItem.Name = "addNewPoolToolStripMenuItem";
            this.addNewPoolToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewPoolToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addNewPoolToolStripMenuItem.Text = "Add New Pool";
            this.addNewPoolToolStripMenuItem.Click += new System.EventHandler(this.AddNewPoolToolStripMenuItem_Click);
            // 
            // addNewPatternToolStripMenuItem
            // 
            this.addNewPatternToolStripMenuItem.Name = "addNewPatternToolStripMenuItem";
            this.addNewPatternToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.addNewPatternToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addNewPatternToolStripMenuItem.Text = "Add New Pattern";
            this.addNewPatternToolStripMenuItem.Click += new System.EventHandler(this.AddNewPatternToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patternRunToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // patternRunToolStripMenuItem
            // 
            this.patternRunToolStripMenuItem.Name = "patternRunToolStripMenuItem";
            this.patternRunToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.patternRunToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.patternRunToolStripMenuItem.Text = "Pattern";
            this.patternRunToolStripMenuItem.Click += new System.EventHandler(this.PatternRunToolStripMenuItem_Click);
            // 
            // tERGToolStripMenuItem
            // 
            this.tERGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.tERGToolStripMenuItem.Name = "tERGToolStripMenuItem";
            this.tERGToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.tERGToolStripMenuItem.Text = "TERG";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // tabEventLog
            // 
            this.tabEventLog.Controls.Add(this.txtEventLog);
            this.tabEventLog.Location = new System.Drawing.Point(4, 22);
            this.tabEventLog.Name = "tabEventLog";
            this.tabEventLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabEventLog.Size = new System.Drawing.Size(752, 116);
            this.tabEventLog.TabIndex = 1;
            this.tabEventLog.Text = "Event Log";
            this.tabEventLog.UseVisualStyleBackColor = true;
            // 
            // txtEventLog
            // 
            this.txtEventLog.Location = new System.Drawing.Point(0, 0);
            this.txtEventLog.Multiline = true;
            this.txtEventLog.Name = "txtEventLog";
            this.txtEventLog.ReadOnly = true;
            this.txtEventLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEventLog.Size = new System.Drawing.Size(538, 113);
            this.txtEventLog.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEventLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 424);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 142);
            this.tabControl1.TabIndex = 6;
            // 
            // tabControlEditors
            // 
            this.tabControlEditors.Controls.Add(this.tabPoolEditor);
            this.tabControlEditors.Controls.Add(this.tabPatternEditor);
            this.tabControlEditors.Controls.Add(this.tabExport);
            this.tabControlEditors.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlEditors.Location = new System.Drawing.Point(0, 24);
            this.tabControlEditors.Name = "tabControlEditors";
            this.tabControlEditors.SelectedIndex = 0;
            this.tabControlEditors.Size = new System.Drawing.Size(760, 394);
            this.tabControlEditors.TabIndex = 7;
            // 
            // tabPoolEditor
            // 
            this.tabPoolEditor.BackColor = System.Drawing.SystemColors.Control;
            this.tabPoolEditor.Location = new System.Drawing.Point(4, 22);
            this.tabPoolEditor.Name = "tabPoolEditor";
            this.tabPoolEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoolEditor.Size = new System.Drawing.Size(752, 368);
            this.tabPoolEditor.TabIndex = 0;
            this.tabPoolEditor.Text = "Pools";
            // 
            // tabPatternEditor
            // 
            this.tabPatternEditor.BackColor = System.Drawing.SystemColors.Control;
            this.tabPatternEditor.Location = new System.Drawing.Point(4, 22);
            this.tabPatternEditor.Name = "tabPatternEditor";
            this.tabPatternEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatternEditor.Size = new System.Drawing.Size(752, 368);
            this.tabPatternEditor.TabIndex = 1;
            this.tabPatternEditor.Text = "Patterns";
            // 
            // tabExport
            // 
            this.tabExport.BackColor = System.Drawing.SystemColors.Control;
            this.tabExport.Controls.Add(this.btnExportOut);
            this.tabExport.Controls.Add(this.checkExportSeperators);
            this.tabExport.Controls.Add(this.textExport);
            this.tabExport.Controls.Add(this.btnRunExport);
            this.tabExport.Controls.Add(this.textExportIterations);
            this.tabExport.Controls.Add(this.label7);
            this.tabExport.Controls.Add(this.label4);
            this.tabExport.Controls.Add(this.comboExportPattern);
            this.tabExport.Location = new System.Drawing.Point(4, 22);
            this.tabExport.Name = "tabExport";
            this.tabExport.Size = new System.Drawing.Size(752, 368);
            this.tabExport.TabIndex = 2;
            this.tabExport.Text = "Export";
            // 
            // btnExportOut
            // 
            this.btnExportOut.Location = new System.Drawing.Point(474, 3);
            this.btnExportOut.Name = "btnExportOut";
            this.btnExportOut.Size = new System.Drawing.Size(61, 23);
            this.btnExportOut.TabIndex = 7;
            this.btnExportOut.Text = "To File...";
            this.btnExportOut.UseVisualStyleBackColor = true;
            this.btnExportOut.Click += new System.EventHandler(this.BtnExportOut_Click);
            // 
            // checkExportSeperators
            // 
            this.checkExportSeperators.AutoSize = true;
            this.checkExportSeperators.Location = new System.Drawing.Point(326, 6);
            this.checkExportSeperators.Name = "checkExportSeperators";
            this.checkExportSeperators.Size = new System.Drawing.Size(77, 17);
            this.checkExportSeperators.TabIndex = 6;
            this.checkExportSeperators.Text = "Seperators";
            this.checkExportSeperators.UseVisualStyleBackColor = true;
            // 
            // textExport
            // 
            this.textExport.Location = new System.Drawing.Point(3, 30);
            this.textExport.Multiline = true;
            this.textExport.Name = "textExport";
            this.textExport.ReadOnly = true;
            this.textExport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textExport.Size = new System.Drawing.Size(532, 243);
            this.textExport.TabIndex = 5;
            // 
            // btnRunExport
            // 
            this.btnRunExport.Location = new System.Drawing.Point(409, 3);
            this.btnRunExport.Name = "btnRunExport";
            this.btnRunExport.Size = new System.Drawing.Size(61, 23);
            this.btnRunExport.TabIndex = 4;
            this.btnRunExport.Text = "Run";
            this.btnRunExport.UseVisualStyleBackColor = true;
            this.btnRunExport.Click += new System.EventHandler(this.BtnRunExport_Click);
            // 
            // textExportIterations
            // 
            this.textExportIterations.Location = new System.Drawing.Point(264, 4);
            this.textExportIterations.Name = "textExportIterations";
            this.textExportIterations.Size = new System.Drawing.Size(56, 20);
            this.textExportIterations.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Iterations:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Pattern:";
            // 
            // comboExportPattern
            // 
            this.comboExportPattern.FormattingEnabled = true;
            this.comboExportPattern.Location = new System.Drawing.Point(53, 3);
            this.comboExportPattern.Name = "comboExportPattern";
            this.comboExportPattern.Size = new System.Drawing.Size(146, 21);
            this.comboExportPattern.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(760, 588);
            this.Controls.Add(this.tabControlEditors);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "The Encyclopedia of Random Generation";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabEventLog.ResumeLayout(false);
            this.tabEventLog.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabControlEditors.ResumeLayout(false);
            this.tabExport.ResumeLayout(false);
            this.tabExport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusDatabase;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tERGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewPoolToolStripMenuItem;
        private System.Windows.Forms.TabPage tabEventLog;
        private System.Windows.Forms.TextBox txtEventLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabControl tabControlEditors;
        private System.Windows.Forms.TabPage tabPoolEditor;
        private System.Windows.Forms.TabPage tabPatternEditor;
        private System.Windows.Forms.ToolStripMenuItem addNewPatternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patternRunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeDatabaseLocationToolStripMenuItem;
        private System.Windows.Forms.TabPage tabExport;
        private System.Windows.Forms.TextBox textExport;
        private System.Windows.Forms.Button btnRunExport;
        private System.Windows.Forms.TextBox textExportIterations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboExportPattern;
        private System.Windows.Forms.CheckBox checkExportSeperators;
        private System.Windows.Forms.Button btnExportOut;
    }
}

