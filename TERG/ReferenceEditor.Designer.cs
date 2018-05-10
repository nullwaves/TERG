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
            this.tabRINT = new System.Windows.Forms.TabPage();
            this.RINTbtnOK = new System.Windows.Forms.Button();
            this.RINTtextMinLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RINTtextMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RINTtextMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabRPAT = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RPATbtnOK = new System.Windows.Forms.Button();
            this.RPATbtnClear = new System.Windows.Forms.Button();
            this.RPATbtnRemove = new System.Windows.Forms.Button();
            this.RPATbtnAdd = new System.Windows.Forms.Button();
            this.RPATlistSelected = new System.Windows.Forms.ListBox();
            this.RPATlistPatterns = new System.Windows.Forms.ListBox();
            this.tabIPAT = new System.Windows.Forms.TabPage();
            this.IPATbtnOK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.IPATcomboPattern = new System.Windows.Forms.ComboBox();
            this.IPATtextMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IPATtextMin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IPATcheckRandom = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.tabPOOL.SuspendLayout();
            this.tabPATT.SuspendLayout();
            this.tabRINT.SuspendLayout();
            this.tabRPAT.SuspendLayout();
            this.tabIPAT.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPOOL);
            this.tabControl.Controls.Add(this.tabPATT);
            this.tabControl.Controls.Add(this.tabRINT);
            this.tabControl.Controls.Add(this.tabRPAT);
            this.tabControl.Controls.Add(this.tabIPAT);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(346, 314);
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
            this.tabPOOL.Size = new System.Drawing.Size(338, 288);
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
            this.tabPATT.Size = new System.Drawing.Size(338, 288);
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
            // tabRINT
            // 
            this.tabRINT.Controls.Add(this.RINTbtnOK);
            this.tabRINT.Controls.Add(this.RINTtextMinLength);
            this.tabRINT.Controls.Add(this.label5);
            this.tabRINT.Controls.Add(this.RINTtextMax);
            this.tabRINT.Controls.Add(this.label4);
            this.tabRINT.Controls.Add(this.RINTtextMin);
            this.tabRINT.Controls.Add(this.label3);
            this.tabRINT.Location = new System.Drawing.Point(4, 22);
            this.tabRINT.Name = "tabRINT";
            this.tabRINT.Size = new System.Drawing.Size(338, 288);
            this.tabRINT.TabIndex = 2;
            this.tabRINT.Text = "RINT";
            this.tabRINT.UseVisualStyleBackColor = true;
            // 
            // RINTbtnOK
            // 
            this.RINTbtnOK.Location = new System.Drawing.Point(148, 102);
            this.RINTbtnOK.Name = "RINTbtnOK";
            this.RINTbtnOK.Size = new System.Drawing.Size(75, 23);
            this.RINTbtnOK.TabIndex = 11;
            this.RINTbtnOK.Text = "OK";
            this.RINTbtnOK.UseVisualStyleBackColor = true;
            this.RINTbtnOK.Click += new System.EventHandler(this.RINTbtnOK_Click);
            // 
            // RINTtextMinLength
            // 
            this.RINTtextMinLength.Location = new System.Drawing.Point(185, 66);
            this.RINTtextMinLength.Name = "RINTtextMinLength";
            this.RINTtextMinLength.Size = new System.Drawing.Size(38, 20);
            this.RINTtextMinLength.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Minimum Length:";
            // 
            // RINTtextMax
            // 
            this.RINTtextMax.Location = new System.Drawing.Point(185, 40);
            this.RINTtextMax.Name = "RINTtextMax";
            this.RINTtextMax.Size = new System.Drawing.Size(38, 20);
            this.RINTtextMax.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Maximum Value:";
            // 
            // RINTtextMin
            // 
            this.RINTtextMin.Location = new System.Drawing.Point(185, 14);
            this.RINTtextMin.Name = "RINTtextMin";
            this.RINTtextMin.Size = new System.Drawing.Size(38, 20);
            this.RINTtextMin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Minimum Value:";
            // 
            // tabRPAT
            // 
            this.tabRPAT.Controls.Add(this.label7);
            this.tabRPAT.Controls.Add(this.label6);
            this.tabRPAT.Controls.Add(this.RPATbtnOK);
            this.tabRPAT.Controls.Add(this.RPATbtnClear);
            this.tabRPAT.Controls.Add(this.RPATbtnRemove);
            this.tabRPAT.Controls.Add(this.RPATbtnAdd);
            this.tabRPAT.Controls.Add(this.RPATlistSelected);
            this.tabRPAT.Controls.Add(this.RPATlistPatterns);
            this.tabRPAT.Location = new System.Drawing.Point(4, 22);
            this.tabRPAT.Name = "tabRPAT";
            this.tabRPAT.Size = new System.Drawing.Size(338, 288);
            this.tabRPAT.TabIndex = 3;
            this.tabRPAT.Text = "RPAT";
            this.tabRPAT.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Selected Patterns:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "All Patterns:";
            // 
            // RPATbtnOK
            // 
            this.RPATbtnOK.Location = new System.Drawing.Point(147, 218);
            this.RPATbtnOK.Name = "RPATbtnOK";
            this.RPATbtnOK.Size = new System.Drawing.Size(44, 23);
            this.RPATbtnOK.TabIndex = 9;
            this.RPATbtnOK.Text = "OK";
            this.RPATbtnOK.UseVisualStyleBackColor = true;
            this.RPATbtnOK.Click += new System.EventHandler(this.RPATbtnOK_Click);
            // 
            // RPATbtnClear
            // 
            this.RPATbtnClear.Location = new System.Drawing.Point(147, 137);
            this.RPATbtnClear.Name = "RPATbtnClear";
            this.RPATbtnClear.Size = new System.Drawing.Size(44, 23);
            this.RPATbtnClear.TabIndex = 8;
            this.RPATbtnClear.Text = "Clear";
            this.RPATbtnClear.UseVisualStyleBackColor = true;
            this.RPATbtnClear.Click += new System.EventHandler(this.RPATbtnClear_Click);
            // 
            // RPATbtnRemove
            // 
            this.RPATbtnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPATbtnRemove.Location = new System.Drawing.Point(147, 80);
            this.RPATbtnRemove.Name = "RPATbtnRemove";
            this.RPATbtnRemove.Size = new System.Drawing.Size(44, 23);
            this.RPATbtnRemove.TabIndex = 7;
            this.RPATbtnRemove.Text = "<";
            this.RPATbtnRemove.UseVisualStyleBackColor = true;
            this.RPATbtnRemove.Click += new System.EventHandler(this.RPATbtnRemove_Click);
            // 
            // RPATbtnAdd
            // 
            this.RPATbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RPATbtnAdd.Location = new System.Drawing.Point(147, 51);
            this.RPATbtnAdd.Name = "RPATbtnAdd";
            this.RPATbtnAdd.Size = new System.Drawing.Size(44, 23);
            this.RPATbtnAdd.TabIndex = 6;
            this.RPATbtnAdd.Text = ">";
            this.RPATbtnAdd.UseVisualStyleBackColor = true;
            this.RPATbtnAdd.Click += new System.EventHandler(this.RPATbtnAdd_Click);
            // 
            // RPATlistSelected
            // 
            this.RPATlistSelected.FormattingEnabled = true;
            this.RPATlistSelected.Location = new System.Drawing.Point(197, 29);
            this.RPATlistSelected.Name = "RPATlistSelected";
            this.RPATlistSelected.ScrollAlwaysVisible = true;
            this.RPATlistSelected.Size = new System.Drawing.Size(138, 251);
            this.RPATlistSelected.TabIndex = 5;
            // 
            // RPATlistPatterns
            // 
            this.RPATlistPatterns.FormattingEnabled = true;
            this.RPATlistPatterns.Location = new System.Drawing.Point(3, 29);
            this.RPATlistPatterns.Name = "RPATlistPatterns";
            this.RPATlistPatterns.ScrollAlwaysVisible = true;
            this.RPATlistPatterns.Size = new System.Drawing.Size(138, 251);
            this.RPATlistPatterns.TabIndex = 4;
            // 
            // tabIPAT
            // 
            this.tabIPAT.BackColor = System.Drawing.Color.Transparent;
            this.tabIPAT.Controls.Add(this.IPATcheckRandom);
            this.tabIPAT.Controls.Add(this.IPATtextMax);
            this.tabIPAT.Controls.Add(this.label9);
            this.tabIPAT.Controls.Add(this.IPATtextMin);
            this.tabIPAT.Controls.Add(this.label10);
            this.tabIPAT.Controls.Add(this.IPATbtnOK);
            this.tabIPAT.Controls.Add(this.label8);
            this.tabIPAT.Controls.Add(this.IPATcomboPattern);
            this.tabIPAT.Location = new System.Drawing.Point(4, 22);
            this.tabIPAT.Name = "tabIPAT";
            this.tabIPAT.Size = new System.Drawing.Size(338, 288);
            this.tabIPAT.TabIndex = 4;
            this.tabIPAT.Text = "IPAT";
            this.tabIPAT.UseVisualStyleBackColor = true;
            // 
            // IPATbtnOK
            // 
            this.IPATbtnOK.Location = new System.Drawing.Point(212, 136);
            this.IPATbtnOK.Name = "IPATbtnOK";
            this.IPATbtnOK.Size = new System.Drawing.Size(75, 23);
            this.IPATbtnOK.TabIndex = 8;
            this.IPATbtnOK.Text = "OK";
            this.IPATbtnOK.UseVisualStyleBackColor = true;
            this.IPATbtnOK.Click += new System.EventHandler(this.IPATbtnOK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pattern:";
            // 
            // IPATcomboPattern
            // 
            this.IPATcomboPattern.FormattingEnabled = true;
            this.IPATcomboPattern.Location = new System.Drawing.Point(81, 14);
            this.IPATcomboPattern.Name = "IPATcomboPattern";
            this.IPATcomboPattern.Size = new System.Drawing.Size(206, 21);
            this.IPATcomboPattern.TabIndex = 6;
            // 
            // IPATtextMax
            // 
            this.IPATtextMax.Enabled = false;
            this.IPATtextMax.Location = new System.Drawing.Point(196, 67);
            this.IPATtextMax.Name = "IPATtextMax";
            this.IPATtextMax.Size = new System.Drawing.Size(38, 20);
            this.IPATtextMax.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Maximum Value:";
            // 
            // IPATtextMin
            // 
            this.IPATtextMin.Location = new System.Drawing.Point(196, 41);
            this.IPATtextMin.Name = "IPATtextMin";
            this.IPATtextMin.Size = new System.Drawing.Size(38, 20);
            this.IPATtextMin.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(93, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Minimum Iterations:";
            // 
            // IPATcheckRandom
            // 
            this.IPATcheckRandom.AutoSize = true;
            this.IPATcheckRandom.Location = new System.Drawing.Point(155, 100);
            this.IPATcheckRandom.Name = "IPATcheckRandom";
            this.IPATcheckRandom.Size = new System.Drawing.Size(79, 17);
            this.IPATcheckRandom.TabIndex = 13;
            this.IPATcheckRandom.Text = "Randomize";
            this.IPATcheckRandom.UseVisualStyleBackColor = true;
            this.IPATcheckRandom.CheckedChanged += new System.EventHandler(this.IPATcheckRandom_CheckedChanged);
            // 
            // ReferenceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 339);
            this.Controls.Add(this.tabControl);
            this.Name = "ReferenceEditor";
            this.Text = "Reference Editor";
            this.tabControl.ResumeLayout(false);
            this.tabPOOL.ResumeLayout(false);
            this.tabPOOL.PerformLayout();
            this.tabPATT.ResumeLayout(false);
            this.tabPATT.PerformLayout();
            this.tabRINT.ResumeLayout(false);
            this.tabRINT.PerformLayout();
            this.tabRPAT.ResumeLayout(false);
            this.tabRPAT.PerformLayout();
            this.tabIPAT.ResumeLayout(false);
            this.tabIPAT.PerformLayout();
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
        private System.Windows.Forms.TabPage tabRINT;
        private System.Windows.Forms.TextBox RINTtextMinLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RINTtextMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RINTtextMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RINTbtnOK;
        private System.Windows.Forms.TabPage tabRPAT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RPATbtnOK;
        private System.Windows.Forms.Button RPATbtnClear;
        private System.Windows.Forms.Button RPATbtnRemove;
        private System.Windows.Forms.Button RPATbtnAdd;
        private System.Windows.Forms.ListBox RPATlistSelected;
        private System.Windows.Forms.ListBox RPATlistPatterns;
        private System.Windows.Forms.TabPage tabIPAT;
        private System.Windows.Forms.CheckBox IPATcheckRandom;
        private System.Windows.Forms.TextBox IPATtextMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IPATtextMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button IPATbtnOK;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox IPATcomboPattern;
    }
}