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
    public partial class FormExercício2 : Form
    {
        public FormExercício2()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtPalavra1.Text, txtPalavra2.Text, true) == 0)
                MessageBox.Show("São iguais.");
            else
                MessageBox.Show("São diferentes");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            // casa - meio = 2
            
            int meio = txtPalavra2.Text.Length / 2;

            txtPalavra2.Text = txtPalavra2.Text.Substring(0, meio) + 
                txtPalavra1.Text + 
                txtPalavra2.Text.Substring(meio, txtPalavra2.Text.Length-meio);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int meio = txtPalavra1.Text.Length / 2;

            txtPalavra2.Text = txtPalavra1.Text.Insert(meio, "**");
        }

        private void FormExercício2_Load(object sender, EventArgs e)
        {

        }
    }
}
