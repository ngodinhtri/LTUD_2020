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
    public partial class frmKhoa : Form
    {
        HandleData handleData = new HandleData();

        public frmKhoa()
        {
            InitializeComponent();
        }

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            dtgvKhoa.DataSource = handleData.getDataFromTable("KHOA");
            cbKhoa.DataSource = handleData.getDataFromTable("KHOA");
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "MAKHOA";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sMaKhoa = txtMaKhoa.Text;
            string sTenKhoa = txtTenKhoa.Text;
            if (handleData.insertKhoa(sMaKhoa, sTenKhoa) > 0)
            {
                MessageBox.Show("Thêm khoa thành công!");
                dtgvKhoa.DataSource = handleData.getDataFromTable("KHOA");
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn xóa khoa này?","Xóa khoa",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            string sMaKhoa = txtMaKhoa.Text;
            if(r == DialogResult.Yes)
            {
                handleData.deleteKhoa(sMaKhoa);
                dtgvKhoa.DataSource = handleData.getDataFromTable("KHOA");

            }
        }

        private void dtgvKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvKhoa.ReadOnly = false;
            if(e.RowIndex>=0)
            {
                //Lưu dữ liệu vừa click chọn
                DataGridViewRow row = this.dtgvKhoa.Rows[e.RowIndex];
                //Đưa dữ liệu vào text box
                txtMaKhoa.Text = row.Cells[0].Value.ToString();
                txtTenKhoa.Text = row.Cells[1].Value.ToString();

                txtMaKhoa.Enabled = false;
            }
            dtgvKhoa.ReadOnly = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            txtMaKhoa.Enabled = true;
            txtTenKhoa.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sMaKhoa = txtMaKhoa.Text;
            string sTenKhoa = txtTenKhoa.Text;

            DialogResult r = MessageBox.Show("Bạn có muốn cập nhật khoa này?", "Cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(r == DialogResult.Yes)
            {
                handleData.updateKhoa(sMaKhoa, sTenKhoa);
                dtgvKhoa.DataSource = handleData.getDataFromTable("KHOA");
            }        
        }
    }
}
