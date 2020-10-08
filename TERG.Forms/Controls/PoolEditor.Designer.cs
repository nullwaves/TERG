﻿namespace TERG.Forms.Controls
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
            this.GroupPoolItems = new System.Windows.Forms.GroupBox();
            this.ListboxPoolItems = new System.Windows.Forms.ListBox();
            this.GroupPoolDetail = new System.Windows.Forms.GroupBox();
            this.LabelPoolID = new System.Windows.Forms.Label();
            this.TextBoxPoolID = new System.Windows.Forms.TextBox();
            this.TextBoxPoolName = new System.Windows.Forms.TextBox();
            this.LabelPoolName = new System.Windows.Forms.Label();
            this.SplitPoolEditor = new System.Windows.Forms.SplitContainer();
            this.GroupPoolEditor.SuspendLayout();
            this.GroupPoolItems.SuspendLayout();
            this.GroupPoolDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPoolEditor)).BeginInit();
            this.SplitPoolEditor.Panel1.SuspendLayout();
            this.SplitPoolEditor.Panel2.SuspendLayout();
            this.SplitPoolEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupPoolEditor
            // 
            this.GroupPoolEditor.Controls.Add(this.SplitPoolEditor);
            this.GroupPoolEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPoolEditor.Location = new System.Drawing.Point(0, 0);
            this.GroupPoolEditor.Name = "GroupPoolEditor";
            this.GroupPoolEditor.Size = new System.Drawing.Size(476, 375);
            this.GroupPoolEditor.TabIndex = 0;
            this.GroupPoolEditor.TabStop = false;
            this.GroupPoolEditor.Text = "Pool Editor";
            // 
            // GroupPoolItems
            // 
            this.GroupPoolItems.Controls.Add(this.ListboxPoolItems);
            this.GroupPoolItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPoolItems.Location = new System.Drawing.Point(0, 0);
            this.GroupPoolItems.MinimumSize = new System.Drawing.Size(150, 0);
            this.GroupPoolItems.Name = "GroupPoolItems";
            this.GroupPoolItems.Size = new System.Drawing.Size(266, 356);
            this.GroupPoolItems.TabIndex = 0;
            this.GroupPoolItems.TabStop = false;
            this.GroupPoolItems.Text = "Pool Items";
            // 
            // ListboxPoolItems
            // 
            this.ListboxPoolItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListboxPoolItems.FormattingEnabled = true;
            this.ListboxPoolItems.Location = new System.Drawing.Point(3, 16);
            this.ListboxPoolItems.Name = "ListboxPoolItems";
            this.ListboxPoolItems.Size = new System.Drawing.Size(260, 337);
            this.ListboxPoolItems.TabIndex = 0;
            // 
            // GroupPoolDetail
            // 
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
            // LabelPoolID
            // 
            this.LabelPoolID.AutoSize = true;
            this.LabelPoolID.Location = new System.Drawing.Point(6, 22);
            this.LabelPoolID.Name = "LabelPoolID";
            this.LabelPoolID.Size = new System.Drawing.Size(21, 13);
            this.LabelPoolID.TabIndex = 1;
            this.LabelPoolID.Text = "ID:";
            // 
            // TextBoxPoolID
            // 
            this.TextBoxPoolID.Enabled = false;
            this.TextBoxPoolID.Location = new System.Drawing.Point(58, 19);
            this.TextBoxPoolID.Name = "TextBoxPoolID";
            this.TextBoxPoolID.Size = new System.Drawing.Size(136, 20);
            this.TextBoxPoolID.TabIndex = 2;
            this.TextBoxPoolID.TabStop = false;
            // 
            // TextBoxPoolName
            // 
            this.TextBoxPoolName.Enabled = false;
            this.TextBoxPoolName.Location = new System.Drawing.Point(58, 45);
            this.TextBoxPoolName.Name = "TextBoxPoolName";
            this.TextBoxPoolName.Size = new System.Drawing.Size(136, 20);
            this.TextBoxPoolName.TabIndex = 4;
            // 
            // LabelPoolName
            // 
            this.LabelPoolName.AutoSize = true;
            this.LabelPoolName.Location = new System.Drawing.Point(6, 48);
            this.LabelPoolName.Name = "LabelPoolName";
            this.LabelPoolName.Size = new System.Drawing.Size(38, 13);
            this.LabelPoolName.TabIndex = 3;
            this.LabelPoolName.Text = "Name:";
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
            // 
            // SplitPoolEditor.Panel2
            // 
            this.SplitPoolEditor.Panel2.Controls.Add(this.GroupPoolItems);
            this.SplitPoolEditor.Size = new System.Drawing.Size(470, 356);
            this.SplitPoolEditor.SplitterDistance = 200;
            this.SplitPoolEditor.TabIndex = 2;
            this.SplitPoolEditor.TabStop = false;
            // 
            // PoolEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupPoolEditor);
            this.Name = "PoolEditor";
            this.Size = new System.Drawing.Size(476, 375);
            this.GroupPoolEditor.ResumeLayout(false);
            this.GroupPoolItems.ResumeLayout(false);
            this.GroupPoolDetail.ResumeLayout(false);
            this.GroupPoolDetail.PerformLayout();
            this.SplitPoolEditor.Panel1.ResumeLayout(false);
            this.SplitPoolEditor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitPoolEditor)).EndInit();
            this.SplitPoolEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupPoolEditor;
        private System.Windows.Forms.GroupBox GroupPoolItems;
        private System.Windows.Forms.ListBox ListboxPoolItems;
        private System.Windows.Forms.GroupBox GroupPoolDetail;
        private System.Windows.Forms.TextBox TextBoxPoolName;
        private System.Windows.Forms.Label LabelPoolName;
        private System.Windows.Forms.TextBox TextBoxPoolID;
        private System.Windows.Forms.Label LabelPoolID;
        private System.Windows.Forms.SplitContainer SplitPoolEditor;
    }
}
