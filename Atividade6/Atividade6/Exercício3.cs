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
    public partial class Exercício3 : Form
    {
        public Exercício3()
        {
            InitializeComponent();
        }

        private void txtFrase_TextChanged(object sender, EventArgs e)
        {
            if (txtFrase.Text.Length > 50)
                MessageBox.Show("Insira no máximo 50 carácteres!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int comprimento = txtFrase.Text.Length;
            string main = txtFrase.Text;
            main = main.ToUpper();
            string s = txtFrase.Text;
            s = s.ToUpper();
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            
            s = "";
            main = main.Replace(" ", "");
            
            foreach (char c in arr)
                s = s + c.ToString();
            s = s.Replace(" ", "");
            
            if(s == main)
                MessageBox.Show("É um palíndromo.");
            else
                MessageBox.Show("Não é um palíndromo.");
        }
    }
}
