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
    public partial class frmMainDSBT : Form
    {
        public frmMainDSBT()
        {
            InitializeComponent();
        }
        //Forms
        Form frmBT1 = null;
        Form frmBT2 = null;
        Form frmBT3 = null;
        Form frmBT4 = null;
        Form frmBT8 = null;
        Form frmBT9 = null;
        Form frmBT10 = null;
        //Check if form is opened
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

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void menuBT1_Click(object sender, EventArgs e)
        {
            if (!isFormOpened("frmBT1"))
            {
                frmBT1 = new frmBT1();
                frmBT1.MdiParent = this;
                frmBT1.Show();
            }
            else
            {
                frmBT1.WindowState = FormWindowState.Normal;
                frmBT1.Dock = DockStyle.Fill;
                frmBT1.Show();
                frmBT1.Focus();
            }
        }       

        private void bT2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFormOpened("frmBT2"))
            {
                frmBT2 = new frmBT2();
                frmBT2.MdiParent = this;
                frmBT2.Show();
            }
            else
            {
                frmBT2.WindowState = FormWindowState.Normal;
                frmBT2.Dock = DockStyle.Fill;
                frmBT2.Show();
                frmBT2.Focus();
            }
        }

        private void bT3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFormOpened("frmBT3"))
            {
                frmBT3 = new frmBT3();
                frmBT3.MdiParent = this;
                frmBT3.Show();
            }
            else
            {
                frmBT3.WindowState = FormWindowState.Normal;
                frmBT3.Dock = DockStyle.Fill;
                frmBT3.Show();
                frmBT3.Focus();
            }
        }

        private void menuBT4_Click(object sender, EventArgs e)
        {
            if (!isFormOpened("frmBT4"))
            {
                frmBT4 = new frmBT4();
                frmBT4.MdiParent = this;
                frmBT4.Show();
            }
            else
            {
                frmBT4.WindowState = FormWindowState.Normal;
                frmBT4.Dock = DockStyle.Fill;
                frmBT4.Show();
                frmBT4.Focus();
            }
        }

        private void menuBT8_Click(object sender, EventArgs e)
        {
            if (!isFormOpened("frmBT8"))
            {
                frmBT8 = new frmBT8();
                frmBT8.MdiParent = this;
                frmBT8.Show();
            }
            else
            {
                frmBT8.WindowState = FormWindowState.Normal;
                frmBT8.Dock = DockStyle.Fill;
                frmBT8.Show();
                frmBT8.Focus();
            }
        }

        private void menuBT9_Click(object sender, EventArgs e)
        {
            if (!isFormOpened("frmBT9"))
            {
                frmBT9 = new frmBT9();
                frmBT9.MdiParent = this;
                frmBT9.Show();
            }
            else
            {
                frmBT9.WindowState = FormWindowState.Normal;
                frmBT9.Dock = DockStyle.Fill;
                frmBT9.Show();
                frmBT9.Focus();
            }
        }

        private void menuBT10_Click(object sender, EventArgs e)
        {
            if (!isFormOpened("frmBT10"))
            {
                frmBT10 = new frmBT10();
                frmBT10.MdiParent = this;
                frmBT10.Show();
            }
            else
            {
                frmBT10.WindowState = FormWindowState.Normal;
                frmBT10.Dock = DockStyle.Fill;
                frmBT10.Show();
                frmBT10.Focus();
            }
        }
    }
}
