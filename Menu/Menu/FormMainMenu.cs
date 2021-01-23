using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu
{
    public partial class frmMain : Form
    {
        //Forms
        Form fBT1 = null;
        public frmMain()
        {
            InitializeComponent();
        }
        //Check if form is already opened.
        private bool checkFormOpened(string name)
        {
            FormCollection formCollection = Application.OpenForms;
            foreach(Form f in formCollection)
            {
                if(f.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        private void menuBT2_Click(object sender, EventArgs e)
        {
           
        }

        private void menuBT1_Click(object sender, EventArgs e)
        {            
            if (!checkFormOpened("FormBT1"))
            {
                fBT1 = new FormBT1();
                fBT1.MdiParent = this;
                fBT1.Show();
            }
            else
            {
                fBT1.WindowState = FormWindowState.Normal;
                fBT1.Dock = DockStyle.Fill;
                fBT1.Show();
                fBT1.Focus();
            }            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thoát chương trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
