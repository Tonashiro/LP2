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
    public partial class FormExercício5 : Form
    {
        public FormExercício5()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            Random objRandom = new Random();
            int numero = objRandom.Next(Convert.ToInt32(txtPrimeiro.Text),
                Convert.ToInt32(txtSegundo.Text));

            MessageBox.Show("O número sorteado é: "+ numero);
        }
    }
}
