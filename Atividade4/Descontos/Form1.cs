using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            double salBruto, numFilhos, descontoINSS = 0, descontoIRPF = 0, salFam = 0, salLiq = 0;

            if (double.TryParse(mTxtSalBruto.Text, out salBruto) && double.TryParse(mTxtNumFilhos.Text, out numFilhos)) 
            {
            
                //ALÍQUOTA / DESCONTO INSS
                if (salBruto <= 800.47)
                {
                    mTxtAliINSS.Text = "7,65%";
                    descontoINSS = 7.65 / 100 * salBruto;
                    mTxtDescINSS.Text = descontoINSS.ToString("C");
                }
                else if (salBruto <= 1050)
                {
                    mTxtAliINSS.Text = "8,65%";
                    descontoINSS = 8.65 / 100 * salBruto;
                    mTxtDescINSS.Text = descontoINSS.ToString("C");
                }
                else if (salBruto <= 1400.77)
                {
                    mTxtAliINSS.Text = "9,00%";
                    descontoINSS = 9.00 / 100 * salBruto;
                    mTxtDescINSS.Text = descontoINSS.ToString("C");
                }
                else if (salBruto <= 2801.56)
                {
                    mTxtAliINSS.Text = "11,00%";
                    descontoINSS = 11.00 / 100 * salBruto;
                    mTxtDescINSS.Text = descontoINSS.ToString("C");
                }
                else if (salBruto > 2801.56)
                {
                    mTxtAliINSS.Text = "Teto";
                    descontoINSS = 308.17;
                    mTxtDescINSS.Text = descontoINSS.ToString("C");
                }

                //ALIQUOTA / DESCONTO IRPF
                if (salBruto <= 1257.12)
                {
                    mTxtAliIRRF.Text = "Isento";
                    descontoIRPF = 0.00;
                    mTxtDescIRPF.Text = descontoIRPF.ToString("C");
                }
                else if (salBruto <= 2512.08)
                {
                    mTxtAliIRRF.Text = "15,00%";
                    descontoIRPF = 15.00 / 100 * salBruto;
                    mTxtDescIRPF.Text = descontoIRPF.ToString("C");
                }
                else if (salBruto > 2512.08)
                {
                    mTxtAliIRRF.Text = "27.5%";
                    descontoIRPF = 27.5 / 100 * salBruto;
                    mTxtDescIRPF.Text = descontoIRPF.ToString("C");
                }

                //Salário Família
                if (salBruto <= 435.52)
                {
                    salFam = 22.33 * numFilhos;
                    mTxtSalFam.Text = salFam.ToString("C");
                    
                }
                else if (salBruto <= 654.61)
                {
                    salFam = 15.74 * numFilhos;
                    mTxtSalFam.Text = salFam.ToString("C");
                }
                else if (salBruto > 654.61)
                {
                    mTxtSalFam.Text = "R$" + "0,00";
                    salFam = 0.00;
                }

                //Salário líquido
                salLiq = salBruto - descontoINSS - descontoIRPF + salFam;
                mTxtSalLiq.Text = salLiq.ToString("C");

                //Checagem de status de relacionamento
                string status;


                if (checkCasado.Checked)
                {
                    status = "Casado(a)";
                }
                else
                {
                    status = "Solteiro(a)";
                }

                //Label de saída
                lblOut.Text = "Os descontos do salário de " + mTxtFunc.Text + " que é " + status.ToString() + " e que tem " + mTxtNumFilhos.Text + " filhos são:";
            }
            else
            {
                MessageBox.Show("Forneça valores válidos!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mTxtNumFilhos_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }
        private void mTxtNumFilhos_MouseUp(object sender, MouseEventArgs e)
        {
            SendKeys.Send("{END}");
        }

        private void mTxtSalBruto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

    }
}
