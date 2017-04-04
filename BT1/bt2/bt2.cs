using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt2
{
    public partial class bt2 : Form
    {
        public bt2()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Arial", textBox1.Font.Size);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Times New Roman", textBox1.Font.Size);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Tahoma", textBox1.Font.Size);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Courier New", textBox1.Font.Size);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult h = MessageBox.Show
                ("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit(); 
        }
    }
}
