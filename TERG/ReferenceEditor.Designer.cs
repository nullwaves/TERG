namespace TERG
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPOOL = new System.Windows.Forms.TabPage();
            this.POOLbtnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.POOLcomboPool = new System.Windows.Forms.ComboBox();
            this.tabPATT = new System.Windows.Forms.TabPage();
            this.PATTbtnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PATTcomboPattern = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPOOL.SuspendLayout();
            this.tabPATT.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPOOL);
            this.tabControl.Controls.Add(this.tabPATT);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(298, 314);
            this.tabControl.TabIndex = 0;
            // 
            // tabPOOL
            // 
            this.tabPOOL.Controls.Add(this.POOLbtnOK);
            this.tabPOOL.Controls.Add(this.label1);
            this.tabPOOL.Controls.Add(this.POOLcomboPool);
            this.tabPOOL.Location = new System.Drawing.Point(4, 22);
            this.tabPOOL.Name = "tabPOOL";
            this.tabPOOL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPOOL.Size = new System.Drawing.Size(290, 288);
            this.tabPOOL.TabIndex = 0;
            this.tabPOOL.Text = "POOL";
            this.tabPOOL.UseVisualStyleBackColor = true;
            // 
            // POOLbtnOK
            // 
            this.POOLbtnOK.Location = new System.Drawing.Point(184, 59);
            this.POOLbtnOK.Name = "POOLbtnOK";
            this.POOLbtnOK.Size = new System.Drawing.Size(75, 23);
            this.POOLbtnOK.TabIndex = 2;
            this.POOLbtnOK.Text = "OK";
            this.POOLbtnOK.UseVisualStyleBackColor = true;
            this.POOLbtnOK.Click += new System.EventHandler(this.POOLbtnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pool:";
            // 
            // POOLcomboPool
            // 
            this.POOLcomboPool.FormattingEnabled = true;
            this.POOLcomboPool.Location = new System.Drawing.Point(53, 15);
            this.POOLcomboPool.Name = "POOLcomboPool";
            this.POOLcomboPool.Size = new System.Drawing.Size(206, 21);
            this.POOLcomboPool.TabIndex = 0;
            // 
            // tabPATT
            // 
            this.tabPATT.Controls.Add(this.PATTbtnOK);
            this.tabPATT.Controls.Add(this.label2);
            this.tabPATT.Controls.Add(this.PATTcomboPattern);
            this.tabPATT.Location = new System.Drawing.Point(4, 22);
            this.tabPATT.Name = "tabPATT";
            this.tabPATT.Padding = new System.Windows.Forms.Padding(3);
            this.tabPATT.Size = new System.Drawing.Size(290, 288);
            this.tabPATT.TabIndex = 1;
            this.tabPATT.Text = "PATT";
            this.tabPATT.UseVisualStyleBackColor = true;
            // 
            // PATTbtnOK
            // 
            this.PATTbtnOK.Location = new System.Drawing.Point(196, 61);
            this.PATTbtnOK.Name = "PATTbtnOK";
            this.PATTbtnOK.Size = new System.Drawing.Size(75, 23);
            this.PATTbtnOK.TabIndex = 5;
            this.PATTbtnOK.Text = "OK";
            this.PATTbtnOK.UseVisualStyleBackColor = true;
            this.PATTbtnOK.Click += new System.EventHandler(this.PATTbtnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pattern:";
            // 
            // PATTcomboPattern
            // 
            this.PATTcomboPattern.FormattingEnabled = true;
            this.PATTcomboPattern.Location = new System.Drawing.Point(65, 15);
            this.PATTcomboPattern.Name = "PATTcomboPattern";
            this.PATTcomboPattern.Size = new System.Drawing.Size(206, 21);
            this.PATTcomboPattern.TabIndex = 3;
            // 
            // ReferenceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 339);
            this.Controls.Add(this.tabControl);
            this.Name = "ReferenceEditor";
            this.Text = "Reference Editor";
            this.Load += new System.EventHandler(this.ReferenceEditor_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPOOL.ResumeLayout(false);
            this.tabPOOL.PerformLayout();
            this.tabPATT.ResumeLayout(false);
            this.tabPATT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPOOL;
        private System.Windows.Forms.Button POOLbtnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox POOLcomboPool;
        private System.Windows.Forms.TabPage tabPATT;
        private System.Windows.Forms.Button PATTbtnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PATTcomboPattern;
    }
}