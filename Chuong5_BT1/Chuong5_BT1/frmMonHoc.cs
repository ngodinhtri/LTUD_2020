using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chuong5_BT1
{
    public partial class frmMonHoc : Form
    {
        HandleData handleData = new HandleData();
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            dtgvMonHoc.DataSource = handleData.getDataFromTable("MONHOC");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaMH.Clear();
            txtSoTiet.Clear();
            txtTenMH.Clear();

            txtMaMH.Enabled = true;
            txtMaMH.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sMaMH = txtMaMH.Text;
            string sTenMH = txtTenMH.Text;
            int iSoTiet = int.Parse(txtSoTiet.Text);

            if (handleData.insertMonHoc(sMaMH, sTenMH, iSoTiet)>0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                dtgvMonHoc.DataSource = handleData.getDataFromTable("MONHOC");
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại");
            }
            this.btnClear_Click(sender, e);
        }

        private void dtgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvMonHoc.ReadOnly = false;
            if(e.RowIndex >= 0)
            {
                //Lưu dữ liệu hàng đó vào biến
                DataGridViewRow row = this.dtgvMonHoc.Rows[e.RowIndex];
                //Đưa dữ liệu vào chương trình
                txtMaMH.Text = row.Cells[0].Value.ToString();
                txtTenMH.Text = row.Cells[1].Value.ToString();
                txtSoTiet.Text = row.Cells[2].Value.ToString();
                //Không cho chỉnh sửa mã môn học
                txtMaMH.Enabled = false;
            }
            dtgvMonHoc.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sMaNH = txtMaMH.Text;
            DialogResult r = MessageBox.Show("Bạn có muốn xóa lớp này?", "Xóa môn học", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(r == DialogResult.Yes)
            {
                handleData.deleteMonHoc(sMaNH);
                dtgvMonHoc.DataSource = handleData.getDataFromTable("MONHOC");
            }
        }
    }
}
