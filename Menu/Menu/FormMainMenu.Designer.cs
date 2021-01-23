namespace Menu
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuFormMain = new System.Windows.Forms.MenuStrip();
            this.menuBT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBT1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBT2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBT3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBT4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFormMain
            // 
            this.menuFormMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuFormMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBT});
            this.menuFormMain.Location = new System.Drawing.Point(0, 0);
            this.menuFormMain.Name = "menuFormMain";
            this.menuFormMain.Size = new System.Drawing.Size(800, 28);
            this.menuFormMain.TabIndex = 0;
            this.menuFormMain.Text = "menuStrip1";
            // 
            // menuBT
            // 
            this.menuBT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBT1,
            this.menuBT2,
            this.menuBT3,
            this.menuBT4});
            this.menuBT.Name = "menuBT";
            this.menuBT.Size = new System.Drawing.Size(142, 24);
            this.menuBT.Text = "Danh sách bài tập";
            // 
            // menuBT1
            // 
            this.menuBT1.Name = "menuBT1";
            this.menuBT1.Size = new System.Drawing.Size(116, 26);
            this.menuBT1.Text = "BT1";
            this.menuBT1.Click += new System.EventHandler(this.menuBT1_Click);
            // 
            // menuBT2
            // 
            this.menuBT2.Name = "menuBT2";
            this.menuBT2.Size = new System.Drawing.Size(116, 26);
            this.menuBT2.Text = "BT2";
            this.menuBT2.Click += new System.EventHandler(this.menuBT2_Click);
            // 
            // menuBT3
            // 
            this.menuBT3.Name = "menuBT3";
            this.menuBT3.Size = new System.Drawing.Size(116, 26);
            this.menuBT3.Text = "BT3";
            // 
            // menuBT4
            // 
            this.menuBT4.Name = "menuBT4";
            this.menuBT4.Size = new System.Drawing.Size(116, 26);
            this.menuBT4.Text = "BT4";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuFormMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuFormMain;
            this.Name = "frmMain";
            this.Text = "Bài tập phần 2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuFormMain.ResumeLayout(false);
            this.menuFormMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuFormMain;
        private System.Windows.Forms.ToolStripMenuItem menuBT;
        private System.Windows.Forms.ToolStripMenuItem menuBT2;
        private System.Windows.Forms.ToolStripMenuItem menuBT3;
        private System.Windows.Forms.ToolStripMenuItem menuBT4;
        private System.Windows.Forms.ToolStripMenuItem menuBT1;
    }
}

