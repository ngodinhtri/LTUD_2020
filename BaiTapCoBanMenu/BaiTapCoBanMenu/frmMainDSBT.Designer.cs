namespace BaiTapCoBanMenu
{
    partial class frmMainDSBT
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBT1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBT2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBT3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBT4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBT8 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBT9 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBT10 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuMain
            // 
            this.menuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBT1,
            this.menuBT2,
            this.menuBT3,
            this.menuBT4,
            this.menuBT8,
            this.menuBT9,
            this.menuBT10});
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(142, 24);
            this.menuMain.Text = "Danh sách bài tập";
            // 
            // menuBT1
            // 
            this.menuBT1.Name = "menuBT1";
            this.menuBT1.Size = new System.Drawing.Size(224, 26);
            this.menuBT1.Text = "BT1";
            this.menuBT1.Click += new System.EventHandler(this.menuBT1_Click);
            // 
            // menuBT2
            // 
            this.menuBT2.Name = "menuBT2";
            this.menuBT2.Size = new System.Drawing.Size(224, 26);
            this.menuBT2.Text = "BT2";
            this.menuBT2.Click += new System.EventHandler(this.bT2ToolStripMenuItem_Click);
            // 
            // menuBT3
            // 
            this.menuBT3.Name = "menuBT3";
            this.menuBT3.Size = new System.Drawing.Size(224, 26);
            this.menuBT3.Text = "BT3";
            this.menuBT3.Click += new System.EventHandler(this.bT3ToolStripMenuItem_Click);
            // 
            // menuBT4
            // 
            this.menuBT4.Name = "menuBT4";
            this.menuBT4.Size = new System.Drawing.Size(224, 26);
            this.menuBT4.Text = "BT4";
            this.menuBT4.Click += new System.EventHandler(this.menuBT4_Click);
            // 
            // menuBT8
            // 
            this.menuBT8.Name = "menuBT8";
            this.menuBT8.Size = new System.Drawing.Size(224, 26);
            this.menuBT8.Text = "BT8";
            this.menuBT8.Click += new System.EventHandler(this.menuBT8_Click);
            // 
            // menuBT9
            // 
            this.menuBT9.Name = "menuBT9";
            this.menuBT9.Size = new System.Drawing.Size(224, 26);
            this.menuBT9.Text = "BT9";
            this.menuBT9.Click += new System.EventHandler(this.menuBT9_Click);
            // 
            // menuBT10
            // 
            this.menuBT10.Name = "menuBT10";
            this.menuBT10.Size = new System.Drawing.Size(224, 26);
            this.menuBT10.Text = "BT10";
            this.menuBT10.Click += new System.EventHandler(this.menuBT10_Click);
            // 
            // frmMainDSBT
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainDSBT";
            this.Text = "Bài tập Menu cơ bản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuBT1;
        private System.Windows.Forms.ToolStripMenuItem menuBT2;
        private System.Windows.Forms.ToolStripMenuItem menuBT3;
        private System.Windows.Forms.ToolStripMenuItem menuBT4;
        private System.Windows.Forms.ToolStripMenuItem menuBT8;
        private System.Windows.Forms.ToolStripMenuItem menuBT9;
        private System.Windows.Forms.ToolStripMenuItem menuBT10;
    }
}

