namespace TERG.Forms.Controls
{
    partial class PatternEditor
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
            this.GroupPatternEditor = new System.Windows.Forms.GroupBox();
            this.SplitPatternEditor = new System.Windows.Forms.SplitContainer();
            this.GroupPatternDetail = new System.Windows.Forms.GroupBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.ButtonEditHeader = new System.Windows.Forms.Button();
            this.ButtonEditBody = new System.Windows.Forms.Button();
            this.ButtonEditFooter = new System.Windows.Forms.Button();
            this.GroupPatternEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPatternEditor)).BeginInit();
            this.SplitPatternEditor.Panel1.SuspendLayout();
            this.SplitPatternEditor.SuspendLayout();
            this.GroupPatternDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupPatternEditor
            // 
            this.GroupPatternEditor.AutoSize = true;
            this.GroupPatternEditor.Controls.Add(this.SplitPatternEditor);
            this.GroupPatternEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPatternEditor.Location = new System.Drawing.Point(0, 0);
            this.GroupPatternEditor.Name = "GroupPatternEditor";
            this.GroupPatternEditor.Size = new System.Drawing.Size(707, 331);
            this.GroupPatternEditor.TabIndex = 0;
            this.GroupPatternEditor.TabStop = false;
            this.GroupPatternEditor.Text = "PatternEditor";
            // 
            // SplitPatternEditor
            // 
            this.SplitPatternEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitPatternEditor.Location = new System.Drawing.Point(3, 16);
            this.SplitPatternEditor.Name = "SplitPatternEditor";
            // 
            // SplitPatternEditor.Panel1
            // 
            this.SplitPatternEditor.Panel1.Controls.Add(this.GroupPatternDetail);
            this.SplitPatternEditor.Panel1MinSize = 200;
            this.SplitPatternEditor.Size = new System.Drawing.Size(701, 312);
            this.SplitPatternEditor.SplitterDistance = 200;
            this.SplitPatternEditor.TabIndex = 0;
            // 
            // GroupPatternDetail
            // 
            this.GroupPatternDetail.AutoSize = true;
            this.GroupPatternDetail.Controls.Add(this.ButtonEditFooter);
            this.GroupPatternDetail.Controls.Add(this.ButtonEditBody);
            this.GroupPatternDetail.Controls.Add(this.ButtonEditHeader);
            this.GroupPatternDetail.Controls.Add(this.ButtonDelete);
            this.GroupPatternDetail.Controls.Add(this.ButtonRefresh);
            this.GroupPatternDetail.Controls.Add(this.ButtonSave);
            this.GroupPatternDetail.Controls.Add(this.TextBoxName);
            this.GroupPatternDetail.Controls.Add(this.LabelName);
            this.GroupPatternDetail.Controls.Add(this.TextBoxID);
            this.GroupPatternDetail.Controls.Add(this.LabelID);
            this.GroupPatternDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPatternDetail.Location = new System.Drawing.Point(0, 0);
            this.GroupPatternDetail.Name = "GroupPatternDetail";
            this.GroupPatternDetail.Size = new System.Drawing.Size(200, 312);
            this.GroupPatternDetail.TabIndex = 2;
            this.GroupPatternDetail.TabStop = false;
            this.GroupPatternDetail.Text = "Pattern Details";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.AccessibleDescription = "";
            this.ButtonDelete.AccessibleName = "";
            this.ButtonDelete.Image = global::TERG.Forms.Properties.Resources.table_delete;
            this.ButtonDelete.Location = new System.Drawing.Point(76, 19);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(29, 23);
            this.ButtonDelete.TabIndex = 7;
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Image = global::TERG.Forms.Properties.Resources.action_refresh;
            this.ButtonRefresh.Location = new System.Drawing.Point(41, 19);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(29, 23);
            this.ButtonRefresh.TabIndex = 6;
            this.ButtonRefresh.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Image = global::TERG.Forms.Properties.Resources.action_save;
            this.ButtonSave.Location = new System.Drawing.Point(6, 19);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(29, 23);
            this.ButtonSave.TabIndex = 5;
            this.ButtonSave.UseVisualStyleBackColor = true;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Enabled = false;
            this.TextBoxName.Location = new System.Drawing.Point(58, 74);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(136, 20);
            this.TextBoxName.TabIndex = 4;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(6, 77);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(38, 13);
            this.LabelName.TabIndex = 3;
            this.LabelName.Text = "Name:";
            // 
            // TextBoxID
            // 
            this.TextBoxID.Enabled = false;
            this.TextBoxID.Location = new System.Drawing.Point(58, 48);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(136, 20);
            this.TextBoxID.TabIndex = 2;
            this.TextBoxID.TabStop = false;
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(6, 51);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(21, 13);
            this.LabelID.TabIndex = 1;
            this.LabelID.Text = "ID:";
            // 
            // ButtonEditHeader
            // 
            this.ButtonEditHeader.Location = new System.Drawing.Point(6, 100);
            this.ButtonEditHeader.Name = "ButtonEditHeader";
            this.ButtonEditHeader.Size = new System.Drawing.Size(54, 23);
            this.ButtonEditHeader.TabIndex = 1;
            this.ButtonEditHeader.Text = "Header";
            this.ButtonEditHeader.UseVisualStyleBackColor = true;
            this.ButtonEditHeader.Click += new System.EventHandler(this.ButtonEditHeader_Click);
            // 
            // ButtonEditBody
            // 
            this.ButtonEditBody.Location = new System.Drawing.Point(66, 100);
            this.ButtonEditBody.Name = "ButtonEditBody";
            this.ButtonEditBody.Size = new System.Drawing.Size(54, 23);
            this.ButtonEditBody.TabIndex = 8;
            this.ButtonEditBody.Text = "Body";
            this.ButtonEditBody.UseVisualStyleBackColor = true;
            this.ButtonEditBody.Click += new System.EventHandler(this.ButtonEditBody_Click);
            // 
            // ButtonEditFooter
            // 
            this.ButtonEditFooter.Location = new System.Drawing.Point(126, 100);
            this.ButtonEditFooter.Name = "ButtonEditFooter";
            this.ButtonEditFooter.Size = new System.Drawing.Size(54, 23);
            this.ButtonEditFooter.TabIndex = 9;
            this.ButtonEditFooter.Text = "Footer";
            this.ButtonEditFooter.UseVisualStyleBackColor = true;
            this.ButtonEditFooter.Click += new System.EventHandler(this.ButtonEditFooter_Click);
            // 
            // PatternEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupPatternEditor);
            this.Name = "PatternEditor";
            this.Size = new System.Drawing.Size(707, 331);
            this.GroupPatternEditor.ResumeLayout(false);
            this.SplitPatternEditor.Panel1.ResumeLayout(false);
            this.SplitPatternEditor.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPatternEditor)).EndInit();
            this.SplitPatternEditor.ResumeLayout(false);
            this.GroupPatternDetail.ResumeLayout(false);
            this.GroupPatternDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupPatternEditor;
        private System.Windows.Forms.SplitContainer SplitPatternEditor;
        private System.Windows.Forms.GroupBox GroupPatternDetail;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonRefresh;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Button ButtonEditFooter;
        private System.Windows.Forms.Button ButtonEditBody;
        private System.Windows.Forms.Button ButtonEditHeader;
    }
}
