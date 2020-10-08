namespace TERG.Forms.Controls
{
    partial class PoolMenu
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
            this.PoolMenuGroup = new System.Windows.Forms.GroupBox();
            this.PoolMenuSplit = new System.Windows.Forms.SplitContainer();
            this.ListboxPools = new System.Windows.Forms.ListBox();
            this.PoolMenuGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PoolMenuSplit)).BeginInit();
            this.PoolMenuSplit.Panel1.SuspendLayout();
            this.PoolMenuSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // PoolMenuGroup
            // 
            this.PoolMenuGroup.Controls.Add(this.PoolMenuSplit);
            this.PoolMenuGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PoolMenuGroup.Location = new System.Drawing.Point(0, 0);
            this.PoolMenuGroup.Name = "PoolMenuGroup";
            this.PoolMenuGroup.Size = new System.Drawing.Size(356, 328);
            this.PoolMenuGroup.TabIndex = 0;
            this.PoolMenuGroup.TabStop = false;
            this.PoolMenuGroup.Text = "Pools";
            // 
            // PoolMenuSplit
            // 
            this.PoolMenuSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PoolMenuSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.PoolMenuSplit.Location = new System.Drawing.Point(3, 16);
            this.PoolMenuSplit.Name = "PoolMenuSplit";
            // 
            // PoolMenuSplit.Panel1
            // 
            this.PoolMenuSplit.Panel1.Controls.Add(this.ListboxPools);
            this.PoolMenuSplit.Panel1MinSize = 150;
            this.PoolMenuSplit.Size = new System.Drawing.Size(350, 309);
            this.PoolMenuSplit.SplitterDistance = 150;
            this.PoolMenuSplit.TabIndex = 0;
            // 
            // ListboxPools
            // 
            this.ListboxPools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListboxPools.FormattingEnabled = true;
            this.ListboxPools.Location = new System.Drawing.Point(0, 0);
            this.ListboxPools.Name = "ListboxPools";
            this.ListboxPools.Size = new System.Drawing.Size(150, 309);
            this.ListboxPools.TabIndex = 0;
            // 
            // PoolMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PoolMenuGroup);
            this.Name = "PoolMenu";
            this.Size = new System.Drawing.Size(356, 328);
            this.PoolMenuGroup.ResumeLayout(false);
            this.PoolMenuSplit.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PoolMenuSplit)).EndInit();
            this.PoolMenuSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PoolMenuGroup;
        private System.Windows.Forms.SplitContainer PoolMenuSplit;
        private System.Windows.Forms.ListBox ListboxPools;
    }
}
