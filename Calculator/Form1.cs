using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtbx1.Text);
            double b = Convert.ToDouble(txtbx6.Text);
            double y = Convert.ToDouble(txtbx7.Text);
            double t = Convert.ToDouble(txtbx8.Text);
            double u = Convert.ToDouble(txtbx2.Text);
            double tbsone = Convert.ToDouble(tbs1.Text);
            double tbstwo = Convert.ToDouble(tbs2.Text);
            double tbsthree = Convert.ToDouble(tbs3.Text);
            double tbpoone = Convert.ToDouble(tbpo1.Text);
            double tbpotwo = Convert.ToDouble(tbpo2.Text);
            double tbpothree = Convert.ToDouble(tbpo3.Text);
            double w = 0;
            double q = 0;
            double s = 0;
            double d = 0;
            double i = 0;
            double o = 0;
            w = tbpoone - tbsone;
            q = tbpotwo - tbstwo;
            s = tbpothree - tbsthree;
            

            if (b == 0);
            {
                Console.WriteLine(txtbx4.Text = Convert.ToString(d = a * (b * w) / 100));
            }
            if (b == 0);
            {
                Console.WriteLine(txtbx4.Text = Convert.ToString(o = a * (y * q) / 100));
            }
            if (b == 0);
            {
                Console.WriteLine(txtbx4.Text = Convert.ToString(i = a * (t * s) / 100));
            }
            txtbx4.Text = Convert.ToString(d + o + i);
            txtbx3.Text = Convert.ToString(a + d + o + i);
            txtbx5.Text = Convert.ToString(((b * w) + (y * q) + (t * s))/25);
            txtbx1.MaxLength = 3;
        }
        


        private void txtbx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx1_KeyPress(object sender, KeyPressEventArgs e)
        {
        char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void txtbx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void txtbx3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void txtbx4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void txtbx5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void tbs1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void tbs2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void tbs3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void tbpo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void tbpo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void tbpo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void txtbx6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void txtbx7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void txtbx8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
