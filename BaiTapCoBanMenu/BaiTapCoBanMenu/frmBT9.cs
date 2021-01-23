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
    public partial class frmBT9 : Form
    {
        public frmBT9()
        {
            InitializeComponent();
        }
        //Exit btn
        private void btnExit_Click(object sender, EventArgs e)
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
        //Add an item to list
        private void addItem()
        {
            if (txtInput.TextLength > 0)
            {
                lstA.Items.Add(txtInput.Text);
                txtInput.Clear();
                txtInput.Focus();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            addItem();
        }
        //Check isListEmpty
        private Boolean isListEmptyA()
        {
            if (lstA.Items.Count == 0)
                return true;
            return false;
        }
        private Boolean isListEmptyB()
        {
            if (lstB.Items.Count == 0)
                return true;
            return false;
        }
        //Del items in list A
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (isListEmptyA() == true)
            {
                MessageBox.Show("Không có phần tử để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = lstA.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    lstA.Items.RemoveAt(lstA.SelectedIndices[i]);
                }
            }
        }
        //Transport selected items list A to list B
        private void btnTransportLR_Click(object sender, EventArgs e)
        {
            if (isListEmptyA() == true)
            {
                MessageBox.Show("Không có sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //copy selected items lstA to lstB
                for(int i=0; i < lstA.SelectedItems.Count;i++)
                {
                    lstB.Items.Add(lstA.SelectedItems[i]);
                }
                //remove that items
                for (int i =  lstA.SelectedItems.Count -1; i>=0; i--)
                {
                    lstA.Items.Remove(lstA.SelectedItems[i]);
                }
            }
        }
        //Transport all items list A to list B
        private void btnTransportAllLR_Click(object sender, EventArgs e)
        {
            if (isListEmptyA() == true)
            {
                MessageBox.Show("Không có sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //copy selected items lstA to lstB
                for (int i = 0; i < lstA.Items.Count; i++)
                {
                    lstB.Items.Add(lstA.Items[i]);
                }
                //remove that items
                lstA.Items.Clear();
            }
        }
        //Transport selected items list B to list A
        private void btnTransportRL_Click(object sender, EventArgs e)
        {
            if (isListEmptyB() == true)
            {
                MessageBox.Show("Không có sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //copy selected items lstB to lstA
                for (int i = 0; i < lstB.SelectedItems.Count; i++)
                {
                    lstA.Items.Add(lstB.SelectedItems[i]);
                }
                //remove that items
                for (int i = lstB.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lstB.Items.Remove(lstB.SelectedItems[i]);
                }
            }
        }
        //Transport all items list B to list A
        private void btnTransportAllRL_Click(object sender, EventArgs e)
        {
            if (isListEmptyB() == true)
            {
                MessageBox.Show("Không có sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //copy selected items lstB to lstA
                for (int i = 0; i < lstB.Items.Count; i++)
                {
                    lstA.Items.Add(lstB.Items[i]);
                }
                //remove that items
                lstB.Items.Clear();
            }
        }
    }
}
