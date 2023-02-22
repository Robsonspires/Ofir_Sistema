namespace Ofir_Sistema
{
    partial class F_Pessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Pessoa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bBuscaPessoa = new System.Windows.Forms.Button();
            this.bSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.bBuscaPessoa);
            this.panel1.Controls.Add(this.bSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 47);
            this.panel1.TabIndex = 2;
            // 
            // bBuscaPessoa
            // 
            this.bBuscaPessoa.Location = new System.Drawing.Point(3, 3);
            this.bBuscaPessoa.Name = "bBuscaPessoa";
            this.bBuscaPessoa.Size = new System.Drawing.Size(124, 40);
            this.bBuscaPessoa.TabIndex = 3;
            this.bBuscaPessoa.Text = "Busca Pessoa - F4";
            this.bBuscaPessoa.UseVisualStyleBackColor = true;
            this.bBuscaPessoa.Click += new System.EventHandler(this.bBuscaPessoa_Click);
            // 
            // bSair
            // 
            this.bSair.Location = new System.Drawing.Point(675, 7);
            this.bSair.Name = "bSair";
            this.bSair.Size = new System.Drawing.Size(124, 36);
            this.bSair.TabIndex = 2;
            this.bSair.Text = "&Sair";
            this.bSair.UseVisualStyleBackColor = true;
            this.bSair.Click += new System.EventHandler(this.bSair_Click);
            // 
            // F_Pessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(811, 468);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Pessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Pessoa";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_Pessoa_KeyPress);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bBuscaPessoa;
        private System.Windows.Forms.Button bSair;
    }
}