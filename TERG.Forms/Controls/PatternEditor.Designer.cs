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
            this.ButtonEditFooter = new System.Windows.Forms.Button();
            this.ButtonEditBody = new System.Windows.Forms.Button();
            this.ButtonEditHeader = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonRefresh = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.SplitPatternReferences = new System.Windows.Forms.SplitContainer();
            this.GroupReferences = new System.Windows.Forms.GroupBox();
            this.ListReferences = new System.Windows.Forms.ListBox();
            this.SplitReferenceControls = new System.Windows.Forms.SplitContainer();
            this.ButtonReferenceDown = new System.Windows.Forms.Button();
            this.ButtonReferenceUp = new System.Windows.Forms.Button();
            this.ButtonNewReference = new System.Windows.Forms.Button();
            this.GroupPatternEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPatternEditor)).BeginInit();
            this.SplitPatternEditor.Panel1.SuspendLayout();
            this.SplitPatternEditor.Panel2.SuspendLayout();
            this.SplitPatternEditor.SuspendLayout();
            this.GroupPatternDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPatternReferences)).BeginInit();
            this.SplitPatternReferences.Panel1.SuspendLayout();
            this.SplitPatternReferences.SuspendLayout();
            this.GroupReferences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitReferenceControls)).BeginInit();
            this.SplitReferenceControls.Panel1.SuspendLayout();
            this.SplitReferenceControls.Panel2.SuspendLayout();
            this.SplitReferenceControls.SuspendLayout();
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
            // 
            // SplitPatternEditor.Panel2
            // 
            this.SplitPatternEditor.Panel2.Controls.Add(this.SplitPatternReferences);
            this.SplitPatternEditor.Size = new System.Drawing.Size(701, 312);
            this.SplitPatternEditor.SplitterDistance = 208;
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
            this.GroupPatternDetail.Size = new System.Drawing.Size(208, 312);
            this.GroupPatternDetail.TabIndex = 2;
            this.GroupPatternDetail.TabStop = false;
            this.GroupPatternDetail.Text = "Pattern Details";
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
            // TextBoxName
            // 
            this.TextBoxName.Enabled = false;
            this.TextBoxName.Location = new System.Drawing.Point(58, 74);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(136, 20);
            this.TextBoxName.TabIndex = 4;
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
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
            // SplitPatternReferences
            // 
            this.SplitPatternReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitPatternReferences.Location = new System.Drawing.Point(0, 0);
            this.SplitPatternReferences.Name = "SplitPatternReferences";
            // 
            // SplitPatternReferences.Panel1
            // 
            this.SplitPatternReferences.Panel1.Controls.Add(this.GroupReferences);
            this.SplitPatternReferences.Panel1MinSize = 165;
            this.SplitPatternReferences.Size = new System.Drawing.Size(489, 312);
            this.SplitPatternReferences.SplitterDistance = 173;
            this.SplitPatternReferences.TabIndex = 0;
            // 
            // GroupReferences
            // 
            this.GroupReferences.Controls.Add(this.SplitReferenceControls);
            this.GroupReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupReferences.Location = new System.Drawing.Point(0, 0);
            this.GroupReferences.Name = "GroupReferences";
            this.GroupReferences.Size = new System.Drawing.Size(173, 312);
            this.GroupReferences.TabIndex = 0;
            this.GroupReferences.TabStop = false;
            this.GroupReferences.Text = "References";
            // 
            // ListReferences
            // 
            this.ListReferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListReferences.FormattingEnabled = true;
            this.ListReferences.Location = new System.Drawing.Point(0, 0);
            this.ListReferences.Name = "ListReferences";
            this.ListReferences.Size = new System.Drawing.Size(167, 259);
            this.ListReferences.TabIndex = 0;
            // 
            // SplitReferenceControls
            // 
            this.SplitReferenceControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitReferenceControls.Location = new System.Drawing.Point(3, 16);
            this.SplitReferenceControls.Name = "SplitReferenceControls";
            this.SplitReferenceControls.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitReferenceControls.Panel1
            // 
            this.SplitReferenceControls.Panel1.Controls.Add(this.ButtonReferenceDown);
            this.SplitReferenceControls.Panel1.Controls.Add(this.ButtonReferenceUp);
            this.SplitReferenceControls.Panel1.Controls.Add(this.ButtonNewReference);
            this.SplitReferenceControls.Panel1MinSize = 30;
            // 
            // SplitReferenceControls.Panel2
            // 
            this.SplitReferenceControls.Panel2.Controls.Add(this.ListReferences);
            this.SplitReferenceControls.Size = new System.Drawing.Size(167, 293);
            this.SplitReferenceControls.SplitterDistance = 30;
            this.SplitReferenceControls.TabIndex = 0;
            // 
            // ButtonReferenceDown
            // 
            this.ButtonReferenceDown.Image = global::TERG.Forms.Properties.Resources.arrow_down;
            this.ButtonReferenceDown.Location = new System.Drawing.Point(127, 4);
            this.ButtonReferenceDown.Name = "ButtonReferenceDown";
            this.ButtonReferenceDown.Size = new System.Drawing.Size(29, 23);
            this.ButtonReferenceDown.TabIndex = 16;
            this.ButtonReferenceDown.UseVisualStyleBackColor = true;
            this.ButtonReferenceDown.Click += new System.EventHandler(this.ButtonReferenceDown_Click);
            // 
            // ButtonReferenceUp
            // 
            this.ButtonReferenceUp.Image = global::TERG.Forms.Properties.Resources.arrow_up;
            this.ButtonReferenceUp.Location = new System.Drawing.Point(92, 4);
            this.ButtonReferenceUp.Name = "ButtonReferenceUp";
            this.ButtonReferenceUp.Size = new System.Drawing.Size(29, 23);
            this.ButtonReferenceUp.TabIndex = 15;
            this.ButtonReferenceUp.UseVisualStyleBackColor = true;
            this.ButtonReferenceUp.Click += new System.EventHandler(this.ButtonReferenceUp_Click);
            // 
            // ButtonNewReference
            // 
            this.ButtonNewReference.Location = new System.Drawing.Point(3, 3);
            this.ButtonNewReference.Name = "ButtonNewReference";
            this.ButtonNewReference.Size = new System.Drawing.Size(43, 24);
            this.ButtonNewReference.TabIndex = 14;
            this.ButtonNewReference.Text = "+ Ref";
            this.ButtonNewReference.UseVisualStyleBackColor = true;
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
            this.SplitPatternEditor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitPatternEditor)).EndInit();
            this.SplitPatternEditor.ResumeLayout(false);
            this.GroupPatternDetail.ResumeLayout(false);
            this.GroupPatternDetail.PerformLayout();
            this.SplitPatternReferences.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitPatternReferences)).EndInit();
            this.SplitPatternReferences.ResumeLayout(false);
            this.GroupReferences.ResumeLayout(false);
            this.SplitReferenceControls.Panel1.ResumeLayout(false);
            this.SplitReferenceControls.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitReferenceControls)).EndInit();
            this.SplitReferenceControls.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer SplitPatternReferences;
        private System.Windows.Forms.GroupBox GroupReferences;
        private System.Windows.Forms.ListBox ListReferences;
        private System.Windows.Forms.SplitContainer SplitReferenceControls;
        private System.Windows.Forms.Button ButtonReferenceDown;
        private System.Windows.Forms.Button ButtonReferenceUp;
        private System.Windows.Forms.Button ButtonNewReference;
    }
}
