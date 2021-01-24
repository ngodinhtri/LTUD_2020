
namespace OnTapCuoiKi
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.quanlykhoaMenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLýSinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanlykhoaMenuItems,
            this.quanLýSinhVienToolStripMenuItem,
            this.quảnLýMônHọcToolStripMenuItem,
            this.quảnLýĐiểmToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(1067, 24);
            this.menuMain.TabIndex = 0;
            // 
            // quanlykhoaMenuItems
            // 
            this.quanlykhoaMenuItems.Name = "quanlykhoaMenuItems";
            this.quanlykhoaMenuItems.Size = new System.Drawing.Size(90, 20);
            this.quanlykhoaMenuItems.Text = "Quản lý Khoa";
            this.quanlykhoaMenuItems.Click += new System.EventHandler(this.quanlykhoaMenuItems_Click);
            // 
            // quanLýSinhVienToolStripMenuItem
            // 
            this.quanLýSinhVienToolStripMenuItem.Name = "quanLýSinhVienToolStripMenuItem";
            this.quanLýSinhVienToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.quanLýSinhVienToolStripMenuItem.Text = "Quản Lý Sinh Viên";
            this.quanLýSinhVienToolStripMenuItem.Click += new System.EventHandler(this.quanLýSinhVienToolStripMenuItem_Click);
            // 
            // quảnLýMônHọcToolStripMenuItem
            // 
            this.quảnLýMônHọcToolStripMenuItem.Name = "quảnLýMônHọcToolStripMenuItem";
            this.quảnLýMônHọcToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.quảnLýMônHọcToolStripMenuItem.Text = "Quản lý Môn Học";
            // 
            // quảnLýĐiểmToolStripMenuItem
            // 
            this.quảnLýĐiểmToolStripMenuItem.Name = "quảnLýĐiểmToolStripMenuItem";
            this.quảnLýĐiểmToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.quảnLýĐiểmToolStripMenuItem.Text = "Quản lý Điểm";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem quanlykhoaMenuItems;
        private System.Windows.Forms.ToolStripMenuItem quanLýSinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐiểmToolStripMenuItem;
    }
}

