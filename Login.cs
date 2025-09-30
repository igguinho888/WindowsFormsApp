using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btnentrar_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=sqlexpress;Database=CJ3027651PR2;User Id=aluno;Password=aluno;";
            string Id = txbId.Text;
            string senha = txbsenha.Text;
            int count;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM usuarios WHERE Id=@Id AND Senha=@senha";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    count = cmd.ExecuteReader().HasRows == true ? 1 : 0;
                    
                }
            }
            if (count > 0)
            {
                FrmPrincipal principal = new FrmPrincipal();
                this.Visible = false;
                principal.ShowDialog();
                this.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FrmCadastro form = new FrmCadastro();
            form.ShowDialog();
        }

        private void TxbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txbsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
