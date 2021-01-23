namespace BT4
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cbItalic = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cbBold = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpColor.SuspendLayout();
            this.grpFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(130, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(305, 32);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // grpColor
            // 
            this.grpColor.BackColor = System.Drawing.Color.PaleTurquoise;
            this.grpColor.Controls.Add(this.radBlack);
            this.grpColor.Controls.Add(this.radBlue);
            this.grpColor.Controls.Add(this.radGreen);
            this.grpColor.Controls.Add(this.radRed);
            this.grpColor.Location = new System.Drawing.Point(17, 70);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(180, 209);
            this.grpColor.TabIndex = 2;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlack.ForeColor = System.Drawing.Color.Black;
            this.radBlack.Location = new System.Drawing.Point(15, 136);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(100, 29);
            this.radBlack.TabIndex = 0;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "BLACK";
            this.radBlack.UseVisualStyleBackColor = true;
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(15, 101);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(84, 29);
            this.radBlue.TabIndex = 0;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "BLUE";
            this.radBlue.UseVisualStyleBackColor = true;
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radGreen.ForeColor = System.Drawing.Color.Green;
            this.radGreen.Location = new System.Drawing.Point(15, 66);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(101, 29);
            this.radGreen.TabIndex = 0;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "GREEN";
            this.radGreen.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRed.ForeColor = System.Drawing.Color.Red;
            this.radRed.Location = new System.Drawing.Point(15, 31);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(73, 29);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "RED";
            this.radRed.UseVisualStyleBackColor = true;
            // 
            // grpFont
            // 
            this.grpFont.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpFont.Controls.Add(this.checkBox3);
            this.grpFont.Controls.Add(this.cbItalic);
            this.grpFont.Controls.Add(this.checkBox2);
            this.grpFont.Controls.Add(this.cbBold);
            this.grpFont.Location = new System.Drawing.Point(247, 70);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(188, 209);
            this.grpFont.TabIndex = 3;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "Font";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(22, 101);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(117, 29);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Underline";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cbItalic
            // 
            this.cbItalic.AutoSize = true;
            this.cbItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItalic.Location = new System.Drawing.Point(22, 66);
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.Size = new System.Drawing.Size(73, 29);
            this.cbItalic.TabIndex = 1;
            this.cbItalic.Text = "Italic";
            this.cbItalic.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(22, 31);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(77, 29);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Bold";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // cbBold
            // 
            this.cbBold.AutoSize = true;
            this.cbBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBold.Location = new System.Drawing.Point(22, 39);
            this.cbBold.Name = "cbBold";
            this.cbBold.Size = new System.Drawing.Size(77, 29);
            this.cbBold.TabIndex = 1;
            this.cbBold.Text = "Bold";
            this.cbBold.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lập trình bởi ";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(17, 351);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(418, 32);
            this.txtResult.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(328, 403);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 36);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 451);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpFont);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Định dạng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);

            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpColor;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox cbItalic;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox cbBold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnExit;
    }
}

