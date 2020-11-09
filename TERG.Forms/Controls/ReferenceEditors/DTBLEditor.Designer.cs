namespace TERG.Forms.Controls.ReferenceEditors
{
    partial class DTBLEditor
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
            this.SplitDTBLEditor = new System.Windows.Forms.SplitContainer();
            this.ButtonEditReference = new System.Windows.Forms.Button();
            this.LabelRowStart = new System.Windows.Forms.Label();
            this.ComboReferenceType = new System.Windows.Forms.ComboBox();
            this.TextBoxRowStart = new System.Windows.Forms.TextBox();
            this.ButtonDeleteRow = new System.Windows.Forms.Button();
            this.LabelRowEnd = new System.Windows.Forms.Label();
            this.ButtonAddRow = new System.Windows.Forms.Button();
            this.TextBoxRowEnd = new System.Windows.Forms.TextBox();
            this.LabelRowValue = new System.Windows.Forms.Label();
            this.TextBoxRowValue = new System.Windows.Forms.TextBox();
            this.CheckBoxUseReference = new System.Windows.Forms.CheckBox();
            this.ListRows = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplitDTBLEditor)).BeginInit();
            this.SplitDTBLEditor.Panel1.SuspendLayout();
            this.SplitDTBLEditor.Panel2.SuspendLayout();
            this.SplitDTBLEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitDTBLEditor
            // 
            this.SplitDTBLEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitDTBLEditor.Location = new System.Drawing.Point(0, 0);
            this.SplitDTBLEditor.Name = "SplitDTBLEditor";
            // 
            // SplitDTBLEditor.Panel1
            // 
            this.SplitDTBLEditor.Panel1.Controls.Add(this.ButtonEditReference);
            this.SplitDTBLEditor.Panel1.Controls.Add(this.LabelRowStart);
            this.SplitDTBLEditor.Panel1.Controls.Add(this.ComboReferenceType);
            this.SplitDTBLEditor.Panel1.Controls.Add(this.TextBoxRowStart);
            this.SplitDTBLEditor.Panel1.Controls.Add(this.ButtonDeleteRow);
            this.SplitDTBLEditor.Panel1.Controls.Add(this.LabelRowEnd);
            this.SplitDTBLEditor.Panel1.Controls.Add(this.ButtonAddRow);
            this.SplitDTBLEditor.Panel1.Controls.Add(this.TextBoxRowEnd);
            this.SplitDTBLEditor.Panel1.Controls.Add(this.LabelRowValue);
            this.SplitDTBLEditor.Panel1.Controls.Add(this.TextBoxRowValue);
            this.SplitDTBLEditor.Panel1.Controls.Add(this.CheckBoxUseReference);
            this.SplitDTBLEditor.Panel1MinSize = 140;
            // 
            // SplitDTBLEditor.Panel2
            // 
            this.SplitDTBLEditor.Panel2.Controls.Add(this.ListRows);
            this.SplitDTBLEditor.Size = new System.Drawing.Size(310, 285);
            this.SplitDTBLEditor.SplitterDistance = 140;
            this.SplitDTBLEditor.TabIndex = 1;
            // 
            // ButtonEditReference
            // 
            this.ButtonEditReference.Location = new System.Drawing.Point(98, 93);
            this.ButtonEditReference.Name = "ButtonEditReference";
            this.ButtonEditReference.Size = new System.Drawing.Size(38, 23);
            this.ButtonEditReference.TabIndex = 12;
            this.ButtonEditReference.Text = "Edit";
            this.ButtonEditReference.UseVisualStyleBackColor = true;
            // 
            // LabelRowStart
            // 
            this.LabelRowStart.AutoSize = true;
            this.LabelRowStart.Location = new System.Drawing.Point(5, 6);
            this.LabelRowStart.Name = "LabelRowStart";
            this.LabelRowStart.Size = new System.Drawing.Size(57, 13);
            this.LabelRowStart.TabIndex = 0;
            this.LabelRowStart.Text = "Row Start:";
            // 
            // ComboReferenceType
            // 
            this.ComboReferenceType.FormattingEnabled = true;
            this.ComboReferenceType.Location = new System.Drawing.Point(7, 120);
            this.ComboReferenceType.Name = "ComboReferenceType";
            this.ComboReferenceType.Size = new System.Drawing.Size(129, 21);
            this.ComboReferenceType.TabIndex = 11;
            // 
            // TextBoxRowStart
            // 
            this.TextBoxRowStart.Location = new System.Drawing.Point(79, 3);
            this.TextBoxRowStart.Name = "TextBoxRowStart";
            this.TextBoxRowStart.Size = new System.Drawing.Size(57, 20);
            this.TextBoxRowStart.TabIndex = 1;
            // 
            // ButtonDeleteRow
            // 
            this.ButtonDeleteRow.Location = new System.Drawing.Point(79, 151);
            this.ButtonDeleteRow.Name = "ButtonDeleteRow";
            this.ButtonDeleteRow.Size = new System.Drawing.Size(58, 23);
            this.ButtonDeleteRow.TabIndex = 10;
            this.ButtonDeleteRow.Text = "-";
            this.ButtonDeleteRow.UseVisualStyleBackColor = true;
            // 
            // LabelRowEnd
            // 
            this.LabelRowEnd.AutoSize = true;
            this.LabelRowEnd.Location = new System.Drawing.Point(4, 32);
            this.LabelRowEnd.Name = "LabelRowEnd";
            this.LabelRowEnd.Size = new System.Drawing.Size(54, 13);
            this.LabelRowEnd.TabIndex = 2;
            this.LabelRowEnd.Text = "Row End:";
            // 
            // ButtonAddRow
            // 
            this.ButtonAddRow.Location = new System.Drawing.Point(5, 151);
            this.ButtonAddRow.Name = "ButtonAddRow";
            this.ButtonAddRow.Size = new System.Drawing.Size(57, 23);
            this.ButtonAddRow.TabIndex = 9;
            this.ButtonAddRow.Text = "+";
            this.ButtonAddRow.UseVisualStyleBackColor = true;
            // 
            // TextBoxRowEnd
            // 
            this.TextBoxRowEnd.Location = new System.Drawing.Point(79, 29);
            this.TextBoxRowEnd.Name = "TextBoxRowEnd";
            this.TextBoxRowEnd.Size = new System.Drawing.Size(57, 20);
            this.TextBoxRowEnd.TabIndex = 3;
            // 
            // LabelRowValue
            // 
            this.LabelRowValue.AutoSize = true;
            this.LabelRowValue.Location = new System.Drawing.Point(5, 54);
            this.LabelRowValue.Name = "LabelRowValue";
            this.LabelRowValue.Size = new System.Drawing.Size(37, 13);
            this.LabelRowValue.TabIndex = 4;
            this.LabelRowValue.Text = "Value:";
            // 
            // TextBoxRowValue
            // 
            this.TextBoxRowValue.Location = new System.Drawing.Point(5, 70);
            this.TextBoxRowValue.Name = "TextBoxRowValue";
            this.TextBoxRowValue.Size = new System.Drawing.Size(131, 20);
            this.TextBoxRowValue.TabIndex = 5;
            // 
            // CheckBoxUseReference
            // 
            this.CheckBoxUseReference.AutoSize = true;
            this.CheckBoxUseReference.Location = new System.Drawing.Point(8, 97);
            this.CheckBoxUseReference.Name = "CheckBoxUseReference";
            this.CheckBoxUseReference.Size = new System.Drawing.Size(98, 17);
            this.CheckBoxUseReference.TabIndex = 6;
            this.CheckBoxUseReference.Text = "Use Reference";
            this.CheckBoxUseReference.UseVisualStyleBackColor = true;
            // 
            // ListRows
            // 
            this.ListRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListRows.FormattingEnabled = true;
            this.ListRows.Location = new System.Drawing.Point(0, 0);
            this.ListRows.Name = "ListRows";
            this.ListRows.Size = new System.Drawing.Size(166, 285);
            this.ListRows.TabIndex = 0;
            // 
            // DTBLEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SplitDTBLEditor);
            this.Name = "DTBLEditor";
            this.Size = new System.Drawing.Size(310, 285);
            this.SplitDTBLEditor.Panel1.ResumeLayout(false);
            this.SplitDTBLEditor.Panel1.PerformLayout();
            this.SplitDTBLEditor.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitDTBLEditor)).EndInit();
            this.SplitDTBLEditor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitDTBLEditor;
        private System.Windows.Forms.ListBox ListRows;
        private System.Windows.Forms.ComboBox ComboReferenceType;
        private System.Windows.Forms.Button ButtonDeleteRow;
        private System.Windows.Forms.Button ButtonAddRow;
        private System.Windows.Forms.CheckBox CheckBoxUseReference;
        private System.Windows.Forms.TextBox TextBoxRowValue;
        private System.Windows.Forms.Label LabelRowValue;
        private System.Windows.Forms.TextBox TextBoxRowEnd;
        private System.Windows.Forms.Label LabelRowEnd;
        private System.Windows.Forms.TextBox TextBoxRowStart;
        private System.Windows.Forms.Label LabelRowStart;
        private System.Windows.Forms.Button ButtonEditReference;
    }
}
