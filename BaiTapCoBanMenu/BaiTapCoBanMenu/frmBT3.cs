using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BaiTapCoBanMenu
{
    public partial class frmBT3 : Form
    {
        public frmBT3()
        {
            InitializeComponent();
        }
        //Cộng
        private void rdoCong_CheckedChanged(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double result = num1 + num2;

            txtResult.Text = result.ToString();
        }
        //Trừ
        private void rdoTru_CheckedChanged(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double result = num1 - num2;

            txtResult.Text = result.ToString();
        }
        //Nhân
        private void rdoNhan_CheckedChanged(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double result = num1 * num2;

            txtResult.Text = result.ToString();
        }
        //Chia
        private void rdoChia_CheckedChanged(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            double result = num1 / num2;

            txtResult.Text = result.ToString();
        }
        //Thoát
        private void frmMainBT3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        //Kiểm tra có nhập dữ liệu hay không
        private void txtNum1_Leave(object sender, EventArgs e)
        {
            if (txtNum1.TextLength == 0)
            {
                errorProvider1.SetError(txtNum1, "Vui lòng không bỏ trống!");
                txtNum1.Focus();
            }
            else
                errorProvider1.Clear();
        }

        private void txtNum2_Leave(object sender, EventArgs e)
        {
            if (txtNum2.TextLength == 0)
            {
                errorProvider1.SetError(txtNum2, "Vui lòng không bỏ trống!");
                txtNum2.Focus();
            }
            else
            {
                errorProvider1.Clear();
                grpPhepTinh.Enabled = true;
            }
        }
        //Kiểm tra dữ liệu nhập vào
        

       
        //Load
        private void frmMainBT3_Load(object sender, EventArgs e)
        {
            grpPhepTinh.Enabled = false;
        }
        //Đóng các radio phép tính khi nhập dữ liệu
        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            grpPhepTinh.Enabled = false;
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            grpPhepTinh.Enabled = false;
        }
    }
}