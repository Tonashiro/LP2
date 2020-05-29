using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmPrincipal
{
    public partial class FormExercício4 : Form
    {
        public FormExercício4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;

            for (var x = 0; x <= rchText.Text.Length - 1; x++)
            {
                if (Char.IsNumber(rchText.Text[x]))
                    contador += 1;
            }

            MessageBox.Show("Caractéres Numéricoos: "+contador);
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int x = 0;

            while (x < rchText.Text.Length)
            {
                if (Char.IsWhiteSpace(rchText.Text[x]))
                {
                    MessageBox.Show("Primeiro carácter branco: "+ (x+1));
                    break;
                }
                x += 1;
            }
        }

        private void btnAlfa_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach (char c in rchText.Text)
            {
                if (Char.IsLetter(c))
                    contador += 1;
            }

            MessageBox.Show("Caractéres Alfabéticos: " + contador);
        }
    }
}
