using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OnTapCuoiKi
{
    public partial class frmKhoa : Form
    {
        HandleData handleData = new HandleData();
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            dtgvKhoa.DataSource = handleData.getDataFormTable("KHOA");
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text;
            string tenKhoa = txtTenKhoa.Text;
            int result = handleData.themKhoa(maKhoa, tenKhoa);
           if(result > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                frmKhoa_Load(sender, e);
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void dtgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtMaKhoa.Text = dtgvKhoa.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKhoa.Text = dtgvKhoa.Rows[e.RowIndex].Cells[1].Value.ToString();

                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                txtMaKhoa.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text;
            int result = handleData.xoaKhoa(maKhoa);
            if (result > 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công");
                frmKhoa_Load(sender, e);
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKhoa = txtMaKhoa.Text;
            string tenKhoa = txtTenKhoa.Text;
            int result = handleData.suaKhoa(maKhoa,tenKhoa);
            if (result > 0)
            {
                MessageBox.Show("Sửa dữ liệu thành công");
                frmKhoa_Load(sender, e);
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            frmKhoa_Load(sender, e);
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtMaKhoa.Enabled = true;
            txtMaKhoa.Focus();
        }
    }
}
