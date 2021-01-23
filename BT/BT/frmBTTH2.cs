using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BT
{
    public partial class frmBTTH2 : Form
    {
        public frmBTTH2()
        {
            InitializeComponent();
        }
        //Forms
        Form fBT1 = null;
        Form fBT2 = null;
        FormCollection frmC = Application.OpenForms; 
        //Check the form is open?
        private bool isFormOpen(String nameForm)
        {
            foreach(Form frm in frmC)
            {
                if (frm.Name == nameForm)
                {
                    return true;
                }
            }
            return false;
        }
        //Form Closing Event
        private void frmBTTH2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thoát chương trình!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        //Menu BT1 Click
        private void menuBT1_Click(object sender, EventArgs e)
        {
            if(isFormOpen("frmBT1"))
            {
                //do something while the form is open
                fBT1.WindowState = FormWindowState.Normal;              
                fBT1.Show();
                fBT1.Focus();
            }
            else
            {
                fBT1 = new frmBT1();
                fBT1.MdiParent = this;         
                fBT1.Show();
            }
        }

        private void menuBT2_Click(object sender, EventArgs e)
        {
            if (isFormOpen("frmBT2"))
            {
                //do something while the form is open
                fBT2.WindowState = FormWindowState.Normal;
                fBT2.Show();
                fBT2.Focus();
            }
            else
            {
                fBT2 = new frmBT1();
                fBT2.MdiParent = this;
                fBT2.Show();
            }
        }
    }
}
