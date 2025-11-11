using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

  

        private void BunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastrar_Click_1(object sender, EventArgs e)
        { 
        
       
            string connectionString = @"Data Source=SQLExpress;Initial Catalog=CJ3027651PR2;User ID=aluno;Password=aluno;";
            string sql = "INSERT INTO usuarios (Cpf, DataNascimento, Endereco, Cep, Telefone, Email, Senha) " +
                         "VALUES (@cpf, @dataNascimento, @endereco, @cep, @telefone, @email, @senha)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@cpf", txtCpf.Text);
                    cmd.Parameters.AddWithValue("@dataNascimento", txtDatadenasc.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtendereco.Text);
                    cmd.Parameters.AddWithValue("@cep", txtCep.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery(); // apenas executa o INSERT
                        MessageBox.Show("Usuário cadastrado com sucesso!",
                                        "Cadastro Concluído",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        // Abrir tela principal, se quiser
                        FrmPrincipal form = new FrmPrincipal();
                        form.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                    }
                }
            }
        }


        private void Lbldtnascimento_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtendereço_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



