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
using System.Data.Sql;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=SANGOVS;Initial Catalog=PDM;User ID=pdmuser;Password=Sango-123");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chk_kart.Checked = true;
            txt_Sicil.Focus();



        }

        private void btn_src_Click(object sender, EventArgs e)
        {

            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            chk_koli.Checked = false;
            chk_poset.Checked = true;
            chk_yag.Checked = true;

            chk_koli.Enabled = true;
            chk_poset.Enabled = true;
            chk_yag.Enabled = true;

            label6.Text = "";
            label9.Text = "";
            label10.Text = "";


            label7.Visible = true;
            label5.Visible = true;
            label8.Visible = true;

            if (txt_Sicil.Text=="")
            {
                MessageBox.Show("Lütfen kart okutunuz veya sicil numaranızı giriniz", "Sango Ramazan Paket Dağıtım" );
            }


            if (chk_kart.Checked == true)
            {
                SqlCommand sqlcard = new SqlCommand("SELECT * FROM[PDM].[dbo].[VW_B_ADM_PAKETDAGITIM] where CardID like '%" + txt_Sicil.Text + "'", baglanti);
                baglanti.Open();
                SqlDataReader kartreader = sqlcard.ExecuteReader();
                if (kartreader.Read())
                {
                    label7.Text = kartreader["SicilNo"].ToString();
                    label5.Text = kartreader["ADI_SOYADI"].ToString();
                    label8.Text = kartreader["Bolum"].ToString();

                    baglanti.Close();

                }

            }
            else if (chk_kart.Checked == false)
            {
                SqlCommand sqlsicil = new SqlCommand("SELECT * FROM [PDM].[dbo].[VW_B_ADM_PAKETDAGITIM] where SicilNo='" + txt_Sicil.Text + "'", baglanti);
                baglanti.Open();

                SqlDataReader sicilread = sqlsicil.ExecuteReader();

                if (sicilread.Read())
                {
                    label7.Text = sicilread["SicilNo"].ToString();
                    label5.Text = sicilread["ADI_SOYADI"].ToString();
                    label8.Text = sicilread["Bolum"].ToString();

                    baglanti.Close();


                }
                else
                {
                    label5.Visible = false;
                    label8.Visible = false;

                    label7.Text = "Geçersiz Sicil Numarası Girildi";
                    baglanti.Close();

                }

         
            }

            SqlCommand sqlsecili = new SqlCommand("SELECT top(1) *  FROM [PDM].[dbo].[Ramazan] where sicil='" + label7.Text + "' order by id desc ", baglanti);
            baglanti.Open();
            SqlDataReader sqlcheck = sqlsecili.ExecuteReader();

            if (sqlcheck.Read())
            {    

                label6.Text = sqlcheck["Koli"].ToString();
                label9.Text = sqlcheck["Yag"].ToString();
                label10.Text = sqlcheck["Poset"].ToString();
                baglanti.Close();

            }


            if (label6.Text == "1")
            {
                chk_koli.Checked = true;
                chk_koli.Enabled = false;

            }

            if (label9.Text == "1")
            {

                chk_yag.Checked = true;
                chk_yag.Enabled = false;

            }
            if (label10.Text == "1")
            {
                chk_poset.Checked = true;
                chk_poset.Enabled = false;
            }
            baglanti.Close();


            txt_Sicil.Text = "";

            txt_Sicil.Focus();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            txt_Sicil.Focus();
            if (label5.Text == "")
            {
                MessageBox.Show("Lütfen sicil numarasını giriniz", "Sango Ramazan Paket Uyarı");
            }


            else if (chk_koli.Checked == false && chk_yag.Checked == false && chk_poset.Checked == false)
            {
                MessageBox.Show("Lütfen paket seçimi yapınız", "Sango Ramazan Paket Uyarı");
            }

            else
            {
                try
                {

                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into Ramazan (sicil, Koli, Poset, Yag) values (@sicilno,@paket1,@paket2,@paket3)", baglanti);
                    komut.Parameters.AddWithValue("@sicilno", label7.Text);
                    komut.Parameters.AddWithValue("@paket1", koli);
                    komut.Parameters.AddWithValue("@paket2", poset);
                    komut.Parameters.AddWithValue("@paket3", yag);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                catch (Exception)
                {


                }
                MessageBox.Show("Kayıt başarılı bir şekilde eklenmiştir. ", "Sango Ramazan Koli", MessageBoxButtons.OK);

                label5.Visible = false;
                label7.Visible = false;
                label8.Visible = false;

                chk_koli.Checked = false;
                chk_poset.Checked = true;
                chk_yag.Checked = true;

                chk_koli.Enabled = true;
                chk_poset.Enabled = true;
                chk_yag.Enabled = true;

                label6.Text = "";
                label9.Text = "";
                label10.Text = "";


            }


        }

        public string koli = "";
        private void chk_koli_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_koli.Checked == true)
            {
                koli = "1";
            }
            else if (chk_koli.Checked == false)
            {
                koli = "0";
            }
            else
            {
                koli = "HATA!";
            }

        }

        public string yag = "";
        private void chk_yag_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_yag.Checked == true)
            {
                yag = "1";
            }
            else if (chk_yag.Checked == false)
            {
                yag = "0";

            }
            else
            {
                yag = "HATA!";
            }


        }
        public string poset = "";
        private void chk_poset_CheckedChanged(object sender, EventArgs e)
        {

            if (chk_poset.Checked == true)
            {
                poset = "1";
            }
            else if (chk_poset.Checked == false)
            {
                poset = "0";

            }
            else
            {
                poset = "HATA!";
            }

        }

        private void chk_kart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_Sicil_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
