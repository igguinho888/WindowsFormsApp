namespace WindowsFormsApp1
{
    partial class formsCavalo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formsCavalo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuTextbox2 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextbox3 = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Captura_de_tela_2025_09_02_111817;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.Gold;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(12, 150);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(176, 21);
            this.bunifuTextbox1.TabIndex = 1;
            this.bunifuTextbox1.text = "Bunifu TextBox";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(9, 131);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(62, 16);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Cadastro";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 179);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(39, 16);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Peso";
            // 
            // bunifuTextbox2
            // 
            this.bunifuTextbox2.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox2.BackgroundImage")));
            this.bunifuTextbox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox2.ForeColor = System.Drawing.Color.Gold;
            this.bunifuTextbox2.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox2.Icon")));
            this.bunifuTextbox2.Location = new System.Drawing.Point(15, 198);
            this.bunifuTextbox2.Name = "bunifuTextbox2";
            this.bunifuTextbox2.Size = new System.Drawing.Size(176, 21);
            this.bunifuTextbox2.TabIndex = 6;
            this.bunifuTextbox2.text = "Bunifu TextBox";
            // 
            // bunifuTextbox3
            // 
            this.bunifuTextbox3.BackColor = System.Drawing.Color.Silver;
            this.bunifuTextbox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox3.BackgroundImage")));
            this.bunifuTextbox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox3.ForeColor = System.Drawing.Color.Gold;
            this.bunifuTextbox3.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox3.Icon")));
            this.bunifuTextbox3.Location = new System.Drawing.Point(15, 238);
            this.bunifuTextbox3.Name = "bunifuTextbox3";
            this.bunifuTextbox3.Size = new System.Drawing.Size(176, 21);
            this.bunifuTextbox3.TabIndex = 7;
            this.bunifuTextbox3.text = "Bunifu TextBox";
            this.bunifuTextbox3.OnTextChange += new System.EventHandler(this.bunifuTextbox3_OnTextChange_1);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Gold;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(12, 219);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(77, 16);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Proprietário";
            // 
            // formsCavalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 444);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuTextbox3);
            this.Controls.Add(this.bunifuTextbox2);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formsCavalo";
            this.Text = "formsCavalo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private 
            Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox2;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}