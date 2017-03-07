using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 a = Convert.ToInt32(textBox1.Text);
            if(a==1)
            {
                textBox2.Text = a + "";
            }
            else if (a >= 0)
            {
                Int32 S = (1 + a) *a;
                S = S /2;
                textBox2.Text = S+"";
            }
            else if (a <= 0)
            {
                Int32 S = (-1 + a) * a;
                S = S / 2;
                S = S * (-1);
                textBox2.Text = S+1 + "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 a = Convert.ToInt32(textBox1.Text);
            if (a > 0)
            {
                Int32 z = a;
                Int32 x = a;
                for (Int32 i = 0; i <= x; i++)
                {
                    if (z == 1)
                    {
                        i = x + 1;
                    }
                    else
                    {
                        z--;
                        a = a + z;

                    }

                }

            }
            else 
            {
                Int32 z = a;
                
                for (Int32 i = a; i <= 2; i++)
                {
                    z++;
                    if (z == 2)
                    {
                        i = 3;
                    }
                    else
                    {
                       
                        a = a + z;

                    }

                }
                
            }

            textBox2.Text = a  + "";
        }
    }
}
