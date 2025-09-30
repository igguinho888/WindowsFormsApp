namespace WindowsFormsApp1
{
    partial class FrmtipoA
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
            this.txbalimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbcategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbalimento
            // 
            this.txbalimento.Location = new System.Drawing.Point(21, 52);
            this.txbalimento.Name = "txbalimento";
            this.txbalimento.Size = new System.Drawing.Size(100, 20);
            this.txbalimento.TabIndex = 0;
            this.txbalimento.TextChanged += new System.EventHandler(this.txbalimento_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME DO ALIMENTO";
            // 
            // cbbcategoria
            // 
            this.cbbcategoria.FormattingEnabled = true;
            this.cbbcategoria.Location = new System.Drawing.Point(21, 105);
            this.cbbcategoria.Name = "cbbcategoria";
            this.cbbcategoria.Size = new System.Drawing.Size(121, 21);
            this.cbbcategoria.TabIndex = 2;
            this.cbbcategoria.Text = "FORRAGEM";
            this.cbbcategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "CATEGORIA / TIPO GERAL";
            // 
            // FrmtipoA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbcategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbalimento);
            this.Name = "FrmtipoA";
            this.Text = "FrmtipoA";
            this.Load += new System.EventHandler(this.FrmtipoA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbalimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbcategoria;
        private System.Windows.Forms.Label label2;
    }
}