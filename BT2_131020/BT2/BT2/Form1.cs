using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Nút thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Xử lý sự kiện thoát
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        { 
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát chương trình!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;

        }

        //Nút xóa
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtResult.Clear();
            txtA.Focus();
            btnClear.Enabled = false;
            btnSolve.Enabled = false;
        }

        //Nút giải
        private void btnSolve_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);

            if(a == 0)
            {
                txtA.Focus();
                errorProvider1.SetError(txtA, "a phải khác 0!");
                txtResult.Text = "Nhập lại số a!";
            }
            else
            {
                errorProvider1.Clear();
                double result = (double)-b / a;
                txtResult.Text = result.ToString();
            }
        }

        //Hàm load
        private void frmMain_Load(object sender, EventArgs e)
        {
            btnClear.Enabled = false;
            btnSolve.Enabled = false;
        }

        //Xác thực số A sau khi nhập
        private void txtA_Validated(object sender, EventArgs e)
        {
            for(int i = 0; i < txtA.TextLength; i++)
            {
                if (!char.IsDigit(txtA.Text[i]))
                {
                    txtA.Text = "";
                    txtA.Focus();
                    errorProvider1.SetError(txtA, "Nhập kiểu dữ liệu số!");
                    break;
                }
                else
                    errorProvider1.Clear();
            }
        }

        //Xác thực số B sau khi nhập
        private void txtB_Validated(object sender, EventArgs e)
        {
            for (int i = 0; i < txtB.TextLength; i++)
            {
                if (!char.IsDigit(txtB.Text[i]))
                {
                    txtB.Text = "";
                    txtB.Focus();
                    errorProvider1.SetError(txtB, "Nhập kiểu dữ liệu số!");
                    break;
                }
                else
                {
                    errorProvider1.Clear();
                    btnSolve.Enabled = true;
                    btnClear.Enabled = true;
                }
            }
        }

        //Kiểm tra có nhập dữ liệu hay không
        private void txtA_Leave(object sender, EventArgs e)
        {
            if (txtA.TextLength == 0)
            {
                errorProvider1.SetError(txtA, "Không được bỏ trống!");
                txtA.Focus();
            }
            else
                errorProvider1.Clear();
        }

        private void txtB_Leave(object sender, EventArgs e)
        {
            if (txtB.TextLength == 0)
            {
                errorProvider1.SetError(txtB, "Không được bỏ trống!");
                txtB.Focus();
            }
            else
                errorProvider1.Clear();
        }
    }
}
