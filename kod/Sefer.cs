using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Otobüs_Projesi
{
    public partial class Sefer : Form
    {
        public Sefer()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-MR19S3V;Initial Catalog=OtobusDB;Integrated Security=True";
        private void Sefer_Load(object sender, EventArgs e)
        {

        }

    
        
        public string otobusad;
        public string nereden;
        public string nereye;
        public string Tarih;
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
           

            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                string query = $"insert into sefer Values('{comboBox1.Text}','{cmbNereden1.Text}','{cmbNereye1.Text}','{dtpTarih1.Text}')";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.ExecuteNonQuery();
                otobusad = comboBox1.Text;
                nereden = cmbNereden1.Text;
                nereye = cmbNereye1.Text;
                Tarih = dtpTarih1.Text;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
