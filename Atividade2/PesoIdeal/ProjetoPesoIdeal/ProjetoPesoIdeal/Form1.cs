using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn01_Click(object sender, EventArgs e)
        {
            double altura, peso;
            double imc = 0;
            
                if (double.TryParse(txtPeso.Text, out peso) && double.TryParse(txtAltura.Text, out altura))
                {
                    if (radioMasc.Checked)
                    {
                        imc = Math.Round((72.7 * altura) - 58.0,2);
                    }
                    else if (radioFem.Checked)
                    {
                        imc = Math.Round((62.1 * altura) - 44.7,2);
                    }
                    else
                        MessageBox.Show("Selecione Sexo");  
                }
                else
                {
                    MessageBox.Show("Forneça valores");
                }

                if (imc < peso)
                {
                    labelOut.Text = "Você está acima do peso.";
                }
                else if (imc > peso)
                {
                    labelOut.Text = "Você está abaixo do peso.";
                }
                else if (imc == peso) 
                { 
                    labelOut.Text = "Você está no peso ideal"; 
                }                     
        }

        private void labelAVISO_Click(object sender, EventArgs e)
        {

        }
    }
}
