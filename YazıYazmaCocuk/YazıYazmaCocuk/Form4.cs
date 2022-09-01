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

namespace YazıYazmaCocuk
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            eklekelime();

        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-D0TJ8CG\\SQLSERVER;Initial Catalog=KelimeEkle;Integrated Security=True");

        private void eklekelime()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select *from KelimeEkle", baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = (oku["id"].ToString());
                listele.SubItems.Add(oku["kelime"].ToString());
                listView1.Items.Add(listele);
            }
            baglantı.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            eklekelime();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand cmd = new SqlCommand("insert into KelimeEkle(kelime) values('"+ekle.Text.ToString()+"')",baglantı);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kaydedildi!!");
            baglantı.Close();
            eklekelime();

        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand cmdKomut = new SqlCommand("Delete From KelimeEkle where id= '" + listView1.SelectedItems[0].SubItems[0].Text"'", baglantı);
            cmdKomut.ExecuteNonQuery();
            baglantı.Close();
            eklekelime()
        }
    }
}
