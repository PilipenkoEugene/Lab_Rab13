using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LR13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxa.SelectedIndex = 0;
            listBoxb.SelectedIndex = 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Z = 0;
                double Y = Convert.ToDouble(textBoxX.Text, CultureInfo.InvariantCulture);
                int Val = Convert.ToInt32(textBoxVal.Text);
                int N = Convert.ToInt32(textBoxN.Text);
                int R = Convert.ToInt32(textBoxR.Text);
                double k = Convert.ToDouble(comboBoxa.Text, CultureInfo.InvariantCulture);
                double c = Convert.ToDouble(listBoxb.Text, CultureInfo.InvariantCulture);
               
                if (eq1.Checked)
                {
                    Z = 1;
                    for (int i = 1; i < Val; i++)
                    {
                       Z += Math.Pow(-1, i % 2) * ((3 + 2 * (i - 1)) * Math.Pow(Y, i)) / (i*(i + 1));
                    }
                }
                else
                {
                    Z = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        for (int j = 1; j <= R; j++)
                        {
                            Z += (i + j * k) / (c * Math.Pow(i, j));
                        }
                    }

                }
                textBoxZ.Text = String.Format("{0:0.000}", Z);
            }
            catch
            {
                MessageBox.Show("ERROR! Введены некорректные значения!");
            }



        }

        private void textBoxVal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
