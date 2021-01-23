namespace BT3
{
    partial class frmMainBT3
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.grpPhepTinh = new System.Windows.Forms.GroupBox();
            this.rdoChia = new System.Windows.Forms.RadioButton();
            this.rdoNhan = new System.Windows.Forms.RadioButton();
            this.rdoTru = new System.Windows.Forms.RadioButton();
            this.rdoCong = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpPhepTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(126, 65);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(588, 22);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            this.txtNum1.Leave += new System.EventHandler(this.txtNum1_Leave);
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số 2";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(126, 119);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(588, 22);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum2_KeyPress);
            this.txtNum2.Leave += new System.EventHandler(this.txtNum2_Leave);
           
            // 
            // grpPhepTinh
            // 
            this.grpPhepTinh.Controls.Add(this.rdoChia);
            this.grpPhepTinh.Controls.Add(this.rdoNhan);
            this.grpPhepTinh.Controls.Add(this.rdoTru);
            this.grpPhepTinh.Controls.Add(this.rdoCong);
            this.grpPhepTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPhepTinh.Location = new System.Drawing.Point(49, 173);
            this.grpPhepTinh.Name = "grpPhepTinh";
            this.grpPhepTinh.Size = new System.Drawing.Size(665, 100);
            this.grpPhepTinh.TabIndex = 3;
            this.grpPhepTinh.TabStop = false;
            this.grpPhepTinh.Text = "Phép tính";
            // 
            // rdoChia
            // 
            this.rdoChia.AutoSize = true;
            this.rdoChia.Location = new System.Drawing.Point(576, 43);
            this.rdoChia.Name = "rdoChia";
            this.rdoChia.Size = new System.Drawing.Size(74, 29);
            this.rdoChia.TabIndex = 0;
            this.rdoChia.TabStop = true;
            this.rdoChia.Text = "Chia";
            this.rdoChia.UseVisualStyleBackColor = true;
            this.rdoChia.CheckedChanged += new System.EventHandler(this.rdoChia_CheckedChanged);
            // 
            // rdoNhan
            // 
            this.rdoNhan.AutoSize = true;
            this.rdoNhan.Location = new System.Drawing.Point(386, 43);
            this.rdoNhan.Name = "rdoNhan";
            this.rdoNhan.Size = new System.Drawing.Size(80, 29);
            this.rdoNhan.TabIndex = 0;
            this.rdoNhan.TabStop = true;
            this.rdoNhan.Text = "Nhân";
            this.rdoNhan.UseVisualStyleBackColor = true;
            this.rdoNhan.CheckedChanged += new System.EventHandler(this.rdoNhan_CheckedChanged);
            // 
            // rdoTru
            // 
            this.rdoTru.AutoSize = true;
            this.rdoTru.Location = new System.Drawing.Point(196, 43);
            this.rdoTru.Name = "rdoTru";
            this.rdoTru.Size = new System.Drawing.Size(63, 29);
            this.rdoTru.TabIndex = 0;
            this.rdoTru.TabStop = true;
            this.rdoTru.Text = "Trừ";
            this.rdoTru.UseVisualStyleBackColor = true;
            this.rdoTru.CheckedChanged += new System.EventHandler(this.rdoTru_CheckedChanged);
            // 
            // rdoCong
            // 
            this.rdoCong.AutoSize = true;
            this.rdoCong.Location = new System.Drawing.Point(6, 43);
            this.rdoCong.Name = "rdoCong";
            this.rdoCong.Size = new System.Drawing.Size(81, 29);
            this.rdoCong.TabIndex = 0;
            this.rdoCong.TabStop = true;
            this.rdoCong.Text = "Cộng";
            this.rdoCong.UseVisualStyleBackColor = true;
            this.rdoCong.CheckedChanged += new System.EventHandler(this.rdoCong_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(126, 326);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(588, 22);
            this.txtResult.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMainBT3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpPhepTinh);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmMainBT3";
            this.Text = "Phép tính";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainBT3_FormClosing);
            this.Load += new System.EventHandler(this.frmMainBT3_Load);
            this.grpPhepTinh.ResumeLayout(false);
            this.grpPhepTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.GroupBox grpPhepTinh;
        private System.Windows.Forms.RadioButton rdoChia;
        private System.Windows.Forms.RadioButton rdoNhan;
        private System.Windows.Forms.RadioButton rdoTru;
        private System.Windows.Forms.RadioButton rdoCong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

