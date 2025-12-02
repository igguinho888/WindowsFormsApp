namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnentrar = new System.Windows.Forms.Button();
            this.btncadastrar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbsenha
            // 
            this.txbsenha.Location = new System.Drawing.Point(33, 257);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.Size = new System.Drawing.Size(175, 20);
            this.txbsenha.TabIndex = 11;
            this.txbsenha.TextChanged += new System.EventHandler(this.Txbsenha_TextChanged);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblsenha.ForeColor = System.Drawing.Color.Gold;
            this.lblsenha.Location = new System.Drawing.Point(30, 232);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(44, 13);
            this.lblsenha.TabIndex = 10;
            this.lblsenha.Text = "SENHA";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(33, 191);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(175, 20);
            this.txbId.TabIndex = 9;
            this.txbId.TextChanged += new System.EventHandler(this.TxbId_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuario.ForeColor = System.Drawing.Color.Gold;
            this.lblUsuario.Location = new System.Drawing.Point(30, 166);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(56, 13);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "USUARIO";
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.Black;
            this.btnentrar.ForeColor = System.Drawing.Color.Gold;
            this.btnentrar.Location = new System.Drawing.Point(36, 304);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(172, 50);
            this.btnentrar.TabIndex = 12;
            this.btnentrar.Text = "ENTRAR";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.Btnentrar_Click);
            // 
            // btncadastrar1
            // 
            this.btncadastrar1.BackColor = System.Drawing.Color.Black;
            this.btncadastrar1.ForeColor = System.Drawing.Color.Gold;
            this.btncadastrar1.Location = new System.Drawing.Point(36, 373);
            this.btncadastrar1.Name = "btncadastrar1";
            this.btncadastrar1.Size = new System.Drawing.Size(172, 50);
            this.btncadastrar1.TabIndex = 15;
            this.btncadastrar1.Text = "CADASTRAR";
            this.btncadastrar1.UseVisualStyleBackColor = false;
            this.btncadastrar1.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 513);
            this.Controls.Add(this.btncadastrar1);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lblUsuario);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Button btncadastrar1;
    }
}