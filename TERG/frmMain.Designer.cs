using System;

namespace TERG
{
    partial class frmMain
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
            this.listPools = new System.Windows.Forms.ListBox();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboPoolParent = new System.Windows.Forms.ComboBox();
            this.textPoolName = new System.Windows.Forms.TextBox();
            this.textBoxPoolEditor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnRefreshPool = new System.Windows.Forms.Button();
            this.btnSavePool = new System.Windows.Forms.Button();
            this.tabPatternEditor = new System.Windows.Forms.TabPage();
            this.comboAddReferenceType = new System.Windows.Forms.ComboBox();
            this.listPatternReferences = new System.Windows.Forms.ListBox();
            this.btnAddReference = new System.Windows.Forms.Button();
            this.btnOpenTemplateEditor = new System.Windows.Forms.Button();
            this.listPatterns = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textPatternName = new System.Windows.Forms.TextBox();
            this.btnDeletePattern = new System.Windows.Forms.Button();
            this.btnDeletePool = new System.Windows.Forms.Button();
            this.changeDatabaseLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabEventLog.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabControlEditors.SuspendLayout();
            this.tabPoolEditor.SuspendLayout();
            this.tabPatternEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPools
            // 
            this.listPools.FormattingEnabled = true;
            this.listPools.Location = new System.Drawing.Point(0, 0);
            this.listPools.Name = "listPools";
            this.listPools.ScrollAlwaysVisible = true;
            this.listPools.Size = new System.Drawing.Size(173, 277);
            this.listPools.TabIndex = 0;
            this.listPools.SelectedIndexChanged += new System.EventHandler(this.listPools_SelectedIndexChanged);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDatabase});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 481);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(565, 22);
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
            // comboPoolParent
            // 
            this.comboPoolParent.FormattingEnabled = true;
            this.comboPoolParent.Location = new System.Drawing.Point(360, 75);
            this.comboPoolParent.Name = "comboPoolParent";
            this.comboPoolParent.Size = new System.Drawing.Size(172, 21);
            this.comboPoolParent.TabIndex = 5;
            this.comboPoolParent.SelectedIndexChanged += new System.EventHandler(this.comboPoolParent_SelectedIndexChanged);
            // 
            // textPoolName
            // 
            this.textPoolName.Location = new System.Drawing.Point(360, 35);
            this.textPoolName.Name = "textPoolName";
            this.textPoolName.Size = new System.Drawing.Size(172, 20);
            this.textPoolName.TabIndex = 2;
            this.textPoolName.TextChanged += new System.EventHandler(this.textPoolName_TextChanged);
            // 
            // textBoxPoolEditor
            // 
            this.textBoxPoolEditor.Location = new System.Drawing.Point(179, 28);
            this.textBoxPoolEditor.Multiline = true;
            this.textBoxPoolEditor.Name = "textBoxPoolEditor";
            this.textBoxPoolEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPoolEditor.Size = new System.Drawing.Size(172, 242);
            this.textBoxPoolEditor.TabIndex = 2;
            this.textBoxPoolEditor.TextChanged += new System.EventHandler(this.textBoxPoolEditor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parent Pool:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Items";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databseToolStripMenuItem,
            this.runToolStripMenuItem,
            this.tERGToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
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
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
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
            this.addNewPoolToolStripMenuItem.Click += new System.EventHandler(this.addNewPoolToolStripMenuItem_Click);
            // 
            // addNewPatternToolStripMenuItem
            // 
            this.addNewPatternToolStripMenuItem.Name = "addNewPatternToolStripMenuItem";
            this.addNewPatternToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.addNewPatternToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.addNewPatternToolStripMenuItem.Text = "Add New Pattern";
            this.addNewPatternToolStripMenuItem.Click += new System.EventHandler(this.addNewPatternToolStripMenuItem_Click);
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
            this.patternRunToolStripMenuItem.Click += new System.EventHandler(this.patternRunToolStripMenuItem_Click);
            // 
            // tERGToolStripMenuItem
            // 
            this.tERGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.tERGToolStripMenuItem.Name = "tERGToolStripMenuItem";
            this.tERGToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.tERGToolStripMenuItem.Text = "TERG";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabEventLog
            // 
            this.tabEventLog.Controls.Add(this.txtEventLog);
            this.tabEventLog.Location = new System.Drawing.Point(4, 22);
            this.tabEventLog.Name = "tabEventLog";
            this.tabEventLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabEventLog.Size = new System.Drawing.Size(538, 116);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 336);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(546, 142);
            this.tabControl1.TabIndex = 6;
            // 
            // tabControlEditors
            // 
            this.tabControlEditors.Controls.Add(this.tabPoolEditor);
            this.tabControlEditors.Controls.Add(this.tabPatternEditor);
            this.tabControlEditors.Location = new System.Drawing.Point(12, 27);
            this.tabControlEditors.Name = "tabControlEditors";
            this.tabControlEditors.SelectedIndex = 0;
            this.tabControlEditors.Size = new System.Drawing.Size(546, 302);
            this.tabControlEditors.TabIndex = 7;
            // 
            // tabPoolEditor
            // 
            this.tabPoolEditor.BackColor = System.Drawing.SystemColors.Control;
            this.tabPoolEditor.Controls.Add(this.btnDeletePool);
            this.tabPoolEditor.Controls.Add(this.comboPoolParent);
            this.tabPoolEditor.Controls.Add(this.listPools);
            this.tabPoolEditor.Controls.Add(this.btnRefreshPool);
            this.tabPoolEditor.Controls.Add(this.label1);
            this.tabPoolEditor.Controls.Add(this.btnSavePool);
            this.tabPoolEditor.Controls.Add(this.label2);
            this.tabPoolEditor.Controls.Add(this.textPoolName);
            this.tabPoolEditor.Controls.Add(this.label3);
            this.tabPoolEditor.Controls.Add(this.textBoxPoolEditor);
            this.tabPoolEditor.Location = new System.Drawing.Point(4, 22);
            this.tabPoolEditor.Name = "tabPoolEditor";
            this.tabPoolEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoolEditor.Size = new System.Drawing.Size(538, 276);
            this.tabPoolEditor.TabIndex = 0;
            this.tabPoolEditor.Text = "Pools";
            // 
            // btnRefreshPool
            // 
            this.btnRefreshPool.Image = global::TERG.Properties.Resources.action_refresh;
            this.btnRefreshPool.Location = new System.Drawing.Point(463, 6);
            this.btnRefreshPool.Name = "btnRefreshPool";
            this.btnRefreshPool.Size = new System.Drawing.Size(29, 23);
            this.btnRefreshPool.TabIndex = 4;
            this.btnRefreshPool.UseVisualStyleBackColor = true;
            this.btnRefreshPool.Click += new System.EventHandler(this.btnRefreshPool_Click);
            // 
            // btnSavePool
            // 
            this.btnSavePool.Image = global::TERG.Properties.Resources.action_save;
            this.btnSavePool.Location = new System.Drawing.Point(498, 6);
            this.btnSavePool.Name = "btnSavePool";
            this.btnSavePool.Size = new System.Drawing.Size(29, 23);
            this.btnSavePool.TabIndex = 3;
            this.btnSavePool.UseVisualStyleBackColor = true;
            this.btnSavePool.Click += new System.EventHandler(this.btnSavePool_Click);
            // 
            // tabPatternEditor
            // 
            this.tabPatternEditor.BackColor = System.Drawing.SystemColors.Control;
            this.tabPatternEditor.Controls.Add(this.btnDeletePattern);
            this.tabPatternEditor.Controls.Add(this.comboAddReferenceType);
            this.tabPatternEditor.Controls.Add(this.listPatternReferences);
            this.tabPatternEditor.Controls.Add(this.btnAddReference);
            this.tabPatternEditor.Controls.Add(this.btnOpenTemplateEditor);
            this.tabPatternEditor.Controls.Add(this.listPatterns);
            this.tabPatternEditor.Controls.Add(this.label6);
            this.tabPatternEditor.Controls.Add(this.label5);
            this.tabPatternEditor.Controls.Add(this.textPatternName);
            this.tabPatternEditor.Location = new System.Drawing.Point(4, 22);
            this.tabPatternEditor.Name = "tabPatternEditor";
            this.tabPatternEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatternEditor.Size = new System.Drawing.Size(538, 276);
            this.tabPatternEditor.TabIndex = 1;
            this.tabPatternEditor.Text = "Patterns";
            // 
            // comboAddReferenceType
            // 
            this.comboAddReferenceType.FormattingEnabled = true;
            this.comboAddReferenceType.Location = new System.Drawing.Point(406, 94);
            this.comboAddReferenceType.Name = "comboAddReferenceType";
            this.comboAddReferenceType.Size = new System.Drawing.Size(121, 21);
            this.comboAddReferenceType.TabIndex = 10;
            // 
            // listPatternReferences
            // 
            this.listPatternReferences.FormattingEnabled = true;
            this.listPatternReferences.Location = new System.Drawing.Point(175, 28);
            this.listPatternReferences.Name = "listPatternReferences";
            this.listPatternReferences.ScrollAlwaysVisible = true;
            this.listPatternReferences.Size = new System.Drawing.Size(172, 238);
            this.listPatternReferences.TabIndex = 9;
            // 
            // btnAddReference
            // 
            this.btnAddReference.Location = new System.Drawing.Point(357, 91);
            this.btnAddReference.Name = "btnAddReference";
            this.btnAddReference.Size = new System.Drawing.Size(43, 24);
            this.btnAddReference.TabIndex = 8;
            this.btnAddReference.Text = "+ Ref";
            this.btnAddReference.UseVisualStyleBackColor = true;
            this.btnAddReference.Click += new System.EventHandler(this.btnAddReference_Click);
            // 
            // btnOpenTemplateEditor
            // 
            this.btnOpenTemplateEditor.Location = new System.Drawing.Point(357, 64);
            this.btnOpenTemplateEditor.Name = "btnOpenTemplateEditor";
            this.btnOpenTemplateEditor.Size = new System.Drawing.Size(171, 24);
            this.btnOpenTemplateEditor.TabIndex = 8;
            this.btnOpenTemplateEditor.Text = "Edit Base Template";
            this.btnOpenTemplateEditor.UseVisualStyleBackColor = true;
            this.btnOpenTemplateEditor.Click += new System.EventHandler(this.btnOpenTemplateEditor_Click);
            // 
            // listPatterns
            // 
            this.listPatterns.FormattingEnabled = true;
            this.listPatterns.Location = new System.Drawing.Point(-4, 0);
            this.listPatterns.Name = "listPatterns";
            this.listPatterns.ScrollAlwaysVisible = true;
            this.listPatterns.Size = new System.Drawing.Size(173, 277);
            this.listPatterns.TabIndex = 3;
            this.listPatterns.SelectedIndexChanged += new System.EventHandler(this.listPatterns_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "References";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name:";
            // 
            // textPatternName
            // 
            this.textPatternName.Location = new System.Drawing.Point(356, 35);
            this.textPatternName.Name = "textPatternName";
            this.textPatternName.Size = new System.Drawing.Size(172, 20);
            this.textPatternName.TabIndex = 6;
            // 
            // btnDeletePattern
            // 
            this.btnDeletePattern.Location = new System.Drawing.Point(406, 243);
            this.btnDeletePattern.Name = "btnDeletePattern";
            this.btnDeletePattern.Size = new System.Drawing.Size(121, 23);
            this.btnDeletePattern.TabIndex = 11;
            this.btnDeletePattern.Text = "Delete Pattern";
            this.btnDeletePattern.UseVisualStyleBackColor = true;
            this.btnDeletePattern.Click += new System.EventHandler(this.btnDeletePattern_Click);
            // 
            // btnDeletePool
            // 
            this.btnDeletePool.Location = new System.Drawing.Point(411, 247);
            this.btnDeletePool.Name = "btnDeletePool";
            this.btnDeletePool.Size = new System.Drawing.Size(121, 23);
            this.btnDeletePool.TabIndex = 12;
            this.btnDeletePool.Text = "Delete Pool";
            this.btnDeletePool.UseVisualStyleBackColor = true;
            this.btnDeletePool.Click += new System.EventHandler(this.btnDeletePool_Click);
            // 
            // changeDatabaseLocationToolStripMenuItem
            // 
            this.changeDatabaseLocationToolStripMenuItem.Name = "changeDatabaseLocationToolStripMenuItem";
            this.changeDatabaseLocationToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.changeDatabaseLocationToolStripMenuItem.Text = "File Location";
            this.changeDatabaseLocationToolStripMenuItem.Click += new System.EventHandler(this.changeDatabaseLocationToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 503);
            this.Controls.Add(this.tabControlEditors);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "The Encyclopedia of Random Generation";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabEventLog.ResumeLayout(false);
            this.tabEventLog.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabControlEditors.ResumeLayout(false);
            this.tabPoolEditor.ResumeLayout(false);
            this.tabPoolEditor.PerformLayout();
            this.tabPatternEditor.ResumeLayout(false);
            this.tabPatternEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPools;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusDatabase;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tERGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewPoolToolStripMenuItem;
        private System.Windows.Forms.Button btnSavePool;
        private System.Windows.Forms.TextBox textBoxPoolEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefreshPool;
        private System.Windows.Forms.TabPage tabEventLog;
        private System.Windows.Forms.TextBox txtEventLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textPoolName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboPoolParent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControlEditors;
        private System.Windows.Forms.TabPage tabPoolEditor;
        private System.Windows.Forms.TabPage tabPatternEditor;
        private System.Windows.Forms.Button btnOpenTemplateEditor;
        private System.Windows.Forms.ListBox listPatterns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPatternName;
        private System.Windows.Forms.ListBox listPatternReferences;
        private System.Windows.Forms.ToolStripMenuItem addNewPatternToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboAddReferenceType;
        private System.Windows.Forms.Button btnAddReference;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patternRunToolStripMenuItem;
        private System.Windows.Forms.Button btnDeletePool;
        private System.Windows.Forms.Button btnDeletePattern;
        private System.Windows.Forms.ToolStripMenuItem changeDatabaseLocationToolStripMenuItem;
    }
}

