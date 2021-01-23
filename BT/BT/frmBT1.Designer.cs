namespace BT
{
    partial class frmBT1
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
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbxQualification = new System.Windows.Forms.ListBox();
            this.cbxCountry = new System.Windows.Forms.ComboBox();
            this.lbxCity = new System.Windows.Forms.ListBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtxtDateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.dtpDateOfJoinning = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeName.Location = new System.Drawing.Point(37, 14);
            this.lbEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(129, 20);
            this.lbEmployeeName.TabIndex = 0;
            this.lbEmployeeName.Text = "Employee Name:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(174, 11);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(244, 26);
            this.txtEmployeeName.TabIndex = 0;
            this.txtEmployeeName.Leave += new System.EventHandler(this.txtEmployeeName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date of Birth:\r\n(mm/dd/yyyy)";
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPhone.Location = new System.Drawing.Point(174, 423);
            this.mtxtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxtPhone.Mask = "000-0000000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.PromptChar = '-';
            this.mtxtPhone.Size = new System.Drawing.Size(244, 26);
            this.mtxtPhone.TabIndex = 6;
            this.mtxtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtPhone_KeyPress);
            this.mtxtPhone.Leave += new System.EventHandler(this.mtxtPhone_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(174, 109);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(244, 26);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // lbxQualification
            // 
            this.lbxQualification.FormattingEnabled = true;
            this.lbxQualification.ItemHeight = 20;
            this.lbxQualification.Items.AddRange(new object[] {
            "University",
            "Master",
            "Ph D"});
            this.lbxQualification.Location = new System.Drawing.Point(174, 316);
            this.lbxQualification.Name = "lbxQualification";
            this.lbxQualification.Size = new System.Drawing.Size(244, 84);
            this.lbxQualification.TabIndex = 5;
            this.lbxQualification.Leave += new System.EventHandler(this.lbxQualification_Leave);
            // 
            // cbxCountry
            // 
            this.cbxCountry.FormattingEnabled = true;
            this.cbxCountry.Items.AddRange(new object[] {
            "Viet Nam",
            "Thailand"});
            this.cbxCountry.Location = new System.Drawing.Point(174, 158);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Size = new System.Drawing.Size(244, 28);
            this.cbxCountry.TabIndex = 3;
            this.cbxCountry.TextChanged += new System.EventHandler(this.cbxCountry_TextChanged);
            this.cbxCountry.Leave += new System.EventHandler(this.cbxCountry_Leave);
            // 
            // lbxCity
            // 
            this.lbxCity.FormattingEnabled = true;
            this.lbxCity.ItemHeight = 20;
            this.lbxCity.Location = new System.Drawing.Point(174, 209);
            this.lbxCity.Name = "lbxCity";
            this.lbxCity.Size = new System.Drawing.Size(244, 84);
            this.lbxCity.TabIndex = 4;
            this.lbxCity.Leave += new System.EventHandler(this.lbxCity_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(174, 472);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(244, 26);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // mtxtDateOfBirth
            // 
            this.mtxtDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtDateOfBirth.Location = new System.Drawing.Point(174, 60);
            this.mtxtDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxtDateOfBirth.Mask = "00/00/0000";
            this.mtxtDateOfBirth.Name = "mtxtDateOfBirth";
            this.mtxtDateOfBirth.PromptChar = '-';
            this.mtxtDateOfBirth.Size = new System.Drawing.Size(244, 26);
            this.mtxtDateOfBirth.TabIndex = 1;
            this.mtxtDateOfBirth.ValidatingType = typeof(System.DateTime);
            this.mtxtDateOfBirth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtDateOfBirth_KeyPress);
            this.mtxtDateOfBirth.Leave += new System.EventHandler(this.mtxtDateOfBirth_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Country:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 316);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Qualification:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 475);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(107, 426);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(59, 20);
            this.lb.TabIndex = 0;
            this.lb.Text = "Phone:";
            // 
            // dtpDateOfJoinning
            // 
            this.dtpDateOfJoinning.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfJoinning.Location = new System.Drawing.Point(174, 521);
            this.dtpDateOfJoinning.Name = "dtpDateOfJoinning";
            this.dtpDateOfJoinning.Size = new System.Drawing.Size(244, 26);
            this.dtpDateOfJoinning.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 526);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 40);
            this.label8.TabIndex = 0;
            this.label8.Text = "Date of Joinning:\r\n(mm/dd/yyyy)";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(174, 582);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 35);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(333, 582);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 35);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmBT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 675);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dtpDateOfJoinning);
            this.Controls.Add(this.cbxCountry);
            this.Controls.Add(this.lbxCity);
            this.Controls.Add(this.lbxQualification);
            this.Controls.Add(this.mtxtDateOfBirth);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEmployeeName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBT1";
            this.Text = "BT1: Employee Details";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ListBox lbxQualification;
        private System.Windows.Forms.ComboBox cbxCountry;
        private System.Windows.Forms.ListBox lbxCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtxtDateOfBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.DateTimePicker dtpDateOfJoinning;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}