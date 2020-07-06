using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql; // Incluir o provedor do SQL Server

namespace PAluno
{
    public partial class frmPrincipal : Form
    {
        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=DESKTOP-SOMBJMI\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de SQL\n\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro geral\n\n" + ex.Message);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmCidade"];
            if (fc != null) fc.Close();

            frmCidade frmCid = new frmCidade();
            frmCid.MdiParent = this;
            frmCid.WindowState = FormWindowState.Maximized;
            frmCid.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frmAluno"];
            if (fc != null) fc.Close();

            frmAluno frmAlu = new frmAluno();
            frmAlu.MdiParent = this;
            frmAlu.WindowState = FormWindowState.Maximized;
            frmAlu.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abbxSobre sobre = new abbxSobre();
            sobre.Show();
        }
    }
}
