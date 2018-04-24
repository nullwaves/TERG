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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToPoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMultipleToPoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tERGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEventLog = new System.Windows.Forms.TabPage();
            this.txtEventLog = new System.Windows.Forms.TextBox();
            this.tabPoolEditor = new System.Windows.Forms.TabPage();
            this.btnRemoveItems = new System.Windows.Forms.Button();
            this.btnAddToPool = new System.Windows.Forms.Button();
            this.txtNewItem = new System.Windows.Forms.TextBox();
            this.btnDeletePool = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPoolEditor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mainStatusStrip.SuspendLayout();
            this.groupPoolBrowser.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabEventLog.SuspendLayout();
            this.tabPoolEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPools
            // 
            this.listPools.FormattingEnabled = true;
            this.listPools.Location = new System.Drawing.Point(6, 19);
            this.listPools.Name = "listPools";
            this.listPools.Size = new System.Drawing.Size(173, 277);
            this.listPools.TabIndex = 0;
            this.listPools.SelectedIndexChanged += new System.EventHandler(this.listPools_SelectedIndexChanged);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDatabase});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 336);
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
            this.groupPoolBrowser.Controls.Add(this.button2);
            this.groupPoolBrowser.Controls.Add(this.button1);
            this.groupPoolBrowser.Controls.Add(this.textBoxPoolEditor);
            this.groupPoolBrowser.Controls.Add(this.label1);
            this.groupPoolBrowser.Controls.Add(this.listPools);
            this.groupPoolBrowser.Location = new System.Drawing.Point(0, 27);
            this.groupPoolBrowser.Name = "groupPoolBrowser";
            this.groupPoolBrowser.Size = new System.Drawing.Size(364, 303);
            this.groupPoolBrowser.TabIndex = 4;
            this.groupPoolBrowser.TabStop = false;
            this.groupPoolBrowser.Text = "Pool Browser";
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
            this.addNewPoolToolStripMenuItem,
            this.addItemToPoolToolStripMenuItem,
            this.addMultipleToPoolToolStripMenuItem});
            this.databseToolStripMenuItem.Name = "databseToolStripMenuItem";
            this.databseToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.databseToolStripMenuItem.Text = "Databse";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(250, 6);
            // 
            // addNewPoolToolStripMenuItem
            // 
            this.addNewPoolToolStripMenuItem.Name = "addNewPoolToolStripMenuItem";
            this.addNewPoolToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewPoolToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.addNewPoolToolStripMenuItem.Text = "Add New Pool";
            this.addNewPoolToolStripMenuItem.Click += new System.EventHandler(this.addNewPoolToolStripMenuItem_Click);
            // 
            // addItemToPoolToolStripMenuItem
            // 
            this.addItemToPoolToolStripMenuItem.Name = "addItemToPoolToolStripMenuItem";
            this.addItemToPoolToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.addItemToPoolToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.addItemToPoolToolStripMenuItem.Text = "Add Item To Pool";
            this.addItemToPoolToolStripMenuItem.Click += new System.EventHandler(this.addItemToPoolToolStripMenuItem_Click);
            // 
            // addMultipleToPoolToolStripMenuItem
            // 
            this.addMultipleToPoolToolStripMenuItem.Name = "addMultipleToPoolToolStripMenuItem";
            this.addMultipleToPoolToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.addMultipleToPoolToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.addMultipleToPoolToolStripMenuItem.Text = "Add Multiple to Pool";
            this.addMultipleToPoolToolStripMenuItem.Click += new System.EventHandler(this.addMultipleToPoolToolStripMenuItem_Click);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEventLog);
            this.tabControl1.Controls.Add(this.tabPoolEditor);
            this.tabControl1.Location = new System.Drawing.Point(370, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(294, 303);
            this.tabControl1.TabIndex = 6;
            // 
            // tabEventLog
            // 
            this.tabEventLog.Controls.Add(this.txtEventLog);
            this.tabEventLog.Location = new System.Drawing.Point(4, 22);
            this.tabEventLog.Name = "tabEventLog";
            this.tabEventLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabEventLog.Size = new System.Drawing.Size(286, 277);
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
            this.txtEventLog.Size = new System.Drawing.Size(286, 277);
            this.txtEventLog.TabIndex = 1;
            // 
            // tabPoolEditor
            // 
            this.tabPoolEditor.Controls.Add(this.btnRemoveItems);
            this.tabPoolEditor.Controls.Add(this.btnAddToPool);
            this.tabPoolEditor.Controls.Add(this.txtNewItem);
            this.tabPoolEditor.Controls.Add(this.btnDeletePool);
            this.tabPoolEditor.Location = new System.Drawing.Point(4, 22);
            this.tabPoolEditor.Name = "tabPoolEditor";
            this.tabPoolEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoolEditor.Size = new System.Drawing.Size(286, 277);
            this.tabPoolEditor.TabIndex = 0;
            this.tabPoolEditor.Text = "Pool Editor";
            this.tabPoolEditor.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.Location = new System.Drawing.Point(7, 62);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(273, 23);
            this.btnRemoveItems.TabIndex = 4;
            this.btnRemoveItems.Text = "Delete Selected Items From Pool";
            this.btnRemoveItems.UseVisualStyleBackColor = true;
            // 
            // btnAddToPool
            // 
            this.btnAddToPool.Location = new System.Drawing.Point(193, 34);
            this.btnAddToPool.Name = "btnAddToPool";
            this.btnAddToPool.Size = new System.Drawing.Size(87, 23);
            this.btnAddToPool.TabIndex = 3;
            this.btnAddToPool.Text = "Add To Pool";
            this.btnAddToPool.UseVisualStyleBackColor = true;
            // 
            // txtNewItem
            // 
            this.txtNewItem.Location = new System.Drawing.Point(7, 36);
            this.txtNewItem.Name = "txtNewItem";
            this.txtNewItem.Size = new System.Drawing.Size(180, 20);
            this.txtNewItem.TabIndex = 2;
            // 
            // btnDeletePool
            // 
            this.btnDeletePool.Location = new System.Drawing.Point(149, 6);
            this.btnDeletePool.Name = "btnDeletePool";
            this.btnDeletePool.Size = new System.Drawing.Size(131, 23);
            this.btnDeletePool.TabIndex = 1;
            this.btnDeletePool.Text = "Delete Selected Pool(s)";
            this.btnDeletePool.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Items";
            // 
            // textBoxPoolEditor
            // 
            this.textBoxPoolEditor.Location = new System.Drawing.Point(186, 36);
            this.textBoxPoolEditor.Multiline = true;
            this.textBoxPoolEditor.Name = "textBoxPoolEditor";
            this.textBoxPoolEditor.Size = new System.Drawing.Size(172, 260);
            this.textBoxPoolEditor.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = global::TERG.Properties.Resources.action_save;
            this.button1.Location = new System.Drawing.Point(329, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::TERG.Properties.Resources.action_refresh;
            this.button2.Location = new System.Drawing.Point(294, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 358);
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
            this.tabControl1.ResumeLayout(false);
            this.tabEventLog.ResumeLayout(false);
            this.tabEventLog.PerformLayout();
            this.tabPoolEditor.ResumeLayout(false);
            this.tabPoolEditor.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPoolEditor;
        private System.Windows.Forms.TabPage tabEventLog;
        private System.Windows.Forms.TextBox txtEventLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewPoolToolStripMenuItem;
        private System.Windows.Forms.Button btnRemoveItems;
        private System.Windows.Forms.Button btnAddToPool;
        private System.Windows.Forms.TextBox txtNewItem;
        private System.Windows.Forms.Button btnDeletePool;
        private System.Windows.Forms.ToolStripMenuItem addItemToPoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMultipleToPoolToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPoolEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

