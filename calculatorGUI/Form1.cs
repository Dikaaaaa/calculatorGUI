using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorGUI
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if(textDisplay1.Text == "0")
            {
                textDisplay1.Text = "1";
            }
            else
            {
                textDisplay1.Text = "1";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "2";
            }
            else
            {
                textDisplay1.Text = "2";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "3";
            }
            else
            {
                textDisplay1.Text = "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "4";
            }
            else
            {
                textDisplay1.Text = "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "5";
            }
            else
            {
                textDisplay1.Text = "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "6";
            }
            else
            {
                textDisplay1.Text = "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "7";
            }
            else
            {
                textDisplay1.Text = "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "8";
            }
            else
            {
                textDisplay1.Text = "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text == "0")
            {
                textDisplay1.Text = "9";
            }
            else
            {
                textDisplay1.Text = "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textDisplay1.Text != "0")
            {
                textDisplay1.Text = "0";
            }
            else
            {
                textDisplay1.Text = "0";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textDisplay1.Text = "0";
            bil1 = 0;
            bil2= 0;
            textDisplay2.Text = " ";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textDisplay1.Text);
            textDisplay2.Text = " + ";
            textDisplay1.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textDisplay1.Text);
            textDisplay2.Text = " - ";
            textDisplay1.Text = " ";
            opr = 2;
            opr_selesai = true;
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textDisplay1.Text);
            textDisplay2.Text = " X ";
            textDisplay1.Text = " ";
            opr = 3;
            opr_selesai = true;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textDisplay1.Text);
            textDisplay2.Text = " : ";
            textDisplay1.Text = " ";
            opr = 4;
            opr_selesai = true;
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            if (opr_selesai == true)
                bil2 = Convert.ToDecimal(textDisplay1.Text);
            {
                switch(opr)
                {
                    case 1:
                        textDisplay1.Text = Convert.ToString(bil1 + bil2);
                        break;
                    case 2:
                        textDisplay1.Text = Convert.ToString(bil1 - bil2);
                        break;
                    case 3:
                        textDisplay1.Text = Convert.ToString(bil1 * bil2);
                        break;
                    case 4:
                        textDisplay1.Text = Convert.ToString(bil1 / bil2);
                        break;
                }
                opr_selesai&= false;
            }
        }
    }
}
