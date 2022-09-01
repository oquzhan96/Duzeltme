using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazıYazmaCocuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
            form2sec.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _7Yas formsec = new _7Yas();
            formsec.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"5 Yaş oyununda rastgele A'dan Z'ye kelimeler gelir. Mouse'un sol tiki ile yazılır. Sağ Tiki ile silinir" + Environment.NewLine + @"7 Yaş Oyununun ilkinde rastgele bir kelime yerine kullanıcıdan bir kelime girilmesi istenir ve Okelime yazılır." + Environment.NewLine + @"7 Yaş oyununun ikincisinde ise evebeynden rastgele istediği kadar kelime girilmesi istenir. Bu sayı evebeynlere kalmıştır. Oyun rastgele kelimeleri çocuğa gösterir.");
        }

        private void rastGele_Click(object sender, EventArgs e)
        {
            Form3 formsec = new Form3();
            formsec.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
