using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ofir_Sistema
{
    static class FuncoesAuxiliares
    {
        
        public static void SairSistema()
        {
            var confirmaSair = MessageBox.Show("Confirma a Saída do Sistema?", "Sair",
                                    MessageBoxButtons.YesNo);
            if (confirmaSair == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }
        public static void FecharForm(Form activeForm)
        {
            var confirmaSair = MessageBox.Show("Confirma Fechamento?", "Fechar",
                                    MessageBoxButtons.YesNo);
            if (confirmaSair == DialogResult.Yes)
            {
                activeForm.Close();
            }
        }
    }
}
