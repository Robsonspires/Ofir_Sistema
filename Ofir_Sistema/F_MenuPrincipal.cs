using System;
using System.IO;
using System.Windows.Forms;

namespace Ofir_Sistema
{
    public partial class F_MenuPrincipal : Form
    {
        public string caminhoDB = Path.Combine(Application.ExecutablePath, "Ofir.db");

        public F_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void CadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void F_MenuPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                FuncoesAuxiliares.SairSistema();
            }
            if (e.KeyChar == (char)Keys.Return)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void F_MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = (FormWindowState)2;
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuncoesAuxiliares.SairSistema();
        }

        private void F_MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Verificar para poder passar pela função SairSistema();
            //FuncoesAuxiliares.SairSistema();  #Pendencia
        }

        private void ocorrênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Ocorrencias f_Ocorrencias = new F_Ocorrencias();
            f_Ocorrencias.ShowDialog();
        }

        private void condomíniosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Pessoa f_Pessoa = new F_Pessoa();
            f_Pessoa.ShowDialog();
            //this.Hide();
        }
    }
}
