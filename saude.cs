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
    public partial class saude : Form
    {
        public saude()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SQLExpress;Initial Catalog=CJ3027651PR2;User ID=aluno;Password=aluno;";

            // Coleta dos dados dos campos do formulário
            int idCavalo;
            DateTime dataAtendimento;
            string t = txbatendimento.Text;
            string descricao = txbdescricao.Text;
            string veterinario = txbveterinario.Text;
            string observacoes = txbobservacoes.Text;

            // Validação básica de entrada
            if (!int.TryParse(cbbcavalo.Text, out idCavalo))
            {
                MessageBox.Show("Informe um número válido no campo ID do Cavalo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(dtpdataatendimento.Text, out dataAtendimento))
            {
                MessageBox.Show("Informe uma data válida no campo Data de Atendimento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Query de inserção no banco
            string sql = @"
        INSERT INTO saude (IdCavalo, DataAtendimento, Tipo, Descricao, Veterinario, Observacoes)
        VALUES (@IdCavalo, @DataAtendimento, @Tipo, @Descricao, @Veterinario, @Observacoes)
    ";

            // Conexão e comando SQL
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@IdCavalo", idCavalo);
                    cmd.Parameters.AddWithValue("@DataAtendimento", dataAtendimento);
                    cmd.Parameters.AddWithValue("@Tipo", t);
                    cmd.Parameters.AddWithValue("@Descricao", descricao);
                    cmd.Parameters.AddWithValue("@Veterinario", veterinario);
                    cmd.Parameters.AddWithValue("@Observacoes", observacoes);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro de saúde cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpar campos após cadastro (opcional)
                        cbbcavalo.SelectedIndex = -1;
                        dtpdataatendimento.Value = DateTime.Now;
                        txbatendimento.Clear();
                        txbdescricao.Clear();
                        txbveterinario.Clear();
                        txbobservacoes.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar no banco de dados:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

       