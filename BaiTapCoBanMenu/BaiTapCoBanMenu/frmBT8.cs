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
    public partial class frmBT8 : Form
    {
        public frmBT8()
        {
            InitializeComponent();
        }
        //Event Form Closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        //Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Enter button
        private void btnInput_Click(object sender, EventArgs e)
        {
            //make sure the input is an integer.
            int num = 0;
            if (!(int.TryParse(txtInput.Text, out num)))
            {
                MessageBox.Show("Vui lòng nhập số int", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInput.Clear();
            }
            else
            {
                addItem();
            }            
        }
        //Delete Head and Tail button
        private void btnDelHeadTail_Click(object sender, EventArgs e)
        { 
            if(isListEmpty()==true)
            {
                MessageBox.Show("Không có phần tử để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                lstResult.Items.RemoveAt(0);
                lstResult.Items.RemoveAt(lstResult.Items.Count - 1);
            }            
        }

        //Check isListEmpty
        private Boolean isListEmpty()
        {
            if (lstResult.Items.Count == 0)
                return true;
            return false;
        }
        //Add an item to list
        private void addItem()
        {
            if (txtInput.TextLength > 0)
            {
                lstResult.Items.Add(txtInput.Text);
                txtInput.Clear();
                txtInput.Focus();
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Sum all the numbers
        private void btnSum_Click(object sender, EventArgs e)
        {
            if (isListEmpty() == true)
            {
                MessageBox.Show("Không có phần tử để tổng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int sum = 0;
                for(int i = 0; i < lstResult.Items.Count;i++)
                {
                    sum += int.Parse(lstResult.Items[i].ToString());
                }
                MessageBox.Show("Tổng các phần tử của mảng là: " + sum, "Tổng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Delete selected items
        private void btnDelSelected_Click(object sender, EventArgs e)
        {
            if (isListEmpty() == true)
            {
                MessageBox.Show("Không có phần tử để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               for(int i = lstResult.SelectedIndices.Count -1;i>=0;i--)
                {
                    lstResult.Items.RemoveAt(lstResult.SelectedIndices[i]);
                }
            }            
        }
        //Plus two each item
        private void btnPlusTwo_Click(object sender, EventArgs e)
        {
            if (isListEmpty() == true)
            {
                MessageBox.Show("Không có phần tử", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < lstResult.Items.Count; i++)
                {
                    lstResult.Items[i] = int.Parse(lstResult.Items[i].ToString())+2;
                }
            }
        }
        //Replace by square root
        private void btnReplaceSqrt_Click(object sender, EventArgs e)
        {
            if (isListEmpty() == true)
            {
                MessageBox.Show("Không có phần tử", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < lstResult.Items.Count; i++)
                {
                    lstResult.Items[i] = Math.Sqrt(int.Parse(lstResult.Items[i].ToString()));
                }
            }
        }
        //Even numbers
        private void btnEvenNumber_Click(object sender, EventArgs e)
        {
            if (isListEmpty() == true)
            {
                MessageBox.Show("Không có phần tử", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string s = "";
                for (int i = 0; i < lstResult.Items.Count; i++)
                {
                    int num = int.Parse(lstResult.Items[i].ToString());
                    if(num % 2 == 0)
                    {
                        s = s + num + " " ;
                    }
                }
                MessageBox.Show("Số chẳn: " + s, "Số chẳn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Odd numbers
        private void btnOddNumber_Click(object sender, EventArgs e)
        {
            if (isListEmpty() == true)
            {
                MessageBox.Show("Không có phần tử", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string s = "";
                for (int i = 0; i < lstResult.Items.Count; i++)
                {
                    int num = int.Parse(lstResult.Items[i].ToString());
                    if (!(num % 2 == 0))
                    {
                        s = s + num + " ";
                    }
                }
                MessageBox.Show("Số lẻ: " + s, "Số lẻ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
