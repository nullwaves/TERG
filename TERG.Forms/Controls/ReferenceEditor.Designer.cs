namespace TERG.Forms.Controls.ReferenceEditors
{
    partial class ReferenceEditor
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
            this.GroupReferenceEditor = new System.Windows.Forms.GroupBox();
            this.SplitReferenceEditor = new System.Windows.Forms.SplitContainer();
            this.ComboReferenceType = new System.Windows.Forms.ComboBox();
            this.LabelReferenceType = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.GroupReferenceEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitReferenceEditor)).BeginInit();
            this.SplitReferenceEditor.Panel1.SuspendLayout();
            this.SplitReferenceEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupReferenceEditor
            // 
            this.GroupReferenceEditor.Controls.Add(this.SplitReferenceEditor);
            this.GroupReferenceEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupReferenceEditor.Location = new System.Drawing.Point(0, 0);
            this.GroupReferenceEditor.Name = "GroupReferenceEditor";
            this.GroupReferenceEditor.Size = new System.Drawing.Size(197, 263);
            this.GroupReferenceEditor.TabIndex = 0;
            this.GroupReferenceEditor.TabStop = false;
            this.GroupReferenceEditor.Text = "Reference Editor";
            // 
            // SplitReferenceEditor
            // 
            this.SplitReferenceEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitReferenceEditor.IsSplitterFixed = true;
            this.SplitReferenceEditor.Location = new System.Drawing.Point(3, 16);
            this.SplitReferenceEditor.Name = "SplitReferenceEditor";
            this.SplitReferenceEditor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitReferenceEditor.Panel1
            // 
            this.SplitReferenceEditor.Panel1.Controls.Add(this.TextBoxName);
            this.SplitReferenceEditor.Panel1.Controls.Add(this.LabelName);
            this.SplitReferenceEditor.Panel1.Controls.Add(this.ComboReferenceType);
            this.SplitReferenceEditor.Panel1.Controls.Add(this.LabelReferenceType);
            this.SplitReferenceEditor.Panel1MinSize = 58;
            this.SplitReferenceEditor.Size = new System.Drawing.Size(191, 244);
            this.SplitReferenceEditor.SplitterDistance = 58;
            this.SplitReferenceEditor.TabIndex = 0;
            // 
            // ComboReferenceType
            // 
            this.ComboReferenceType.FormattingEnabled = true;
            this.ComboReferenceType.Location = new System.Drawing.Point(43, 3);
            this.ComboReferenceType.Name = "ComboReferenceType";
            this.ComboReferenceType.Size = new System.Drawing.Size(144, 21);
            this.ComboReferenceType.TabIndex = 1;
            // 
            // LabelReferenceType
            // 
            this.LabelReferenceType.AutoSize = true;
            this.LabelReferenceType.Location = new System.Drawing.Point(3, 6);
            this.LabelReferenceType.Name = "LabelReferenceType";
            this.LabelReferenceType.Size = new System.Drawing.Size(34, 13);
            this.LabelReferenceType.TabIndex = 0;
            this.LabelReferenceType.Text = "Type:";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(3, 33);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(38, 13);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Name:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(43, 30);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(144, 20);
            this.TextBoxName.TabIndex = 3;
            // 
            // ReferenceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupReferenceEditor);
            this.Name = "ReferenceEditor";
            this.Size = new System.Drawing.Size(197, 263);
            this.GroupReferenceEditor.ResumeLayout(false);
            this.SplitReferenceEditor.Panel1.ResumeLayout(false);
            this.SplitReferenceEditor.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitReferenceEditor)).EndInit();
            this.SplitReferenceEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupReferenceEditor;
        private System.Windows.Forms.SplitContainer SplitReferenceEditor;
        private System.Windows.Forms.ComboBox ComboReferenceType;
        private System.Windows.Forms.Label LabelReferenceType;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
    }
}
