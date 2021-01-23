namespace BT9
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grpA = new System.Windows.Forms.GroupBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.grpB = new System.Windows.Forms.GroupBox();
            this.lstB = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTransportLR = new System.Windows.Forms.Button();
            this.btnTransportAllLR = new System.Windows.Forms.Button();
            this.btnTransportRL = new System.Windows.Forms.Button();
            this.btnTransportAllRL = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpA.SuspendLayout();
            this.grpB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên: ";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(119, 19);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(477, 28);
            this.txtInput.TabIndex = 1;
            // 
            // grpA
            // 
            this.grpA.Controls.Add(this.lstA);
            this.grpA.Location = new System.Drawing.Point(16, 79);
            this.grpA.Name = "grpA";
            this.grpA.Size = new System.Drawing.Size(235, 312);
            this.grpA.TabIndex = 2;
            this.grpA.TabStop = false;
            this.grpA.Text = "Lớp A";
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.ItemHeight = 16;
            this.lstA.Location = new System.Drawing.Point(6, 32);
            this.lstA.Name = "lstA";
            this.lstA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstA.Size = new System.Drawing.Size(223, 260);
            this.lstA.TabIndex = 0;
            // 
            // grpB
            // 
            this.grpB.Controls.Add(this.lstB);
            this.grpB.Location = new System.Drawing.Point(553, 79);
            this.grpB.Name = "grpB";
            this.grpB.Size = new System.Drawing.Size(235, 312);
            this.grpB.TabIndex = 3;
            this.grpB.TabStop = false;
            this.grpB.Text = "Lớp B";
            // 
            // lstB
            // 
            this.lstB.FormattingEnabled = true;
            this.lstB.ItemHeight = 16;
            this.lstB.Location = new System.Drawing.Point(6, 32);
            this.lstB.Name = "lstB";
            this.lstB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstB.Size = new System.Drawing.Size(223, 260);
            this.lstB.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(602, 17);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(186, 33);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTransportLR
            // 
            this.btnTransportLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransportLR.Location = new System.Drawing.Point(308, 111);
            this.btnTransportLR.Name = "btnTransportLR";
            this.btnTransportLR.Size = new System.Drawing.Size(186, 33);
            this.btnTransportLR.TabIndex = 4;
            this.btnTransportLR.Text = ">";
            this.btnTransportLR.UseVisualStyleBackColor = true;
            this.btnTransportLR.Click += new System.EventHandler(this.btnTransportLR_Click);
            // 
            // btnTransportAllLR
            // 
            this.btnTransportAllLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransportAllLR.Location = new System.Drawing.Point(308, 186);
            this.btnTransportAllLR.Name = "btnTransportAllLR";
            this.btnTransportAllLR.Size = new System.Drawing.Size(186, 33);
            this.btnTransportAllLR.TabIndex = 4;
            this.btnTransportAllLR.Text = ">>";
            this.btnTransportAllLR.UseVisualStyleBackColor = true;
            this.btnTransportAllLR.Click += new System.EventHandler(this.btnTransportAllLR_Click);
            // 
            // btnTransportRL
            // 
            this.btnTransportRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransportRL.Location = new System.Drawing.Point(308, 261);
            this.btnTransportRL.Name = "btnTransportRL";
            this.btnTransportRL.Size = new System.Drawing.Size(186, 33);
            this.btnTransportRL.TabIndex = 4;
            this.btnTransportRL.Text = "<";
            this.btnTransportRL.UseVisualStyleBackColor = true;
            this.btnTransportRL.Click += new System.EventHandler(this.btnTransportRL_Click);
            // 
            // btnTransportAllRL
            // 
            this.btnTransportAllRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransportAllRL.Location = new System.Drawing.Point(308, 336);
            this.btnTransportAllRL.Name = "btnTransportAllRL";
            this.btnTransportAllRL.Size = new System.Drawing.Size(186, 33);
            this.btnTransportAllRL.TabIndex = 4;
            this.btnTransportAllRL.Text = "<<";
            this.btnTransportAllRL.UseVisualStyleBackColor = true;
            this.btnTransportAllRL.Click += new System.EventHandler(this.btnTransportAllRL_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(22, 405);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(186, 33);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(602, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(186, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Kết thúc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransportAllLR);
            this.Controls.Add(this.btnTransportAllRL);
            this.Controls.Add(this.btnTransportRL);
            this.Controls.Add(this.btnTransportLR);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpB);
            this.Controls.Add(this.grpA);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Danh sách SV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.grpA.ResumeLayout(false);
            this.grpB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox grpA;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.GroupBox grpB;
        private System.Windows.Forms.ListBox lstB;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTransportLR;
        private System.Windows.Forms.Button btnTransportAllLR;
        private System.Windows.Forms.Button btnTransportRL;
        private System.Windows.Forms.Button btnTransportAllRL;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
    }
}

