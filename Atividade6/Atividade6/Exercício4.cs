using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class Exercício4 : Form
    {
        public Exercício4()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int salario, gratificacao, producao, B = 0, C = 0 , D = 0;
            double salBruto;

            if (int.TryParse(txtSal.Text, out salario) && (int.TryParse(txtProd.Text, out producao)) && (int.TryParse(txtGratificacao.Text, out gratificacao)))
            {
                if (producao >= 150)
                {
                    B = 1;
                    C = 1;
                    D = 1;
                }
                else if (producao >= 120)
                {
                    B = 1;
                    C = 1;
                }
                else if (producao >= 100)
                    B = 1;


                    salBruto = salario + salario * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacao;

                if (salBruto > 7000)
                {
                    if (producao >= 150 && gratificacao > 0)
                        MessageBox.Show("Salário bruto é: " + "R$" + salBruto);
                    else
                        MessageBox.Show("Salário bruto é: " + "R$" + 7000);
                }
                else
                    MessageBox.Show("Salário bruto é: "+ "R$" + salBruto);
            }
            else
                MessageBox.Show("Dados incorretos.");

            

        }
    }
}
