namespace Ofir_Sistema
{
    partial class F_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.bLogar = new System.Windows.Forms.Button();
            this.bConfigurar = new System.Windows.Forms.Button();
            this.bSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ofir_Sistema.Properties.Resources.Ofir_Dark_Blue1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(22, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(85, 261);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(187, 20);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.Tag = "";
            this.tbUsuario.Text = "Ofir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(22, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(85, 287);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(187, 20);
            this.tbSenha.TabIndex = 1;
            this.tbSenha.Text = "1340";
            // 
            // bLogar
            // 
            this.bLogar.Location = new System.Drawing.Point(25, 313);
            this.bLogar.Name = "bLogar";
            this.bLogar.Size = new System.Drawing.Size(247, 46);
            this.bLogar.TabIndex = 2;
            this.bLogar.Text = "&Logar";
            this.bLogar.UseVisualStyleBackColor = true;
            this.bLogar.Click += new System.EventHandler(this.bLogar_Click);
            // 
            // bConfigurar
            // 
            this.bConfigurar.Location = new System.Drawing.Point(24, 369);
            this.bConfigurar.Name = "bConfigurar";
            this.bConfigurar.Size = new System.Drawing.Size(121, 37);
            this.bConfigurar.TabIndex = 4;
            this.bConfigurar.Text = "&Configurar";
            this.bConfigurar.UseVisualStyleBackColor = true;
            // 
            // bSair
            // 
            this.bSair.Location = new System.Drawing.Point(151, 369);
            this.bSair.Name = "bSair";
            this.bSair.Size = new System.Drawing.Size(121, 37);
            this.bSair.TabIndex = 3;
            this.bSair.Text = "&Sair";
            this.bSair.UseVisualStyleBackColor = true;
            this.bSair.Click += new System.EventHandler(this.bSair_Click);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.bSair);
            this.Controls.Add(this.bConfigurar);
            this.Controls.Add(this.bLogar);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login do Sistema";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_Login_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Button bLogar;
        private System.Windows.Forms.Button bConfigurar;
        private System.Windows.Forms.Button bSair;
    }
}

