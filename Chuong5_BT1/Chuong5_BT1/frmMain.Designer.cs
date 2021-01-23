namespace Chuong5_BT1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.khoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ketQuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timKiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khoaToolStripMenuItem,
            this.monHocToolStripMenuItem,
            this.sinhVienToolStripMenuItem,
            this.ketQuaToolStripMenuItem,
            this.timKiemToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 124);
            // 
            // khoaToolStripMenuItem
            // 
            this.khoaToolStripMenuItem.Name = "khoaToolStripMenuItem";
            this.khoaToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.khoaToolStripMenuItem.Text = "Khoa";
            // 
            // monHocToolStripMenuItem
            // 
            this.monHocToolStripMenuItem.Name = "monHocToolStripMenuItem";
            this.monHocToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.monHocToolStripMenuItem.Text = "Mon Hoc";
            // 
            // sinhVienToolStripMenuItem
            // 
            this.sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            this.sinhVienToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.sinhVienToolStripMenuItem.Text = "Sinh Vien";
            // 
            // ketQuaToolStripMenuItem
            // 
            this.ketQuaToolStripMenuItem.Name = "ketQuaToolStripMenuItem";
            this.ketQuaToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.ketQuaToolStripMenuItem.Text = "Ket Qua";
            // 
            // timKiemToolStripMenuItem
            // 
            this.timKiemToolStripMenuItem.Name = "timKiemToolStripMenuItem";
            this.timKiemToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.timKiemToolStripMenuItem.Text = "Tim Kiem";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Form Main";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem khoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ketQuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timKiemToolStripMenuItem;
    }
}

