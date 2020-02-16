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
            this.IPATcheckRandom = new System.Windows.Forms.CheckBox();
            this.IPATtextMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IPATtextMin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.IPATbtnOK = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.IPATcomboPattern = new System.Windows.Forms.ComboBox();
            this.tabDTBL = new System.Windows.Forms.TabPage();
            this.splitDTBL = new System.Windows.Forms.SplitContainer();
            this.DTBLlstRows = new System.Windows.Forms.ListBox();
            this.DTBLbtnRemoveRow = new System.Windows.Forms.Button();
            this.DTBLbtnAddRow = new System.Windows.Forms.Button();
            this.DTBLbtnOk = new System.Windows.Forms.Button();
            this.DTBLbtnEditRowPattern = new System.Windows.Forms.Button();
            this.DTBLchkUsePattern = new System.Windows.Forms.CheckBox();
            this.DTBLtxtValue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DTBLtxtEnd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DTBLtxtStart = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DTBLcomboReferenceType = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPOOL.SuspendLayout();
            this.tabPATT.SuspendLayout();
            this.tabRINT.SuspendLayout();
            this.tabRPAT.SuspendLayout();
            this.tabIPAT.SuspendLayout();
            this.tabDTBL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDTBL)).BeginInit();
            this.splitDTBL.Panel1.SuspendLayout();
            this.splitDTBL.Panel2.SuspendLayout();
            this.splitDTBL.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPOOL);
            this.tabControl.Controls.Add(this.tabPATT);
            this.tabControl.Controls.Add(this.tabRINT);
            this.tabControl.Controls.Add(this.tabRPAT);
            this.tabControl.Controls.Add(this.tabIPAT);
            this.tabControl.Controls.Add(this.tabDTBL);
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
            // tabDTBL
            // 
            this.tabDTBL.Controls.Add(this.splitDTBL);
            this.tabDTBL.Location = new System.Drawing.Point(4, 22);
            this.tabDTBL.Name = "tabDTBL";
            this.tabDTBL.Padding = new System.Windows.Forms.Padding(3);
            this.tabDTBL.Size = new System.Drawing.Size(338, 288);
            this.tabDTBL.TabIndex = 5;
            this.tabDTBL.Text = "DTBL";
            this.tabDTBL.ToolTipText = "Distribution Table Reference";
            this.tabDTBL.UseVisualStyleBackColor = true;
            // 
            // splitDTBL
            // 
            this.splitDTBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitDTBL.Location = new System.Drawing.Point(3, 3);
            this.splitDTBL.Name = "splitDTBL";
            // 
            // splitDTBL.Panel1
            // 
            this.splitDTBL.Panel1.Controls.Add(this.DTBLlstRows);
            // 
            // splitDTBL.Panel2
            // 
            this.splitDTBL.Panel2.Controls.Add(this.DTBLcomboReferenceType);
            this.splitDTBL.Panel2.Controls.Add(this.DTBLbtnRemoveRow);
            this.splitDTBL.Panel2.Controls.Add(this.DTBLbtnAddRow);
            this.splitDTBL.Panel2.Controls.Add(this.DTBLbtnOk);
            this.splitDTBL.Panel2.Controls.Add(this.DTBLbtnEditRowPattern);
            this.splitDTBL.Panel2.Controls.Add(this.DTBLchkUsePattern);
            this.splitDTBL.Panel2.Controls.Add(this.DTBLtxtValue);
            this.splitDTBL.Panel2.Controls.Add(this.label13);
            this.splitDTBL.Panel2.Controls.Add(this.DTBLtxtEnd);
            this.splitDTBL.Panel2.Controls.Add(this.label12);
            this.splitDTBL.Panel2.Controls.Add(this.DTBLtxtStart);
            this.splitDTBL.Panel2.Controls.Add(this.label11);
            this.splitDTBL.Size = new System.Drawing.Size(332, 282);
            this.splitDTBL.SplitterDistance = 190;
            this.splitDTBL.TabIndex = 0;
            // 
            // DTBLlstRows
            // 
            this.DTBLlstRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTBLlstRows.FormattingEnabled = true;
            this.DTBLlstRows.Location = new System.Drawing.Point(0, 0);
            this.DTBLlstRows.Name = "DTBLlstRows";
            this.DTBLlstRows.Size = new System.Drawing.Size(190, 282);
            this.DTBLlstRows.TabIndex = 0;
            this.DTBLlstRows.SelectedIndexChanged += new System.EventHandler(this.DTBLlstRows_SelectedIndexChanged);
            // 
            // DTBLbtnRemoveRow
            // 
            this.DTBLbtnRemoveRow.Location = new System.Drawing.Point(77, 156);
            this.DTBLbtnRemoveRow.Name = "DTBLbtnRemoveRow";
            this.DTBLbtnRemoveRow.Size = new System.Drawing.Size(58, 23);
            this.DTBLbtnRemoveRow.TabIndex = 10;
            this.DTBLbtnRemoveRow.Text = "-";
            this.DTBLbtnRemoveRow.UseVisualStyleBackColor = true;
            // 
            // DTBLbtnAddRow
            // 
            this.DTBLbtnAddRow.Location = new System.Drawing.Point(3, 156);
            this.DTBLbtnAddRow.Name = "DTBLbtnAddRow";
            this.DTBLbtnAddRow.Size = new System.Drawing.Size(57, 23);
            this.DTBLbtnAddRow.TabIndex = 9;
            this.DTBLbtnAddRow.Text = "+";
            this.DTBLbtnAddRow.UseVisualStyleBackColor = true;
            this.DTBLbtnAddRow.Click += new System.EventHandler(this.DTBLbtnAddRow_Click);
            // 
            // DTBLbtnOk
            // 
            this.DTBLbtnOk.Location = new System.Drawing.Point(3, 256);
            this.DTBLbtnOk.Name = "DTBLbtnOk";
            this.DTBLbtnOk.Size = new System.Drawing.Size(131, 23);
            this.DTBLbtnOk.TabIndex = 8;
            this.DTBLbtnOk.Text = "OK";
            this.DTBLbtnOk.UseVisualStyleBackColor = true;
            // 
            // DTBLbtnEditRowPattern
            // 
            this.DTBLbtnEditRowPattern.Location = new System.Drawing.Point(87, 98);
            this.DTBLbtnEditRowPattern.Name = "DTBLbtnEditRowPattern";
            this.DTBLbtnEditRowPattern.Size = new System.Drawing.Size(47, 23);
            this.DTBLbtnEditRowPattern.TabIndex = 7;
            this.DTBLbtnEditRowPattern.Text = "Edit";
            this.DTBLbtnEditRowPattern.UseVisualStyleBackColor = true;
            this.DTBLbtnEditRowPattern.Click += new System.EventHandler(this.DTBLbtnEditRowPattern_Click);
            // 
            // DTBLchkUsePattern
            // 
            this.DTBLchkUsePattern.AutoSize = true;
            this.DTBLchkUsePattern.Location = new System.Drawing.Point(9, 102);
            this.DTBLchkUsePattern.Name = "DTBLchkUsePattern";
            this.DTBLchkUsePattern.Size = new System.Drawing.Size(82, 17);
            this.DTBLchkUsePattern.TabIndex = 6;
            this.DTBLchkUsePattern.Text = "Use Pattern";
            this.DTBLchkUsePattern.UseVisualStyleBackColor = true;
            this.DTBLchkUsePattern.CheckedChanged += new System.EventHandler(this.DTBLchkUsePattern_CheckedChanged);
            // 
            // DTBLtxtValue
            // 
            this.DTBLtxtValue.Location = new System.Drawing.Point(3, 75);
            this.DTBLtxtValue.Name = "DTBLtxtValue";
            this.DTBLtxtValue.Size = new System.Drawing.Size(131, 20);
            this.DTBLtxtValue.TabIndex = 5;
            this.DTBLtxtValue.Leave += new System.EventHandler(this.DTBLtxtValue_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Value:";
            // 
            // DTBLtxtEnd
            // 
            this.DTBLtxtEnd.Location = new System.Drawing.Point(77, 34);
            this.DTBLtxtEnd.Name = "DTBLtxtEnd";
            this.DTBLtxtEnd.Size = new System.Drawing.Size(57, 20);
            this.DTBLtxtEnd.TabIndex = 3;
            this.DTBLtxtEnd.Leave += new System.EventHandler(this.DTBLtxtEnd_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Row End:";
            // 
            // DTBLtxtStart
            // 
            this.DTBLtxtStart.Location = new System.Drawing.Point(77, 8);
            this.DTBLtxtStart.Name = "DTBLtxtStart";
            this.DTBLtxtStart.Size = new System.Drawing.Size(57, 20);
            this.DTBLtxtStart.TabIndex = 1;
            this.DTBLtxtStart.Leave += new System.EventHandler(this.DTBLtxtStart_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Row Start:";
            // 
            // DTBLcomboReferenceType
            // 
            this.DTBLcomboReferenceType.FormattingEnabled = true;
            this.DTBLcomboReferenceType.Location = new System.Drawing.Point(5, 125);
            this.DTBLcomboReferenceType.Name = "DTBLcomboReferenceType";
            this.DTBLcomboReferenceType.Size = new System.Drawing.Size(129, 21);
            this.DTBLcomboReferenceType.TabIndex = 11;
            // 
            // ReferenceEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 339);
            this.Controls.Add(this.tabControl);
            this.Name = "ReferenceEditor";
            this.Text = "Reference Editor";
            this.Load += new System.EventHandler(this.ReferenceEditor_Load);
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
            this.tabDTBL.ResumeLayout(false);
            this.splitDTBL.Panel1.ResumeLayout(false);
            this.splitDTBL.Panel2.ResumeLayout(false);
            this.splitDTBL.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDTBL)).EndInit();
            this.splitDTBL.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabDTBL;
        private System.Windows.Forms.SplitContainer splitDTBL;
        private System.Windows.Forms.ListBox DTBLlstRows;
        private System.Windows.Forms.Button DTBLbtnEditRowPattern;
        private System.Windows.Forms.CheckBox DTBLchkUsePattern;
        private System.Windows.Forms.TextBox DTBLtxtValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DTBLtxtEnd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DTBLtxtStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button DTBLbtnOk;
        private System.Windows.Forms.Button DTBLbtnRemoveRow;
        private System.Windows.Forms.Button DTBLbtnAddRow;
        private System.Windows.Forms.ComboBox DTBLcomboReferenceType;
    }
}