namespace WindowsFormsApp1
{
    partial class alimento
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
            this.btntipo = new System.Windows.Forms.Button();
            this.btnalimentacao = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnqauntidade = new System.Windows.Forms.Button();
            this.btnunidadedemedida = new System.Windows.Forms.Button();
            this.btnfornecedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btntipo
            // 
            this.btntipo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btntipo.ForeColor = System.Drawing.SystemColors.Control;
            this.btntipo.Location = new System.Drawing.Point(-3, 30);
            this.btntipo.Name = "btntipo";
            this.btntipo.Size = new System.Drawing.Size(210, 33);
            this.btntipo.TabIndex = 1;
            this.btntipo.Text = "TIPO";
            this.btntipo.UseVisualStyleBackColor = false;
            this.btntipo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnalimentacao
            // 
            this.btnalimentacao.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnalimentacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnalimentacao.ForeColor = System.Drawing.SystemColors.Control;
            this.btnalimentacao.Location = new System.Drawing.Point(-3, 69);
            this.btnalimentacao.Name = "btnalimentacao";
            this.btnalimentacao.Size = new System.Drawing.Size(210, 33);
            this.btnalimentacao.TabIndex = 2;
            this.btnalimentacao.Text = "ALIMENTAÇÃO";
            this.btnalimentacao.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.resul_tados__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnqauntidade
            // 
            this.btnqauntidade.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnqauntidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnqauntidade.ForeColor = System.Drawing.SystemColors.Control;
            this.btnqauntidade.Location = new System.Drawing.Point(-3, 108);
            this.btnqauntidade.Name = "btnqauntidade";
            this.btnqauntidade.Size = new System.Drawing.Size(210, 33);
            this.btnqauntidade.TabIndex = 3;
            this.btnqauntidade.Text = "QUANTIDADE";
            this.btnqauntidade.UseVisualStyleBackColor = false;
            // 
            // btnunidadedemedida
            // 
            this.btnunidadedemedida.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnunidadedemedida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnunidadedemedida.ForeColor = System.Drawing.SystemColors.Control;
            this.btnunidadedemedida.Location = new System.Drawing.Point(-3, 147);
            this.btnunidadedemedida.Name = "btnunidadedemedida";
            this.btnunidadedemedida.Size = new System.Drawing.Size(210, 33);
            this.btnunidadedemedida.TabIndex = 4;
            this.btnunidadedemedida.Text = "UNIDADE DE MEDIDA";
            this.btnunidadedemedida.UseVisualStyleBackColor = false;
            // 
            // btnfornecedor
            // 
            this.btnfornecedor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnfornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnfornecedor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnfornecedor.Location = new System.Drawing.Point(-3, 186);
            this.btnfornecedor.Name = "btnfornecedor";
            this.btnfornecedor.Size = new System.Drawing.Size(210, 33);
            this.btnfornecedor.TabIndex = 5;
            this.btnfornecedor.Text = "FORNECEDOR";
            this.btnfornecedor.UseVisualStyleBackColor = false;
            // 
            // alimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnfornecedor);
            this.Controls.Add(this.btnunidadedemedida);
            this.Controls.Add(this.btnqauntidade);
            this.Controls.Add(this.btnalimentacao);
            this.Controls.Add(this.btntipo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "alimento";
            this.Text = "financeiro";
            this.Load += new System.EventHandler(this.financeiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btntipo;
        private System.Windows.Forms.Button btnalimentacao;
        private System.Windows.Forms.Button btnqauntidade;
        private System.Windows.Forms.Button btnunidadedemedida;
        private System.Windows.Forms.Button btnfornecedor;
    }
}