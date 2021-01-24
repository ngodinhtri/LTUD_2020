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
    public partial class frmSV : Form
    {
        public frmSV()
        {
            InitializeComponent();
        }

        HandleData handleData = new HandleData();

        private void frmSV_Load(object sender, EventArgs e)
        {
            DataTable dtKhoa = handleData.getDataFormTable("KHOA");
            dtgvSinhVien.DataSource = handleData.getDataFormTable("SINHVIEN");
            rdoNam.Checked = true;
            cbKhoa.DataSource = dtKhoa;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "MAKHOA";

            txtMa.Enabled = true;
            txtMa.Clear();
            txtHo.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            txtHocBong.Clear();
            cbKhoa.SelectedIndex = 0;
            dateNgaySinh.Value = DateTime.Today;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMa.Text;
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string gt = rdoNam.Checked ? "Nam" : "Nu";
            string date = dateNgaySinh.Value.ToString();
            string makhoa = cbKhoa.SelectedValue.ToString();
            string noiSinh = txtDiaChi.Text;
            string diaChi = txtDiaChi.Text;
            int hocbong = Int32.Parse(txtHocBong.Text);

            int r = handleData.themSinhVien(maSV, ho, ten, gt, date, noiSinh, diaChi, makhoa, hocbong);
            if (r > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                frmSV_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }

        }

        private void dtgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string maKhoa = dtgvSinhVien.Rows[e.RowIndex].Cells[7].Value.ToString();
                for (int i = 0; i < cbKhoa.Items.Count; i++)
                {
                    cbKhoa.SelectedIndex = i;
                    if(cbKhoa.SelectedValue.ToString().Equals(maKhoa))
                    {
                        break;
                    }
                }

            }
        }
    }
}
