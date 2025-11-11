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
    public partial class FrmCavalos2 : Form
    {
        public FrmCavalos2()
        {
            InitializeComponent();
        }

        private void FrmCavalos2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel11_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox5_OnTextChange(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            // String de conexão ao banco
            string connectionString = @"Data Source=SQLExpress;Initial Catalog=CJ3027651PR2;User ID=aluno;Password=aluno;";

            // Comando SQL de inserção
            string sql = "INSERT INTO horse (NomeDono, DataNascimento, OndeNasceu, NomeCavalo, IrmaosCavalo, Registrado, Sexo, Raca, Pelagem, Altura, NomePai, NomeMae) " +
                         "VALUES (@NomeDono, @DataNascimento, @OndeNasceu, @NomeCavalo, @IrmaosCavalo, @Registrado, @Sexo, @Raca, @Pelagem, @Altura, @NomePai, @NomeMae)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    // Substitua os nomes dos campos pelos nomes reais dos seus TextBox / DateTimePicker
                    cmd.Parameters.AddWithValue("@NomeDono", txbnomedono.Text);
                    cmd.Parameters.AddWithValue("@DataNascimento", dtpdatanasc.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@OndeNasceu", txbondenasc.Text);
                    cmd.Parameters.AddWithValue("@NomeCavalo", txbnomecav.Text);
                    cmd.Parameters.AddWithValue("@IrmaosCavalo", txbirmaocav.Text);
                    cmd.Parameters.AddWithValue("@Registrado", txbregistro.Text);
                    cmd.Parameters.AddWithValue("@Sexo", txbsexo.Text);
                    cmd.Parameters.AddWithValue("@Raca", txbraca.Text);
                    cmd.Parameters.AddWithValue("@Pelagem", txbpelagem.Text);
                    cmd.Parameters.AddWithValue("@Altura", txbaltura.Text);
                    cmd.Parameters.AddWithValue("@NomePai", txbnomepai.Text);
                    cmd.Parameters.AddWithValue("@NomeMae", txbnomemae.Text);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cavalo cadastrado com sucesso!",
                                        "Cadastro Concluído",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao cadastrar cavalo: " + ex.Message,
                                        "Erro",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        FrmPrincipal form = new FrmPrincipal();
                        form.ShowDialog();

                    }
                }
            }
        }
    }
}
