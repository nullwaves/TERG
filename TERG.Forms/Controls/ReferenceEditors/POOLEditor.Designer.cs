namespace TERG.Forms.Controls.ReferenceEditors
{
    partial class POOLEditor
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
            this.LabelPool = new System.Windows.Forms.Label();
            this.ComboPools = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LabelPool
            // 
            this.LabelPool.AutoSize = true;
            this.LabelPool.Location = new System.Drawing.Point(3, 7);
            this.LabelPool.Name = "LabelPool";
            this.LabelPool.Size = new System.Drawing.Size(31, 13);
            this.LabelPool.TabIndex = 0;
            this.LabelPool.Text = "Pool:";
            // 
            // ComboPools
            // 
            this.ComboPools.FormattingEnabled = true;
            this.ComboPools.Location = new System.Drawing.Point(41, 4);
            this.ComboPools.Name = "ComboPools";
            this.ComboPools.Size = new System.Drawing.Size(131, 21);
            this.ComboPools.TabIndex = 1;
            // 
            // POOLEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ComboPools);
            this.Controls.Add(this.LabelPool);
            this.Name = "POOLEditor";
            this.Size = new System.Drawing.Size(172, 34);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPool;
        private System.Windows.Forms.ComboBox ComboPools;
    }
}
