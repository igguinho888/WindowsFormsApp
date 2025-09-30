using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void BunifuTileButton1_Click(object sender, EventArgs e)
        {
            areas formareas = new areas();
            formareas.Show();
        }

        private void BunifuTileButton4_Click(object sender, EventArgs e)
        {
            alimento formfinanceiro = new alimento();
            formfinanceiro.Show();
        }

        private void BunifuTileButton5_Click(object sender, EventArgs e)
        {
            usarios formusario = new usarios();
            formusario.Show();
        }

        private void BunifuTileButton3_Click(object sender, EventArgs e)
        {
           saude formsaude = new saude();
            formsaude.Show();
        }

        private void Btncavalo_Click(object sender, EventArgs e)
        {
         
        {
            formsCavalo formCavalos = new formsCavalo();
            formCavalos.Show();
            
            }
            
        }

        private void Btnrelatorios_Click(object sender, EventArgs e)
        {
            relatorio formrelatorios = new relatorio();
            formrelatorios.Show();
        }

        
        private void btnsair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncavalo_Click_1(object sender, EventArgs e)
        {
            formsCavalo form = new formsCavalo();
            form.ShowDialog();
        }

        private void btnsaude_Click(object sender, EventArgs e)
        {

        }

        private void btnalimentacao_Click(object sender, EventArgs e)
        {
            alimento form = new alimento();
            form.ShowDialog();
        }
    }
}
