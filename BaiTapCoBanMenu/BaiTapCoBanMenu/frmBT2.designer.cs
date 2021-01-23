namespace BaiTapCoBanMenu
{
    partial class frmBT2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(224, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập A:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(230, 115);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(426, 22);
            this.txtA.TabIndex = 0;
            this.txtA.Leave += new System.EventHandler(this.txtA_Leave);
            this.txtA.Validated += new System.EventHandler(this.txtA_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập B:";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(230, 191);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(426, 22);
            this.txtB.TabIndex = 1;
            this.txtB.Leave += new System.EventHandler(this.txtB_Leave);
            this.txtB.Validated += new System.EventHandler(this.txtB_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nghiệm:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(230, 255);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(426, 22);
            this.txtResult.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(552, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(108, 348);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(103, 32);
            this.btnSolve.TabIndex = 3;
            this.btnSolve.Text = "Giải";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(330, 348);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 32);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmBT2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBT2";
            this.Text = "BT2";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

