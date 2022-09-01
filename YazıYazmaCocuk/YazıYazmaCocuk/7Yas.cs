using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace YazıYazmaCocuk
{
    public partial class _7Yas : Form
    {

        System.Timers.Timer t;
        int h, m, s;
        int sayac=1;
        const int WH = 10;
        bool ciz = false;
        Graphics gr;
        private void Stop_Click(object sender, EventArgs e)
        {
            t.Stop();
            s = 0; m = 0; h = 0;
            txtSure.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            lstKaydet.Items.Add(sayac+"." +"  "+txtSure.Text+"  "+ txtKelimeEkle.Text);
            sayac++;
        }

        private void _7Yas_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            panel1.Enabled = false;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s++;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                txtSure.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ciz = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(ciz)
            {
                if (e.Button== MouseButtons.Left)
                {
                    var brush = new SolidBrush(Color.Black);
                    gr.FillEllipse(brush, e.X, e.Y, WH, WH);
                }
                if(e.Button==MouseButtons.Right)
                {
                    var brush = new SolidBrush(Color.White);
                    gr.FillEllipse(brush, e.X, e.Y, WH, WH);
                }
            }
        }

        private void KlmEkle_Click(object sender, EventArgs e)
        {
            lblKelime.Text = txtKelimeEkle.Text;
            if (txtKelimeEkle.Text==null)
            {
                MessageBox.Show("Lüften Kelime Giriniz!!");
            }
            else
            {
                basla.Enabled = true;
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            lstKaydet.Items.Clear();
        }

        private void basla_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            t.Start();
            panel1.Enabled = true;
            if(txtKelimeEkle.Text==null)
            {
                MessageBox.Show("Lütfen Kelime Giriniz!!");
            }
            else
            {
                basla.Enabled = true;
            }
        }

        public _7Yas()
        {
            InitializeComponent();
            gr = panel1.CreateGraphics();
        }

    }
}
