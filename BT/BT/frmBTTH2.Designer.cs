namespace BT
{
    partial class frmBTTH2
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
            this.menuBT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBT1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBT2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuBT
            // 
            this.menuBT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBT1,
            this.menuBT2});
            this.menuBT.Name = "menuBT";
            this.menuBT.Size = new System.Drawing.Size(134, 20);
            this.menuBT.Text = "Danh sách các bài tập";
            // 
            // menuBT1
            // 
            this.menuBT1.Name = "menuBT1";
            this.menuBT1.Size = new System.Drawing.Size(152, 22);
            this.menuBT1.Text = "BT1";
            this.menuBT1.Click += new System.EventHandler(this.menuBT1_Click);
            // 
            // menuBT2
            // 
            this.menuBT2.Name = "menuBT2";
            this.menuBT2.Size = new System.Drawing.Size(152, 22);
            this.menuBT2.Text = "BT2";
            this.menuBT2.Click += new System.EventHandler(this.menuBT2_Click);
            // 
            // frmBTTH2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBTTH2";
            this.Text = "Bài tập thực hành 2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBTTH2_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuBT;
        private System.Windows.Forms.ToolStripMenuItem menuBT1;
        private System.Windows.Forms.ToolStripMenuItem menuBT2;
    }
}

