namespace TERG
{
    partial class BaseEditor
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
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.btnInsertReference = new System.Windows.Forms.Button();
            this.btnRefreshPool = new System.Windows.Forms.Button();
            this.btnSavePool = new System.Windows.Forms.Button();
            this.lblPoolName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBase
            // 
            this.textBoxBase.AcceptsReturn = true;
            this.textBoxBase.AcceptsTab = true;
            this.textBoxBase.Location = new System.Drawing.Point(12, 38);
            this.textBoxBase.Multiline = true;
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(496, 296);
            this.textBoxBase.TabIndex = 0;
            // 
            // btnInsertReference
            // 
            this.btnInsertReference.Image = global::TERG.Properties.Resources.page_code;
            this.btnInsertReference.Location = new System.Drawing.Point(479, 9);
            this.btnInsertReference.Name = "btnInsertReference";
            this.btnInsertReference.Size = new System.Drawing.Size(29, 23);
            this.btnInsertReference.TabIndex = 7;
            this.btnInsertReference.UseVisualStyleBackColor = true;
            this.btnInsertReference.Click += new System.EventHandler(this.btnInsertReference_Click);
            // 
            // btnRefreshPool
            // 
            this.btnRefreshPool.Image = global::TERG.Properties.Resources.action_refresh;
            this.btnRefreshPool.Location = new System.Drawing.Point(444, 9);
            this.btnRefreshPool.Name = "btnRefreshPool";
            this.btnRefreshPool.Size = new System.Drawing.Size(29, 23);
            this.btnRefreshPool.TabIndex = 6;
            this.btnRefreshPool.UseVisualStyleBackColor = true;
            this.btnRefreshPool.Click += new System.EventHandler(this.btnRefreshPool_Click);
            // 
            // btnSavePool
            // 
            this.btnSavePool.Image = global::TERG.Properties.Resources.action_save;
            this.btnSavePool.Location = new System.Drawing.Point(409, 9);
            this.btnSavePool.Name = "btnSavePool";
            this.btnSavePool.Size = new System.Drawing.Size(29, 23);
            this.btnSavePool.TabIndex = 5;
            this.btnSavePool.UseVisualStyleBackColor = true;
            this.btnSavePool.Click += new System.EventHandler(this.btnSavePool_Click);
            // 
            // lblPoolName
            // 
            this.lblPoolName.AutoSize = true;
            this.lblPoolName.Location = new System.Drawing.Point(12, 22);
            this.lblPoolName.Name = "lblPoolName";
            this.lblPoolName.Size = new System.Drawing.Size(40, 13);
            this.lblPoolName.TabIndex = 8;
            this.lblPoolName.Text = "Pool: []";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(496, 296);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BaseEditor
            // 
            this.AcceptButton = this.btnSavePool;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 342);
            this.Controls.Add(this.lblPoolName);
            this.Controls.Add(this.btnInsertReference);
            this.Controls.Add(this.btnRefreshPool);
            this.Controls.Add(this.btnSavePool);
            this.Controls.Add(this.textBoxBase);
            this.Name = "BaseEditor";
            this.Text = "BaseEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.Button btnRefreshPool;
        private System.Windows.Forms.Button btnSavePool;
        private System.Windows.Forms.Button btnInsertReference;
        private System.Windows.Forms.Label lblPoolName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}