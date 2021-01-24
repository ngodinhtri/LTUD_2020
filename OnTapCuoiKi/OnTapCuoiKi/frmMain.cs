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
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        private Form formKhoa = null;
        private Form formSinhVien = null;

        private bool isFormOpened(string name)
        {
            FormCollection formCollection = Application.OpenForms;
            foreach(Form form in formCollection)
            {
                if(form.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void quanlykhoaMenuItems_Click(object sender, EventArgs e)
        {
            if (!isFormOpened("frmKhoa"))
            {
                formKhoa = new frmKhoa();
                formKhoa.MdiParent = this;
                formKhoa.WindowState = FormWindowState.Maximized;
                formKhoa.Show();
            }
            else
            {
                formKhoa.WindowState = FormWindowState.Maximized;
                formKhoa.Dock = DockStyle.Fill;
                formKhoa.Show();
                formKhoa.Focus();
            }
        }

        private void quanLýSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!isFormOpened("frmSV"))
            {
                formSinhVien = new frmSV();
                formSinhVien.MdiParent = this;
                formSinhVien.WindowState = FormWindowState.Maximized;
                formSinhVien.Show();
            }
            else
            {
                formSinhVien.WindowState = FormWindowState.Maximized;
                formSinhVien.Dock = DockStyle.Fill;
                formSinhVien.Show();
                formSinhVien.Focus();
            }
        }
    }
}
