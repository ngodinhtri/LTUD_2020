using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapCoBanMenu
{
    public partial class frmBT4 : Form
    {
        public frmBT4()
        {
            InitializeComponent();
        }
        //Bắt sự kiện đóng
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        //Nút thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Load sự kiện khi khởi động
        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.CheckedChanged += new EventHandler(ChangeColorText);
            radGreen.CheckedChanged += new EventHandler(ChangeColorText);
            radBlue.CheckedChanged += new EventHandler(ChangeColorText);
            radBlack.CheckedChanged += new EventHandler(ChangeColorText);
        }
        //Thay đổi màu txtResult khi check radio
        private void ChangeColorText(object sender, EventArgs e)
        {
            if(radRed.Checked)
            {
                txtResult.BackColor = txtResult.BackColor;
                txtResult.ForeColor = Color.Red;
            }
            else if (radGreen.Checked)
            {
                txtResult.BackColor = txtResult.BackColor;
                txtResult.ForeColor = Color.Green;
            }
            else if (radBlue.Checked)
            {
                txtResult.BackColor = txtResult.BackColor;
                txtResult.ForeColor = Color.Blue;
            }
            else if (radBlack.Checked)
            {
                txtResult.BackColor = txtResult.BackColor;
                txtResult.ForeColor = Color.Black;
            }
        }
        //Đồng bộ txtName và txtReslut
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtResult.Text = txtName.Text;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if(Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        //
    }
}
