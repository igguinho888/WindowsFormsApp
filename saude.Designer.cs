namespace WindowsFormsApp1
{
    partial class saude
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
            this.SuspendLayout();
            // 
            // saude
            // 
            this.ClientSize = new System.Drawing.Size(1061, 565);
            this.Name = "saude";
            this.Load += new System.EventHandler(this.Saude_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbbcavalo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.DateTimePicker dtpdataatendimento;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox txbatendimento;
        private Bunifu.Framework.UI.BunifuCustomLabel lbltpatendimento;
        private System.Windows.Forms.TextBox txbdescricao;
        private Bunifu.Framework.UI.BunifuCustomLabel lbldescricao;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TextBox txbveterinario;
        private System.Windows.Forms.TextBox txbobservacoes;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}