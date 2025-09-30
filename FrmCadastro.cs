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
            // 1. String de conexão (ajuste o Data Source para o nome do seu SQL Server)
            string connectionString = "Data Source=SQLEXPRESS;Initial Catalog=CJ3027651PR2;User ID=aluno;Password=aluno;";
            Debug.WriteLine("obara");


            // 2. Query de inserção
            string sql = "INSERT INTO usuarios (Cpf, DataNascimento, Endereco, Cep, Telefone, Email, Senha) " +
                         "VALUES (@Cpf, @DataNascimento, @Endereco, @CEP, @Telefone, @Email, @Senha)";
            Debug.WriteLine("MAURO");
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        // 3. Passar os valores dos campos
                        cmd.Parameters.AddWithValue("@Cpf", txtCpf.Text);                       
                        cmd.Parameters.AddWithValue("@Datanascimento", txtDatadenasc.Text);
                        cmd.Parameters.AddWithValue("@Endereco", txtEndereço.Text);
                        cmd.Parameters.AddWithValue("@Cep", txtCep.Text);
                        cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);
                        Debug.WriteLine("IGOR");
                        // 4. Abrir conexão e executar
                        con.Open();
                        Debug.WriteLine("IMENSO");
                        cmd.ExecuteNonQuery();
                    }
                    Debug.WriteLine("JJ");
                }

                // 5. Mensagem de sucesso
                MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 6. Abrir próxima tela
                FrmPrincipal form = new FrmPrincipal();
                form.Show();
                this.Hide(); // Esconde o formulário de cadastro
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Lbldtnascimento_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



