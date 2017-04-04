using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtKetQua.Text = (int.Parse(txtSo1.Text) / int.Parse(txtSo2.Text)).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSo1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                errorProvider1.SetError(ctr, "Invalid Number");
            }
            else if (ctr.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(ctr, "Enter your number");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSo2_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
            {
                errorProvider1.SetError(ctr, "Invalid Number");
            }
            else if (ctr.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(ctr, "Enter your number");
            }
            else
            {
                errorProvider1.Clear();
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtKetQua.Text = (int.Parse(txtSo1.Text) + int.Parse(txtSo2.Text)).ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtKetQua.Text = (int.Parse(txtSo1.Text) - int.Parse(txtSo2.Text)).ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtKetQua.Text = (int.Parse(txtSo1.Text) * int.Parse(txtSo2.Text)).ToString();
        }
    }
}
