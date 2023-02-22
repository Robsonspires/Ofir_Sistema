using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace Ofir_Sistema
{
    public partial class F_Login : Form
    {
        public string caminhoDB = Path.Combine(Application.StartupPath, "Ofir.db");

        public F_Login()
        {
            InitializeComponent();
          
        }

        private void bSair_Click(object sender, EventArgs e)
        {
            FuncoesAuxiliares.SairSistema();
        }

        private void bLogar_Click(object sender, EventArgs e)
        {

            if (BuscaUsuario(caminhoDB, tbUsuario.Text, tbSenha.Text))
            {
                F_MenuPrincipal f_MenuPrincipal = new F_MenuPrincipal();
                f_MenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario/senha inválido ou não encontrado, tente novamente.", "Atenção!", MessageBoxButtons.OK);
                tbSenha.Text = string.Empty;
                tbUsuario.Text = string.Empty;
                tbUsuario.Focus();
            }
        }


        private void F_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                if (bSair.Focused)
                {
                    FuncoesAuxiliares.SairSistema();
                }
                else
                {
                    bSair.Focus();
                }
            }
            if (e.KeyChar == (char)Keys.Return)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        public void CriarTabelaUsuario(String caminho)
        {
            /////////////////////////////////////////////////////////////////////
            // Esta é a primeira tabela que o sistema verifica, e neste caso é //
            // Criado o banco de dados e a tabela usuário.                     //
            /////////////////////////////////////////////////////////////////////

            //using sempre fecha o banco/arquivo mesmo se der algum erro
            //se o banco de dados não existir ele será criado.

            using (SQLiteConnection db = new SQLiteConnection($"Data Source={caminho}"))
            {
                db.Open();

                StringBuilder sb = new StringBuilder();
                sb.Append("CREATE TABLE IF NOT EXISTS Usuario (");
                sb.Append("IdUsuario INTEGER      PRIMARY KEY AUTOINCREMENT,");
                sb.Append("Nome      VARCHAR (30) NOT NULL,");
                sb.Append("Usuario   VARCHAR (20) NOT NULL UNIQUE,");
                sb.Append("Senha     VARCHAR (20) NOT NULL,");
                sb.Append("Status    VARCHAR (1)  NOT NULL,");
                sb.Append("Nivel     INTEGER      NOT NULL);");

                SQLiteCommand sql = new SQLiteCommand(sb.ToString(), db);
                sql.ExecuteNonQuery(); //NonQuey => comando sql que não retorna, por exemplo o select
            }

        }
        public bool BuscaUsuario(string caminho, string sUsuario, string sSenha)
        {
            CriarTabelaUsuario(caminho);

            using (SQLiteConnection db = new SQLiteConnection($"Data Source={caminho}"))
            {

                // fazer a criação do primeiro usuario #Pendência
                db.Open();

                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * FROM Usuario ");
                sb.Append("WHERE UPPER(Usuario) = @Usuario");

                SQLiteCommand sql = new SQLiteCommand(sb.ToString(), db);
                sql.Parameters.AddWithValue("@Usuario", sUsuario.ToUpper());
                SQLiteDataReader retornoDB = sql.ExecuteReader(); //ExecuteReader() => comando sql que retorna dados por exemplo o select

                List<DB_Usuario> Usuarios = new List<DB_Usuario>();

                if (retornoDB.StepCount == 1)
                {
                    while (retornoDB.Read())
                    {
                        DB_Usuario db_usuario = new DB_Usuario
                        {
                            IdUsuario = Convert.ToInt32(retornoDB["IdUsuario"]),
                            Nome = retornoDB["Nome"].ToString(),
                            Usuario = retornoDB["Usuario"].ToString(),
                            Senha = retornoDB["Senha"].ToString(),
                            Status = Convert.ToChar(retornoDB["Status"]),
                            Nivel = Convert.ToInt16(retornoDB["Nivel"])
                        };
                        Usuarios.Add(db_usuario);

                        if (db_usuario.Senha == sSenha)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return false;
        }

        private class DB_Usuario
        {
            public int IdUsuario { get; set; }
            public string Nome { get; set; }
            public string Usuario { get; set; }
            public string Senha { get; set; }
            public char Status { get; set; }
            public short Nivel { get; set; }

        }

    }
    
}

