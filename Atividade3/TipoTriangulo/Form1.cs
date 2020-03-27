using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0;

            if (double.TryParse(txtA.Text, out a) && (double.TryParse(txtB.Text, out b)) && double.TryParse(txtC.Text, out c))
            {
                if (a > 0 && b > 0 && c > 0)
                {
                    if (a.Equals(b) && b.Equals(c))
                    {
                        lblOut.Text = "Triângulo equilátero";
                    }
                    else if (a.Equals(b) || b.Equals(c) || a.Equals(c))
                    {
                        lblOut.Text = "Triângulo isósceles";
                    }
                    else
                    {
                        lblOut.Text = "Triângulo escaleno";
                    }
                }
                else 
                {
                    MessageBox.Show("Forneça valores maiores que 0.");
                }
            }
            else
            {
                MessageBox.Show("Forneça valores válidos!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            lblOut.Text = " ";
        }
    }
}
