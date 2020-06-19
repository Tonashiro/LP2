using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace AvaliaçãoLP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double[,] vendas = new double[10, 4];
            string valor = "";
            double[] valSemana = new double[4];
            double[] valMes = new double[10];
            double valTotal = 0;

            for (var i = 0; i < 10; i++)

                for (var j = 0; j < 4; j++)
                {
                    valor = Interaction.InputBox("Digite o valor da semana:" + (j + 1), "Entrada de dados");

                    if (valor == "")
                        break;

                    if (Double.TryParse(valor, out vendas[i, j]))
                    {
                        valSemana[j] = Convert.ToDouble(valor);
                        valMes[i] += valSemana[j];
                        valTotal += valSemana[j];

                        listBox1.Items.Add("Total vendido no mês: " + (i + 1) + " Semana: " + (j + 1) + " R$ " + valSemana[j] + "\n");

                        if (j == 3)
                        {
                            listBox1.Items.Add(">> Total vendido no mês: " + "R$ " + valMes[i] + "\n");
                        }
                    }
                    else
                    {
                        listBox1.Items.Add("Número inválido!");
                        j--;
                    }
                }
            listBox1.Items.Add("Total de vendas geral: " + "R$ "+valTotal);
        }
    }
 }

