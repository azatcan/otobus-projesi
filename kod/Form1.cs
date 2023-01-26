using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data.Common;

namespace Otobüs_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-MR19S3V;Initial Catalog=OtobusDB;Integrated Security=True";
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MR19S3V;Initial Catalog=OtobusDB;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public ListView lv = new ListView();
        SqlCommand komut = new SqlCommand();
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbOtobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbOtobus.Text)
            {
                case "Trevago":KoltukDoldur(8, false);
                    break;
                case "Setra":KoltukDoldur(10, true);
                    break;
                case "Neoplan":KoltukDoldur(10, false);
                    break;
                
            }
            void KoltukDoldur(int sira,bool arkaBesliMi)
            {
                yavaslat:
                foreach(Control ctrl in this.Controls)
                {
                    if (ctrl is Button)
                    {
                        Button btn = ctrl as Button;
                        if (btn.Text == "Ara")
                        {
                            continue;
                        }
                        else
                        {
                            this.Controls.Remove(ctrl);
                            goto yavaslat;
                        }
                    }
                }
                int KoltukNo = 1;
                for(int i = 0; i < sira ; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (arkaBesliMi == true)
                        {
                            if (i !=sira-1 && j == 2)
                            {
                                continue;
                            }                          
                        }
                        else
                        {
                            if (j == 2)
                            
                                continue;
                            
                        }
                      
                        Button Koltuk = new Button();
                        Koltuk.Height = Koltuk.Width = 40;
                        Koltuk.Top = 30 + (i * 45);
                        Koltuk.Left = 5 + (j * 45);
                        Koltuk.Text = KoltukNo.ToString();
                        KoltukNo++;
                        Koltuk.ContextMenuStrip = contextMenuStrip1;
                        Koltuk.MouseDown += Koltuk_MouseDown; ;
                        this.Controls.Add(Koltuk);

                    }
                }
            }
        }
        Button tiklanan;
        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
        }

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbOtobus.SelectedIndex==-1 || cmbNereden.SelectedIndex==-1 || cmbNereye.SelectedIndex == -1)
            {
                MessageBox.Show("lütfen önce gerekli alanları doldurunuz");
                return;

            }
            ListViewItem lvi = new ListViewItem();
            Kayıtformu kf = new Kayıtformu();
            DialogResult sonuc = kf.ShowDialog();
            if (sonuc == DialogResult.OK)
            {

                lvi.Text = string.Format("{0} {1}", kf.txtİsim.Text, kf.txtSoyisim.Text);

                lvi.SubItems.Add(kf.mskdTelefon.Text);
                if (kf.rdbBay.Checked)
                {
                    lvi.SubItems.Add("BAY");
                    tiklanan.BackColor = Color.Blue;
                }
                if (kf.rdbBayan.Checked)
                {
                    lvi.SubItems.Add("BAYAN");
                    tiklanan.BackColor = Color.Red;
                }
                listView3.Items.Add(lvi);
            }
            
            
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sefer a = new Sefer();
            var stringdatepicker = a.dtpTarih1.Text;
            var converteddate = Convert.ToDateTime(stringdatepicker);
            
            Kayıtformu b = new Kayıtformu();
            var telefon = b.mskdTelefon.Text;
            
            ListViewItem lvi = new ListViewItem();
            SqlConnection baglanti = new SqlConnection(conString);
            
            string querysefer = $@"select top 1 * from sefer 
                where otobus_adi='{cmbOtobus.Text}'  
                and Nereden='{cmbNereden.Text}' 
                and Nereye='{cmbNereye.Text}' 
                and convert(date,Tarih,105)='{converteddate.ToString("yyyy-MM-dd")}'
            ";
            try
            {
                SqlCommand getsefercommand = new SqlCommand(querysefer, baglanti);
                baglanti.Open();
                var result = getsefercommand.ExecuteReader();
                while (result.Read())
                {

                    
                    
                    MessageBox.Show(result["otobus_adi"] + ",  " + result["Nereden"] + ",  " + result["Nereye"]);

                    
                    lvi.SubItems.Add(cmbNereden.Text);
                    lvi.SubItems.Add(cmbNereye.Text);
                    lvi.SubItems.Add(tiklanan.Text);
                    lvi.SubItems.Add(dtpTarih.Text);
                    lvi.SubItems.Add(nudFiyat.Value.ToString());
                    listView1.Items.Add(lvi);
                    
                   
                }

            }
            catch (Exception)
            {

                throw;
            }
           

            if (a.comboBox1.Text == cmbOtobus.Text && a.cmbNereden1.Text == cmbNereden.Text && a.cmbNereye1.Text == cmbNereye.Text && a.dtpTarih1.Text == dtpTarih.Text )
            {

                
                
                
            }
            else
            {

            }
            
        }

 

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void cmbNereden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btnSefer_Click(object sender, EventArgs e)
        {
            Sefer kf = new Sefer();
            DialogResult sonuc = kf.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(kf.otobusad);
                lvi.SubItems.Add(kf.nereden);
                lvi.SubItems.Add(kf.nereye);
                lvi.SubItems.Add(kf.Tarih);
                listView2.Items.Add(lvi);
            }
        }

    }
}
