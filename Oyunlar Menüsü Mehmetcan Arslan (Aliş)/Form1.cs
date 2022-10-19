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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Boşlukları Doldurunuz");
            }
            else
            {
                if (textBox2.Text == "HasMuslu" && textBox1.Text == "1907")
                {
                    Ana_Sayfa ans = new Ana_Sayfa();
                    ans.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lütfen Bilgilerinizi Doğru Giriniz!!");
                }
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Ana_Sayfa ans = new Ana_Sayfa();
            ans.Show();
            this.Hide();
        }
    }
}


