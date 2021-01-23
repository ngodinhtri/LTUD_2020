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
    public partial class frmBT1 : Form
    {
        public frmBT1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //txtEmployeeName
        private void txtEmployeeName_Leave(object sender, EventArgs e)
        {
            if(txtEmployeeName.TextLength == 0)
            {
                errorProvider.SetError(txtEmployeeName, "The name is empty now!");
                txtEmployeeName.Focus();
            }
            else
            {
                errorProvider.Clear();
                mtxtDateOfBirth.Focus();
            }
        }
        //mtxtDateOfBirth
        private void mtxtDateOfBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void mtxtDateOfBirth_Leave(object sender, EventArgs e)
        {
            if (!mtxtDateOfBirth.MaskCompleted)
            {
                errorProvider.SetError(mtxtDateOfBirth, "The date is not complete!");
                mtxtDateOfBirth.Focus();
            }
            else
            {
                errorProvider.Clear();
                txtAddress.Focus();
            }    
        }
        //cbxCountry
        private void cbxCountry_Leave(object sender, EventArgs e)
        {
            if (cbxCountry.SelectedItem == null)
            {
                errorProvider.SetError(cbxCountry, "The country is not complete!");
                cbxCountry.Focus();
            }
            else
            {
                errorProvider.Clear();
                lbxCity.Focus();
            }            
        }

        private void cbxCountry_TextChanged(object sender, EventArgs e)
        {
            lbxCity.Items.Clear();
            switch (cbxCountry.SelectedItem.ToString())
            {
                case "Viet Nam":
                    lbxCity.Items.Add("Ho Chi Minh");
                    lbxCity.Items.Add("Nha Trang");
                    lbxCity.Items.Add("Ha Noi");
                    break;
                case "Thailand":
                    lbxCity.Items.Add("Pattaya");
                    lbxCity.Items.Add("ChiengMai");
                    lbxCity.Items.Add("Bangkok");
                    break;
                default:
                    break;
            }
        }
        //txtAddress
        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.TextLength == 0)
            {
                errorProvider.SetError(txtAddress, "The address is empty now!");
                txtAddress.Focus();
            }
            else
            {
                errorProvider.Clear();
                cbxCountry.Focus();
            }
        }
        //lbxCity
        private void lbxCity_Leave(object sender, EventArgs e)
        {
            if (lbxCity.SelectedItem == null)
            {
                errorProvider.SetError(lbxCity, "The city is empty now!");
                lbxCity.Focus();
            }
            else
            {
                errorProvider.Clear();
                lbxQualification.Focus();
            }
        }
        //lbxQualification
        private void lbxQualification_Leave(object sender, EventArgs e)
        {
            if (lbxQualification.SelectedItem == null)
            {
                errorProvider.SetError(lbxQualification, "The qualification is empty now!");
                lbxQualification.Focus();
            }
            else
            {
                errorProvider.Clear();
                mtxtPhone.Focus();
            }
        }
        //mtxtPhone
        private void mtxtPhone_Leave(object sender, EventArgs e)
        {
            if (!mtxtPhone.MaskCompleted)
            {
                errorProvider.SetError(mtxtPhone, "The phone is not complete!");
                mtxtPhone.Focus();
            }
            else
            {
                errorProvider.Clear();
                txtEmail.Focus();
            }
        }

        private void mtxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
        //txtEmail
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.TextLength == 0)
            {
                errorProvider.SetError(txtEmail, "The email is empty now!");
                txtEmail.Focus();
            }
            else
            {
                errorProvider.Clear();
                dtpDateOfJoinning.Focus();
            }
        }
        //btnSubmit
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String sResult = "";
            sResult += "Employee Name: " + txtEmployeeName.Text + "\n";
            sResult += "Date of birth: " + mtxtDateOfBirth.Text + "\n";
            sResult += "Address: " + txtAddress.Text + "\n";
            sResult += "Country: " + cbxCountry.SelectedItem.ToString() + "\n";
            sResult += "City: " + lbxCity.Text + "\n";
            sResult += "Qualification: " + lbxQualification.Text + "\n";
            sResult += "Phone: " + mtxtPhone.Text + "\n";
            sResult += "Email: " + txtEmail.Text + "\n";
            sResult += "Date of Joinning: " + dtpDateOfJoinning.Value.ToShortDateString() + "\n";

            MessageBox.Show(sResult, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
