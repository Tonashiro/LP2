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
    public partial class Exercício1 : Form
    {
        public Exercício1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cont, qtde = 0;

            for(cont = 0; cont < rchText.Text.Length; cont++){
                if (Char.IsWhiteSpace(rchText.Text[cont]))
                    qtde++;
            }

            MessageBox.Show("A quantidade de espaços em branco é: "+ qtde);
        }

        private void rchText_TextChanged(object sender, EventArgs e)
        {
            if (rchText.Text.Length > 100)
            {
                MessageBox.Show("Insira no máximo 100 carácteres!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cont = 0;

            foreach (char R in rchText.Text)
            {
                if (R == 'R')
                    cont++;
            }

            MessageBox.Show("Qtde. de caractéres 'R': " + cont);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cont, repetida = 0, qtde = 0, comprimento;
            string s = rchText.Text;
            char[] arr = s.ToCharArray();
            comprimento = s.Length;
            for (cont = comprimento - 1; cont >= 1; cont--)
            {
                if (arr[cont -1] == arr[cont])
                {
                    repetida = rchText.Text[cont - 1] + rchText.Text[cont];
                    if (arr[cont - 1] + arr[cont] == repetida)
                    {
                        qtde++;
                    }
                }

            }
            MessageBox.Show("Qtde. de repetições: "+qtde);
        }
    }
}
