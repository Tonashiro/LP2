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
    public partial class Exercício2 : Form
    {
        public Exercício2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N;
            double H = 0;

            N = Convert.ToInt32(txtNum.Text);

            for (int cont = 1; cont <= N; cont++)
            {
                H += 1.0 / cont;
            }
            MessageBox.Show("Resultado: "+H);
        }
    }
}
