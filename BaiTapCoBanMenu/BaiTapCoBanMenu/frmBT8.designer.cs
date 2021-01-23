namespace BaiTapCoBanMenu
{
    partial class frmBT8
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.grpListBox = new System.Windows.Forms.GroupBox();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOddNumber = new System.Windows.Forms.Button();
            this.btnEvenNumber = new System.Windows.Forms.Button();
            this.btnReplaceSqrt = new System.Windows.Forms.Button();
            this.btnPlusTwo = new System.Windows.Forms.Button();
            this.btnDelSelected = new System.Windows.Forms.Button();
            this.btnDelHeadTail = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpListBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Coral;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(574, 39);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "LISTBOX";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpListBox
            // 
            this.grpListBox.Controls.Add(this.lstResult);
            this.grpListBox.Controls.Add(this.btnInput);
            this.grpListBox.Controls.Add(this.txtInput);
            this.grpListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpListBox.Location = new System.Drawing.Point(26, 76);
            this.grpListBox.Name = "grpListBox";
            this.grpListBox.Size = new System.Drawing.Size(200, 344);
            this.grpListBox.TabIndex = 1;
            this.grpListBox.TabStop = false;
            this.grpListBox.Text = "ListBox";
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 25;
            this.lstResult.Location = new System.Drawing.Point(7, 107);
            this.lstResult.Name = "lstResult";
            this.lstResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstResult.Size = new System.Drawing.Size(187, 229);
            this.lstResult.TabIndex = 2;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(6, 65);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(188, 35);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "Nhập";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 29);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(188, 30);
            this.txtInput.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOddNumber);
            this.groupBox1.Controls.Add(this.btnEvenNumber);
            this.groupBox1.Controls.Add(this.btnReplaceSqrt);
            this.groupBox1.Controls.Add(this.btnPlusTwo);
            this.groupBox1.Controls.Add(this.btnDelSelected);
            this.groupBox1.Controls.Add(this.btnDelHeadTail);
            this.groupBox1.Controls.Add(this.btnSum);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(244, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 344);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xử lý ListBox";
            // 
            // btnOddNumber
            // 
            this.btnOddNumber.Location = new System.Drawing.Point(6, 299);
            this.btnOddNumber.Name = "btnOddNumber";
            this.btnOddNumber.Size = new System.Drawing.Size(306, 35);
            this.btnOddNumber.TabIndex = 1;
            this.btnOddNumber.Text = "Chọn số lẻ";
            this.btnOddNumber.UseVisualStyleBackColor = true;
            this.btnOddNumber.Click += new System.EventHandler(this.btnOddNumber_Click);
            // 
            // btnEvenNumber
            // 
            this.btnEvenNumber.Location = new System.Drawing.Point(6, 254);
            this.btnEvenNumber.Name = "btnEvenNumber";
            this.btnEvenNumber.Size = new System.Drawing.Size(306, 35);
            this.btnEvenNumber.TabIndex = 1;
            this.btnEvenNumber.Text = "Chọn số chẵn";
            this.btnEvenNumber.UseVisualStyleBackColor = true;
            this.btnEvenNumber.Click += new System.EventHandler(this.btnEvenNumber_Click);
            // 
            // btnReplaceSqrt
            // 
            this.btnReplaceSqrt.Location = new System.Drawing.Point(6, 209);
            this.btnReplaceSqrt.Name = "btnReplaceSqrt";
            this.btnReplaceSqrt.Size = new System.Drawing.Size(306, 35);
            this.btnReplaceSqrt.TabIndex = 1;
            this.btnReplaceSqrt.Text = "Thay bằng bình phương";
            this.btnReplaceSqrt.UseVisualStyleBackColor = true;
            this.btnReplaceSqrt.Click += new System.EventHandler(this.btnReplaceSqrt_Click);
            // 
            // btnPlusTwo
            // 
            this.btnPlusTwo.Location = new System.Drawing.Point(6, 164);
            this.btnPlusTwo.Name = "btnPlusTwo";
            this.btnPlusTwo.Size = new System.Drawing.Size(306, 35);
            this.btnPlusTwo.TabIndex = 1;
            this.btnPlusTwo.Text = "Tăng mỗi phần tử lên 2";
            this.btnPlusTwo.UseVisualStyleBackColor = true;
            this.btnPlusTwo.Click += new System.EventHandler(this.btnPlusTwo_Click);
            // 
            // btnDelSelected
            // 
            this.btnDelSelected.Location = new System.Drawing.Point(6, 119);
            this.btnDelSelected.Name = "btnDelSelected";
            this.btnDelSelected.Size = new System.Drawing.Size(306, 35);
            this.btnDelSelected.TabIndex = 1;
            this.btnDelSelected.Text = "Xóa các phần tử đang chọn";
            this.btnDelSelected.UseVisualStyleBackColor = true;
            this.btnDelSelected.Click += new System.EventHandler(this.btnDelSelected_Click);
            // 
            // btnDelHeadTail
            // 
            this.btnDelHeadTail.Location = new System.Drawing.Point(6, 74);
            this.btnDelHeadTail.Name = "btnDelHeadTail";
            this.btnDelHeadTail.Size = new System.Drawing.Size(306, 35);
            this.btnDelHeadTail.TabIndex = 1;
            this.btnDelHeadTail.Text = "Xóa các phần tử đầu và cuối";
            this.btnDelHeadTail.UseVisualStyleBackColor = true;
            this.btnDelHeadTail.Click += new System.EventHandler(this.btnDelHeadTail_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(6, 29);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(306, 35);
            this.btnSum.TabIndex = 1;
            this.btnSum.Text = "Tổng các phần tử trong List";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(33, 426);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(523, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "KẾT THÚC";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBT8
            // 
            this.AcceptButton = this.btnInput;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(574, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpListBox);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmBT8";
            this.Text = "BT8";
            this.grpListBox.ResumeLayout(false);
            this.grpListBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox grpListBox;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOddNumber;
        private System.Windows.Forms.Button btnEvenNumber;
        private System.Windows.Forms.Button btnReplaceSqrt;
        private System.Windows.Forms.Button btnPlusTwo;
        private System.Windows.Forms.Button btnDelSelected;
        private System.Windows.Forms.Button btnDelHeadTail;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnExit;
    }
}

