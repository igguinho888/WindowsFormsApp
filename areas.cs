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
    public partial class areas : Form
    {
        public areas()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            // Ajuste o nome do servidor conforme sua instância
            string connectionString = @"Data Source=SEU_SERVIDOR;Initial Catalog=CJ3027651PR2;Integrated Security=True";

            // Query de inserção compatível com a tabela areas (Nome, Tipo, Capacidade, Responsavel, Observacoes)
            string sql = "INSERT INTO areas (Nome, Tipo, Capacidade, Responsavel, Observacoes) " +
                         "VALUES (@Nome, @Tipo, @Capacidade, @Responsavel, @Observacoes)";

            // Pegue os valores dos controles do seu form (troque os nomes se necessário)
            string nome = txbarea.Text.Trim();
            string tipo = txbtipolocal.Text.Trim();         // ou comboBoxTipo.SelectedItem.ToString();
            string responsavel = txbresponsavel.Text.Trim();
            string observacoes = txbobservacoes.Text.Trim();
            string capadidade = txbcapacidadeanimais.Text.Trim();


            // validação básica para Capacidade
            int capacidade = 1;
            if (!int.TryParse(txbcapacidadeanimais.Text.Trim(), out capacidade))
            {
                MessageBox.Show("Informe um número inteiro válido no campo Capacidade.", "Capacidade inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Capacidade", capacidade);
                    cmd.Parameters.AddWithValue("@Responsavel", responsavel);
                    cmd.Parameters.AddWithValue("@Observacoes", observacoes);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Área cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpar campos (opcional)
                    txbarea.Text = "";
                    txbtipolocal.Text = "";
                    txbcapacidadeanimais.Text = "";
                    txbresponsavel.Text = "";
                    txbobservacoes.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar área: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
