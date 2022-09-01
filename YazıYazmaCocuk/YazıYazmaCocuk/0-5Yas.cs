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
    public partial class Form2 : Form
    {
        System.Timers.Timer t;
        int h, m, s;
        
        public Form2()
        {
            InitializeComponent();
            gr = panel1.CreateGraphics();
        }
        Random rastgeleHarf = new Random();
        int harfDegeri;
        const int WH = 10;
        bool ciz = false;
        Graphics gr;
        private void Form2_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            harfDegeri = rastgeleHarf.Next(65, 91);
            char karakter = Convert.ToChar(harfDegeri);
            //rasHarf.Text = harfDegeri.ToString();
            panel1.Enabled = false;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s++;
                if (s==60)
                {
                    s = 0;
                    m += 1;
                }
                if(m==60)
                {
                    m = 0;
                    h += 1;
                }
                txtResult.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));


        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ciz = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ciz)
            {
                if (e.Button == MouseButtons.Left)
                {
                    var brush = new SolidBrush(Color.Black);
                    gr.FillEllipse(brush, e.X, e.Y, WH, WH);
                }
                if (e.Button == MouseButtons.Right)
                {
                    var brush = new SolidBrush(Color.White);
                    gr.FillEllipse(brush, e.X, e.Y, WH, WH);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
        }

        private void btStp_Click(object sender, EventArgs e)
        {
            lb1.Items.Add(txtResult.Text+ "  "+ rasHarf.Text);
            t.Stop();
            s = 0;
            m = 0;
            h = 0;
            txtResult.Text = String.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            rasHarf.Text= String.Empty;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            t.Start();
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
            harfDegeri = rastgeleHarf.Next(65, 91);
            char karakter = Convert.ToChar(harfDegeri);
            rasHarf.Text = karakter.ToString();
            panel1.Enabled = true;
        }
    }
}
