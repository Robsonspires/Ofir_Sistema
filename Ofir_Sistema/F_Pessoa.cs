using System;
using System.Data.SQLite;
using System.Text;
using System.Windows.Forms;


namespace Ofir_Sistema
{
    public partial class F_Pessoa : Form
    {
        public F_Pessoa()
        {
            InitializeComponent();
        }

        private void bBuscaPessoa_Click(object sender, EventArgs e)
        {
            F_BuscaPessoa f_BuscaPessoa = new F_BuscaPessoa();
            f_BuscaPessoa.ShowDialog();


            //if (BuscaPessoa(F_Login.caminhoDB, tbUsuario.Text, tbSenha.Text))
            //{
            //    F_MenuPrincipal f_MenuPrincipal = new F_MenuPrincipal();
            //    f_MenuPrincipal.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Usuario/senha inválido ou não encontrado, tente novamente.", "Atenção!", MessageBoxButtons.OK);
            //    //tbUsuario.Text = string.Empty;
            //    //tbUsuario.Focus();
            //    //tbSenha.Text = string.Empty;
            //}
        }

        public void CriarTabelaPessoaBasico(String caminho)
        {
            using (SQLiteConnection db = new SQLiteConnection($"Data Source={caminho}"))
            {
                db.Open();

                StringBuilder sb = new StringBuilder();
                sb.Append("CREATE TABLE IF NOT EXISTS 'PessoaBasico(");
                sb.Append("IdPessoa    INTEGER       PRIMARY KEY AUTOINCREMENT,");
                sb.Append("Nome        VARCHAR(70)   NOT NULL,");
                sb.Append("CpfCnpj     VARCHAR(14)   NOT NULL UNIQUE,");
                sb.Append("RgInscricao VARCHAR(15),  ");
                sb.Append("Endereco    VARCHAR(70),  ");
                sb.Append("Bairro      VARCHAR(50),  ");
                sb.Append("Complemento VARCHAR(20),  ");
                sb.Append("Cidade      VARCHAR(50),  ");
                sb.Append("UF          VARCHAR(2),   ");
                sb.Append("CEP         VARCHAR(8),   ");
                sb.Append("Fone        VARCHAR(11),  ");
                sb.Append("Celular     VARCHAR(11),  ");
                sb.Append("Email       VARCHAR(50),  ");
                sb.Append("Obs         VARCHAR(100));");
                SQLiteCommand sql = new SQLiteCommand(sb.ToString(), db);
                sql.ExecuteNonQuery();

                StringBuilder sb1 = new StringBuilder();
                sb1.Append("CREATE TABLE TipoPessoa(  ");
                sb1.Append("IdTipoPessoa     INTEGER PRIMARY KEY AUTOINCREMENT,");
                sb1.Append("IdPessoa         INTEGER REFERENCES PessoaBasico(IdPessoa),");
                sb1.Append("Comdominio       BOOLEAN, ");
                sb1.Append("Condomino        BOLLEAN, ");
                sb1.Append("Fornecedor       BOLLEAN, ");
                sb1.Append("PrestadorServico BOLLEAN, ");
                sb1.Append("Funcionario      BOLLEAN, ");
                sb1.Append("Administrador    BOLLEAN, ");
                sb1.Append("NaoAplicavel     BOLLEAN);");
                SQLiteCommand sql1 = new SQLiteCommand(sb1.ToString(), db);
                sql1.ExecuteNonQuery();

            }
        }

        private void F_Pessoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                if (this.bSair.Focused)
                {
                    FuncoesAuxiliares.FecharForm(ActiveForm);
                }
                else
                {
                    this.bSair.Focus();
                }
            }
            if (e.KeyChar == (char)Keys.Return)
            {
                this.SelectNextControl(ActiveControl, true, true, true, true);
            }
            if (e.KeyChar == ((char)Keys.F4))
            {
                F_BuscaPessoa f_BuscaPessoa = new F_BuscaPessoa();
                f_BuscaPessoa.ShowDialog();
            }
        }

        private void bSair_Click(object sender, EventArgs e)
        {
            FuncoesAuxiliares.FecharForm(ActiveForm);
        }


        public bool BuscaPessoa(string caminho, string sUsuario, string sSenha)
        {
            //CriarTabelaPessoaBasico(caminho);

            //using (SQLiteConnection db = new SQLiteConnection($"Data Source={caminho}"))
            //{

            //    // fazer a criação do primeiro usuario #Pendência
            //    db.Open();

            //    StringBuilder sb = new StringBuilder();
            //    sb.Append("SELECT * FROM Usuario ");
            //    sb.Append("WHERE UPPER(Usuario) = @Usuario");

            //    SQLiteCommand sql = new SQLiteCommand(sb.ToString(), db);
            //    sql.Parameters.AddWithValue("@Usuario", sUsuario.ToUpper());
            //    SQLiteDataReader retornoDB = sql.ExecuteReader(); //ExecuteReader() => comando sql que retorna dados por exemplo o select

            //    List<C_Usuario> Usuarios = new List<C_Usuario>();

            //    if (retornoDB.StepCount == 1)
            //    {
            //        while (retornoDB.Read())
            //        {
            //            C_Usuario c_usuario = new C_Usuario
            //            {
            //                IdUsuario = Convert.ToInt32(retornoDB["IdUsuario"]),
            //                Nome = retornoDB["Nome"].ToString(),
            //                Usuario = retornoDB["Usuario"].ToString(),
            //                Senha = retornoDB["Senha"].ToString(),
            //                Status = Convert.ToChar(retornoDB["Status"]),
            //                Nivel = Convert.ToInt16(retornoDB["Nivel"])
            //            };
            //            Usuarios.Add(c_usuario);

            //            if (c_usuario.Senha == sSenha)
            //            {
            //                return true;
            //            }
            //            else
            //            {
            //                return false;
            //            }
            //        }
            //    }
            //}
            return false;
        }

        private class DBPessoaBasico
        {
            public int IdPessoa { get; set; }
            public string Nome { get; set; }
            public string CpfCnpj { get; set;}
            public string RgInscricao { get; set; }
            public string Endereco { get; set; }
            public string Complemento { get; set; }
            public string Cidade { get; set; }
            public string UF { get; set; }
            public string CEP { get; set; }
            public string Fone { get; set; }
            public string Celular { get; set; }
            public string Email { get; set; }
            public string Obs { get; set; }
        }

        public class DBTipoPessoa
        {
            public int IdTipoPessoa { get; set; }
            public int IdPessoa { set; get; }
            public bool Condominio { get; set; }
            public bool Condomino { get; set; }
            public bool Fornecedor { get; set; }
            public bool PrestadorServico { get; set; }
            public bool Funcionario { get; set; }
            public bool Administrador { get; set; }
            public bool NaoAplicavel { get; set; }

        }

        private void bSair_Click_1(object sender, EventArgs e)
        {
        }
    }
}
