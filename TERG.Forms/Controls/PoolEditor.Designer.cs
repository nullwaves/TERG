namespace TERG.Forms.Controls
{
    partial class PoolEditor
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
            this.GroupPoolEditor = new System.Windows.Forms.GroupBox();
            this.SplitPoolEditor = new System.Windows.Forms.SplitContainer();
            this.GroupPoolDetail = new System.Windows.Forms.GroupBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextBoxPoolName = new System.Windows.Forms.TextBox();
            this.LabelPoolName = new System.Windows.Forms.Label();
            this.TextBoxPoolID = new System.Windows.Forms.TextBox();
            this.LabelPoolID = new System.Windows.Forms.Label();
            this.GroupPoolItems = new System.Windows.Forms.GroupBox();
            this.TextBoxList = new System.Windows.Forms.TextBox();
            this.GroupPoolEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPoolEditor)).BeginInit();
            this.SplitPoolEditor.Panel1.SuspendLayout();
            this.SplitPoolEditor.Panel2.SuspendLayout();
            this.SplitPoolEditor.SuspendLayout();
            this.GroupPoolDetail.SuspendLayout();
            this.GroupPoolItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupPoolEditor
            // 
            this.GroupPoolEditor.AutoSize = true;
            this.GroupPoolEditor.Controls.Add(this.SplitPoolEditor);
            this.GroupPoolEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPoolEditor.Location = new System.Drawing.Point(0, 0);
            this.GroupPoolEditor.Name = "GroupPoolEditor";
            this.GroupPoolEditor.Size = new System.Drawing.Size(476, 375);
            this.GroupPoolEditor.TabIndex = 0;
            this.GroupPoolEditor.TabStop = false;
            this.GroupPoolEditor.Text = "Pool Editor";
            // 
            // SplitPoolEditor
            // 
            this.SplitPoolEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitPoolEditor.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitPoolEditor.Location = new System.Drawing.Point(3, 16);
            this.SplitPoolEditor.Name = "SplitPoolEditor";
            // 
            // SplitPoolEditor.Panel1
            // 
            this.SplitPoolEditor.Panel1.Controls.Add(this.GroupPoolDetail);
            this.SplitPoolEditor.Panel1MinSize = 165;
            // 
            // SplitPoolEditor.Panel2
            // 
            this.SplitPoolEditor.Panel2.Controls.Add(this.GroupPoolItems);
            this.SplitPoolEditor.Size = new System.Drawing.Size(470, 356);
            this.SplitPoolEditor.SplitterDistance = 200;
            this.SplitPoolEditor.TabIndex = 2;
            this.SplitPoolEditor.TabStop = false;
            // 
            // GroupPoolDetail
            // 
            this.GroupPoolDetail.Controls.Add(this.ButtonDelete);
            this.GroupPoolDetail.Controls.Add(this.ButtonRefresh);
            this.GroupPoolDetail.Controls.Add(this.ButtonSave);
            this.GroupPoolDetail.Controls.Add(this.TextBoxPoolName);
            this.GroupPoolDetail.Controls.Add(this.LabelPoolName);
            this.GroupPoolDetail.Controls.Add(this.TextBoxPoolID);
            this.GroupPoolDetail.Controls.Add(this.LabelPoolID);
            this.GroupPoolDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPoolDetail.Location = new System.Drawing.Point(0, 0);
            this.GroupPoolDetail.Name = "GroupPoolDetail";
            this.GroupPoolDetail.Size = new System.Drawing.Size(200, 356);
            this.GroupPoolDetail.TabIndex = 1;
            this.GroupPoolDetail.TabStop = false;
            this.GroupPoolDetail.Text = "Pool Details";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AccessibleDescription = "Delete the currently selected pool.";
            this.ButtonDelete.AccessibleName = "Delete Pool";
            this.ButtonDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ButtonDelete.Image = global::TERG.Forms.Properties.Resources.table_delete;
            this.ButtonDelete.Location = new System.Drawing.Point(76, 19);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(29, 23);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Image = global::TERG.Forms.Properties.Resources.action_refresh;
            this.ButtonRefresh.Location = new System.Drawing.Point(41, 19);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(29, 23);
            this.ButtonRefresh.TabIndex = 6;
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Image = global::TERG.Forms.Properties.Resources.action_save;
            this.ButtonSave.Location = new System.Drawing.Point(6, 19);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(29, 23);
            this.ButtonSave.TabIndex = 5;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextBoxPoolName
            // 
            this.TextBoxPoolName.Enabled = false;
            this.TextBoxPoolName.Location = new System.Drawing.Point(58, 74);
            this.TextBoxPoolName.Name = "TextBoxPoolName";
            this.TextBoxPoolName.Size = new System.Drawing.Size(136, 20);
            this.TextBoxPoolName.TabIndex = 4;
            // 
            // LabelPoolName
            // 
            this.LabelPoolName.AutoSize = true;
            this.LabelPoolName.Location = new System.Drawing.Point(6, 77);
            this.LabelPoolName.Name = "LabelPoolName";
            this.LabelPoolName.Size = new System.Drawing.Size(38, 13);
            this.LabelPoolName.TabIndex = 3;
            this.LabelPoolName.Text = "Name:";
            // 
            // TextBoxPoolID
            // 
            this.TextBoxPoolID.Enabled = false;
            this.TextBoxPoolID.Location = new System.Drawing.Point(58, 48);
            this.TextBoxPoolID.Name = "TextBoxPoolID";
            this.TextBoxPoolID.Size = new System.Drawing.Size(136, 20);
            this.TextBoxPoolID.TabIndex = 2;
            this.TextBoxPoolID.TabStop = false;
            // 
            // LabelPoolID
            // 
            this.LabelPoolID.AutoSize = true;
            this.LabelPoolID.Location = new System.Drawing.Point(6, 51);
            this.LabelPoolID.Name = "LabelPoolID";
            this.LabelPoolID.Size = new System.Drawing.Size(21, 13);
            this.LabelPoolID.TabIndex = 1;
            this.LabelPoolID.Text = "ID:";
            // 
            // GroupPoolItems
            // 
            this.GroupPoolItems.AutoSize = true;
            this.GroupPoolItems.Controls.Add(this.TextBoxList);
            this.GroupPoolItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPoolItems.Location = new System.Drawing.Point(0, 0);
            this.GroupPoolItems.MinimumSize = new System.Drawing.Size(150, 0);
            this.GroupPoolItems.Name = "GroupPoolItems";
            this.GroupPoolItems.Size = new System.Drawing.Size(266, 356);
            this.GroupPoolItems.TabIndex = 0;
            this.GroupPoolItems.TabStop = false;
            this.GroupPoolItems.Text = "Pool Items";
            // 
            // TextBoxList
            // 
            this.TextBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxList.Enabled = false;
            this.TextBoxList.Location = new System.Drawing.Point(3, 16);
            this.TextBoxList.Multiline = true;
            this.TextBoxList.Name = "TextBoxList";
            this.TextBoxList.Size = new System.Drawing.Size(260, 337);
            this.TextBoxList.TabIndex = 0;
            // 
            // PoolEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupPoolEditor);
            this.Name = "PoolEditor";
            this.Size = new System.Drawing.Size(476, 375);
            this.GroupPoolEditor.ResumeLayout(false);
            this.SplitPoolEditor.Panel1.ResumeLayout(false);
            this.SplitPoolEditor.Panel2.ResumeLayout(false);
            this.SplitPoolEditor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPoolEditor)).EndInit();
            this.SplitPoolEditor.ResumeLayout(false);
            this.GroupPoolDetail.ResumeLayout(false);
            this.GroupPoolDetail.PerformLayout();
            this.GroupPoolItems.ResumeLayout(false);
            this.GroupPoolItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupPoolEditor;
        private System.Windows.Forms.GroupBox GroupPoolItems;
        private System.Windows.Forms.GroupBox GroupPoolDetail;
        private System.Windows.Forms.TextBox TextBoxPoolName;
        private System.Windows.Forms.Label LabelPoolName;
        private System.Windows.Forms.TextBox TextBoxPoolID;
        private System.Windows.Forms.Label LabelPoolID;
        private System.Windows.Forms.SplitContainer SplitPoolEditor;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox TextBoxList;
    }
}
