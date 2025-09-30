namespace WindowsFormsApp1
{
    partial class FrmCadastro
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
            this.lblcpf = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbldtnascimento = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblendereço = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblsenha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblcep = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblemail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbltelefone = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtDatadenasc = new System.Windows.Forms.TextBox();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(48, 151);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(30, 13);
            this.lblcpf.TabIndex = 2;
            this.lblcpf.Text = "CPF";
            // 
            // lbldtnascimento
            // 
            this.lbldtnascimento.AutoSize = true;
            this.lbldtnascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldtnascimento.Location = new System.Drawing.Point(316, 151);
            this.lbldtnascimento.Name = "lbldtnascimento";
            this.lbldtnascimento.Size = new System.Drawing.Size(146, 13);
            this.lbldtnascimento.TabIndex = 3;
            this.lbldtnascimento.Text = "DATA DE NASCIMENTO";
            this.lbldtnascimento.Click += new System.EventHandler(this.Lbldtnascimento_Click);
            // 
            // lblendereço
            // 
            this.lblendereço.AutoSize = true;
            this.lblendereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblendereço.Location = new System.Drawing.Point(48, 238);
            this.lblendereço.Name = "lblendereço";
            this.lblendereço.Size = new System.Drawing.Size(75, 13);
            this.lblendereço.TabIndex = 4;
            this.lblendereço.Text = "ENDEREÇO";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.Location = new System.Drawing.Point(48, 301);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(49, 13);
            this.lblsenha.TabIndex = 5;
            this.lblsenha.Text = "SENHA";
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcep.Location = new System.Drawing.Point(316, 238);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(31, 13);
            this.lblcep.TabIndex = 6;
            this.lblcep.Text = "CEP";
            this.lblcep.Click += new System.EventHandler(this.BunifuCustomLabel6_Click);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(551, 238);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(48, 13);
            this.lblemail.TabIndex = 7;
            this.lblemail.Text = "E-MAIL";
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefone.Location = new System.Drawing.Point(551, 151);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(71, 13);
            this.lbltelefone.TabIndex = 8;
            this.lbltelefone.Text = "TELEFONE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Captura_de_tela_2025_09_02_122211;
            this.pictureBox1.Location = new System.Drawing.Point(-12, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(913, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(51, 176);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(132, 20);
            this.txtCpf.TabIndex = 17;
            // 
            // txtDatadenasc
            // 
            this.txtDatadenasc.Location = new System.Drawing.Point(319, 176);
            this.txtDatadenasc.Name = "txtDatadenasc";
            this.txtDatadenasc.Size = new System.Drawing.Size(132, 20);
            this.txtDatadenasc.TabIndex = 19;
            // 
            // txtEndereço
            // 
            this.txtEndereço.Location = new System.Drawing.Point(51, 258);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(132, 20);
            this.txtEndereço.TabIndex = 20;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(319, 258);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(132, 20);
            this.txtCep.TabIndex = 21;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(554, 176);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(132, 20);
            this.txtTelefone.TabIndex = 22;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(51, 321);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(132, 20);
            this.txtSenha.TabIndex = 23;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(554, 258);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.Location = new System.Drawing.Point(297, 363);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(176, 40);
            this.BtnCadastrar.TabIndex = 25;
            this.BtnCadastrar.Text = "CADASTRAR";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click_1);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 448);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtEndereço);
            this.Controls.Add(this.txtDatadenasc);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lbltelefone);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblendereço);
            this.Controls.Add(this.lbldtnascimento);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmCadastro";
            this.Text = "FrmCadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblcpf;
        private Bunifu.Framework.UI.BunifuCustomLabel lbldtnascimento;
        private Bunifu.Framework.UI.BunifuCustomLabel lblendereço;
        private Bunifu.Framework.UI.BunifuCustomLabel lblsenha;
        private Bunifu.Framework.UI.BunifuCustomLabel lblcep;
        private Bunifu.Framework.UI.BunifuCustomLabel lblemail;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltelefone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtDatadenasc;
        private System.Windows.Forms.TextBox txtEndereço;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button BtnCadastrar;
    }
}