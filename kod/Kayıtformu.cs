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

namespace Otobüs_Projesi
{
    public partial class Kayıtformu : Form
    {
        public Kayıtformu()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-MR19S3V;Initial Catalog=OtobusDB;Integrated Security=True";
        
        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public string isim, telefon;

        

        private void btnTamam_Click(object sender, EventArgs e)
        {
            string gender = string.Empty;
            if (rdbBay.Checked)
                gender = "Bay";
            else
                gender = "Bayan";
            this.DialogResult = DialogResult.OK;
            this.Close();
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            if (baglanti.State == System.Data.ConnectionState.Open)
            {
                string query = $"insert into MusteriBilgi Values('{txtİsim.Text}','{txtSoyisim.Text}','{mskdTelefon.Text}','{gender}')";
                SqlCommand komut = new SqlCommand(query, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                isim = txtİsim.Text + " " + txtSoyisim.Text;
                telefon = mskdTelefon.Text;
            }
        }
    }
}
