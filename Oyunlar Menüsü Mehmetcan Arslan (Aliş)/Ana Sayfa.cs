using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyunlar_Menüsü_Mehmetcan_Arslan__Aliş_
{
    public partial class Ana_Sayfa : Form
    {
        public Ana_Sayfa()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            X_Ball frm4 = new X_Ball();
            frm4.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hesap_Makinesi hsp = new Hesap_Makinesi();
            hsp.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Yılan_Oyunu yln = new Yılan_Oyunu();
            yln.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Mayın_Tarlası xbll = new Mayın_Tarlası();
            xbll.Show();
            this.Hide();
        }
    }
}
