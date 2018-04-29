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
            this.groupPoolBrowser = new System.Windows.Forms.GroupBox();
            this.comboPoolParent = new System.Windows.Forms.ComboBox();
            this.btnRefreshPool = new System.Windows.Forms.Button();
            this.btnSavePool = new System.Windows.Forms.Button();
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
            this.tERGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabEventLog = new System.Windows.Forms.TabPage();
            this.txtEventLog = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainStatusStrip.SuspendLayout();
            this.groupPoolBrowser.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabEventLog.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPools
            // 
            this.listPools.FormattingEnabled = true;
            this.listPools.Location = new System.Drawing.Point(6, 19);
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
            this.mainStatusStrip.Size = new System.Drawing.Size(666, 22);
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
            // groupPoolBrowser
            // 
            this.groupPoolBrowser.Controls.Add(this.comboPoolParent);
            this.groupPoolBrowser.Controls.Add(this.btnRefreshPool);
            this.groupPoolBrowser.Controls.Add(this.btnSavePool);
            this.groupPoolBrowser.Controls.Add(this.textPoolName);
            this.groupPoolBrowser.Controls.Add(this.textBoxPoolEditor);
            this.groupPoolBrowser.Controls.Add(this.label3);
            this.groupPoolBrowser.Controls.Add(this.label2);
            this.groupPoolBrowser.Controls.Add(this.label1);
            this.groupPoolBrowser.Controls.Add(this.listPools);
            this.groupPoolBrowser.Location = new System.Drawing.Point(0, 27);
            this.groupPoolBrowser.Name = "groupPoolBrowser";
            this.groupPoolBrowser.Size = new System.Drawing.Size(546, 303);
            this.groupPoolBrowser.TabIndex = 4;
            this.groupPoolBrowser.TabStop = false;
            this.groupPoolBrowser.Text = "Pool Browser";
            // 
            // comboPoolParent
            // 
            this.comboPoolParent.FormattingEnabled = true;
            this.comboPoolParent.Location = new System.Drawing.Point(366, 86);
            this.comboPoolParent.Name = "comboPoolParent";
            this.comboPoolParent.Size = new System.Drawing.Size(172, 21);
            this.comboPoolParent.TabIndex = 5;
            this.comboPoolParent.SelectedIndexChanged += new System.EventHandler(this.comboPoolParent_SelectedIndexChanged);
            // 
            // btnRefreshPool
            // 
            this.btnRefreshPool.Image = global::TERG.Properties.Resources.action_refresh;
            this.btnRefreshPool.Location = new System.Drawing.Point(474, 17);
            this.btnRefreshPool.Name = "btnRefreshPool";
            this.btnRefreshPool.Size = new System.Drawing.Size(29, 23);
            this.btnRefreshPool.TabIndex = 4;
            this.btnRefreshPool.UseVisualStyleBackColor = true;
            this.btnRefreshPool.Click += new System.EventHandler(this.btnRefreshPool_Click);
            // 
            // btnSavePool
            // 
            this.btnSavePool.Image = global::TERG.Properties.Resources.action_save;
            this.btnSavePool.Location = new System.Drawing.Point(509, 17);
            this.btnSavePool.Name = "btnSavePool";
            this.btnSavePool.Size = new System.Drawing.Size(29, 23);
            this.btnSavePool.TabIndex = 3;
            this.btnSavePool.UseVisualStyleBackColor = true;
            this.btnSavePool.Click += new System.EventHandler(this.btnSavePool_Click);
            // 
            // textPoolName
            // 
            this.textPoolName.Location = new System.Drawing.Point(366, 46);
            this.textPoolName.Name = "textPoolName";
            this.textPoolName.Size = new System.Drawing.Size(172, 20);
            this.textPoolName.TabIndex = 2;
            this.textPoolName.TextChanged += new System.EventHandler(this.textPoolName_TextChanged);
            // 
            // textBoxPoolEditor
            // 
            this.textBoxPoolEditor.Location = new System.Drawing.Point(185, 47);
            this.textBoxPoolEditor.Multiline = true;
            this.textBoxPoolEditor.Name = "textBoxPoolEditor";
            this.textBoxPoolEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPoolEditor.Size = new System.Drawing.Size(172, 249);
            this.textBoxPoolEditor.TabIndex = 2;
            this.textBoxPoolEditor.TextChanged += new System.EventHandler(this.textBoxPoolEditor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parent Pool:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Items";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databseToolStripMenuItem,
            this.tERGToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databseToolStripMenuItem
            // 
            this.databseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewPoolToolStripMenuItem});
            this.databseToolStripMenuItem.Name = "databseToolStripMenuItem";
            this.databseToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.databseToolStripMenuItem.Text = "Databse";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // addNewPoolToolStripMenuItem
            // 
            this.addNewPoolToolStripMenuItem.Name = "addNewPoolToolStripMenuItem";
            this.addNewPoolToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewPoolToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.addNewPoolToolStripMenuItem.Text = "Add New Pool";
            this.addNewPoolToolStripMenuItem.Click += new System.EventHandler(this.addNewPoolToolStripMenuItem_Click);
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
            this.tabEventLog.Size = new System.Drawing.Size(634, 116);
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
            this.txtEventLog.Size = new System.Drawing.Size(631, 113);
            this.txtEventLog.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEventLog);
            this.tabControl1.Location = new System.Drawing.Point(12, 336);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(642, 142);
            this.tabControl1.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 503);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupPoolBrowser);
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
            this.groupPoolBrowser.ResumeLayout(false);
            this.groupPoolBrowser.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabEventLog.ResumeLayout(false);
            this.tabEventLog.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPools;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusDatabase;
        private System.Windows.Forms.GroupBox groupPoolBrowser;
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
    }
}

