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
    public partial class frmBT10 : Form
    {
        public frmBT10()
        {
            InitializeComponent();
        }
        //Exit btn
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }      
        //Form Closing event
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
        //Reset
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtMSSV.Clear();
            cbxLop.SelectedIndex = -1;
            cbxNienKhoa.SelectedIndex = -1;
            for(int i = 0; i < cblstMonHoc.Items.Count; i++)
            {
                cblstMonHoc.SetItemChecked(i, false);
            }

            foreach(RadioButton radioButton in grpHocKy.Controls)
            {
                if (radioButton.Checked)
                {
                    radioButton.Checked = false;
                    break;
                }
            }
        }
        //Register
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            //checkEmpty();
            string sResult = "";
            sResult += "Sinh viên: " + txtHoTen.Text + "\n";        
            sResult += "Lớp: " + cbxLop.SelectedItem.ToString() + "\n";
            sResult += "Niên khóa: " + cbxNienKhoa.SelectedItem.ToString() + "\n";
            sResult += "Đã đăng ký Học kỳ ";
            foreach (RadioButton radioButton in grpHocKy.Controls)
            {
                if (radioButton.Checked)
                {
                    string s = radioButton.Text;
                    switch (s)
                    {
                        case "I":
                            sResult += "1 ";
                            break;
                        case "II":
                            sResult += "2 ";
                            break;
                        case "III":
                            sResult += "3 ";
                            break;
                        case "IV":
                            sResult += "4 ";
                            break;
                    }
                    break;
                }
            }
            sResult += " các môn học sau:\n";
            int index = 1;
            foreach(string monHoc in cblstMonHoc.CheckedItems)
            {
                sResult += index + ". " + monHoc + "\n";
                index++;
            }
            MessageBox.Show(sResult, "Kết quả");
        }

        //private void checkEmpty()
        //{
        //    if (txtMSSV.TextLength == 0)
        //    {
        //        errorMain.SetError(txtMSSV, "Không để trống!");
        //        txtMSSV.Focus();
        //    }
        //    else
        //    {
        //        errorMain.Clear();
        //    }
        //    if (txtHoTen.TextLength == 0)
        //    {
        //        errorMain.SetError(txtHoTen, "Không để trống!");
        //        txtHoTen.Focus();
        //    }
        //    else
        //    {
        //        errorMain.Clear();
        //    }
        //    if (cbxLop.SelectedIndex == -1)
        //    {
        //        errorMain.SetError(cbxLop, "Không để trống!");
        //        cbxLop.Focus();
        //    }
        //    else
        //    {
        //        errorMain.Clear();
        //    }
        //    if (cbxNienKhoa.SelectedIndex == -1)
        //    {
        //        errorMain.SetError(cbxNienKhoa, "Không để trống!");
        //        cbxNienKhoa.Focus();
        //    }
        //    else
        //    {
        //        errorMain.Clear();
        //    }
        //    Boolean hasChecked = false;
        //    foreach (RadioButton radioButton in grpHocKy.Controls)
        //    {
        //        if (radioButton.Checked)
        //        {
        //            hasChecked = true;
        //            break;
        //        }
        //    }
        //    if(!hasChecked)
        //    {
        //        errorMain.SetError(grpHocKy, "Không để trống!");
        //        grpHocKy.Focus();
        //    }
        //    else
        //    {
        //        errorMain.Clear();
        //    }
        //    hasChecked = false;
        //    foreach (CheckBox item in cblstMonHoc.Controls)
        //    {
        //        if (item.Checked)
        //        {
        //            hasChecked = true;
        //            break;
        //        }
        //    }
        //    if (!hasChecked)
        //    {
        //        errorMain.SetError(cblstMonHoc, "Không để trống!");
        //        grpHocKy.Focus();
        //    }
        //    else
        //    {
        //        errorMain.Clear();
        //    }
        //}
    }
}
