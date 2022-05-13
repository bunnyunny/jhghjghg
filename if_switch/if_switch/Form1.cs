using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {

        }

        private void btnIf_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt_num1.Text), num2 = int.Parse(txt_num2.Text), num3 = int.Parse(txt_num3.Text);

            if(num1 > num3)
            {
                MessageBox.Show("Verde");
            }
            if(num2 == num1)
            {
                MessageBox.Show("Amarelo");
            }
            if(num3 > 5)
            {
                MessageBox.Show("Azul");
            }
            if(num2 != 0)
            {
                MessageBox.Show("Branco");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
