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
    public partial class FrmtipoA : Form
    {
        public FrmtipoA()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmtipoA_Load(object sender, EventArgs e)
        {
            cbbcategoria.Items.AddRange(new string[]
    {
        "Forragem",
        "Grãos e cereais",
        "Leguminosas / Proteicos",
        "Frutas e Hortaliças",
        "Raízes e Tubérculos",
        "Suplementos e Minerais"
    });
        }

        private void txbalimento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



