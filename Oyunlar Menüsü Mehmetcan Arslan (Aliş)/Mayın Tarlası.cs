using System;
using System.Collections;
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
    public partial class Mayın_Tarlası : Form
    {
        public Mayın_Tarlası()
        {
            InitializeComponent();
        }
        ArrayList mayinler = new ArrayList();
        private void Mayın_Tarlası_Load(object sender, EventArgs e)
        {
            
        }

        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinler.Clear();
            tableLayoutPanel1.Controls.Clear();
            int oMayin = 15;
            int oTarla = 81;
            tableLayoutPanel1.ColumnCount = 9;
            label2.Text ="Mayin" + oMayin.ToString();
            label3.Text = "Boyut" + tableLayoutPanel1.ColumnCount + "x" + tableLayoutPanel1.ColumnCount;
            label4.Text = "Kare" + tableLayoutPanel1.ColumnCount + tableLayoutPanel1.ColumnCount;
            Random rast = new Random();
            int sayi = 0;
            for (int i = 0; i < oMayin; i++)
            {
                uret:
                sayi = rast.Next(0, oTarla);
                if (mayinler.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinler.Add(sayi);
                }
            }
            for (int i = 0; i < oTarla; i++)
            {
                Button button = new Button();
                button.Size = new Size(50, 50);
                if (mayinler.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                    button.Tag = rast.Next(1, 20);
                }
                button.Click += button_Click;
                tableLayoutPanel1.Controls.Add(button);
            }
            this.Size = new Size(tableLayoutPanel1.ColumnCount * 50 + 25, tableLayoutPanel1.ColumnCount * 50 + 110);

        }
        int gPuan = 0;
        private void button_Click(object sender, EventArgs e)
        {
            
            Button tiklanan = (Button)sender;
            if (tiklanan.Text=="")
            {
            if (int.Parse(tiklanan.Tag.ToString()) == -1) 
            {
                tiklanan.BackgroundImage = Image.FromFile("mayin.png");
                tiklanan.BackColor = Color.Red;
                for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                {
                    if (int.Parse(tableLayoutPanel1.Controls[i].Tag.ToString())==-1)
                    {
                        tableLayoutPanel1.Controls[i].BackgroundImage = Image.FromFile("mayin.png");
                        tableLayoutPanel1.Controls[i].Enabled= false;
                    }
                    else
                    {
                        tableLayoutPanel1.Controls[i].Text = tableLayoutPanel1.Controls[i].Tag.ToString();

                    }
                }
            }
            else
	        {
                gPuan += int.Parse(tiklanan.Tag.ToString());
                tiklanan.Text=tiklanan.Tag.ToString();
                label1.Text = "Puan:" + gPuan;
                tiklanan.Enabled=false;
            }
        }
            this.Size = new Size(tableLayoutPanel1.ColumnCount * 50 + 25, tableLayoutPanel1.ColumnCount * 50 + 110);

        }

        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinler.Clear();
            tableLayoutPanel1.Controls.Clear();
            int oMayin = 30;
            int oTarla = 100;
            tableLayoutPanel1.ColumnCount = 10;
            label2.Text = "Mayin" + oMayin.ToString();
            label3.Text = "Boyut" + tableLayoutPanel1.ColumnCount + "x" + tableLayoutPanel1.ColumnCount;
            label4.Text = "Kare" + tableLayoutPanel1.ColumnCount + tableLayoutPanel1.ColumnCount;

            Random rast = new Random();
            int sayi = 0;
            for (int i = 0; i < oMayin; i++)
            {
            uret:
                sayi = rast.Next(0, oTarla);
                if (mayinler.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinler.Add(sayi);
                }
            }
            for (int i = 0; i < oTarla; i++)
            {
                Button button = new Button();
                button.Size = new Size(50, 50);
                if (mayinler.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                    button.Tag = rast.Next(1, 20);
                }
                button.Click += button_Click;
                tableLayoutPanel1.Controls.Add(button);
            }
            this.Size = new Size(tableLayoutPanel1.ColumnCount * 50 + 25, tableLayoutPanel1.ColumnCount * 50 + 110);

        }

        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mayinler.Clear();
            tableLayoutPanel1.Controls.Clear();
            int oMayin = 60;
            int oTarla = 121;
            tableLayoutPanel1.ColumnCount = 11;
            label2.Text = "Mayin" + oMayin.ToString();
            label3.Text = "Boyut" + tableLayoutPanel1.ColumnCount + "x" + tableLayoutPanel1.ColumnCount;
            label4.Text = "Kare" + tableLayoutPanel1.ColumnCount + tableLayoutPanel1.ColumnCount;

            Random rast = new Random();
            int sayi = 0;
            for (int i = 0; i < oMayin; i++)
            {
            uret:
                sayi = rast.Next(0, oTarla);
                if (mayinler.Contains(sayi))
                {
                    goto uret;
                }
                else
                {
                    mayinler.Add(sayi);
                }
            }
            for (int i = 0; i < oTarla; i++)
            {
                Button button = new Button();
                button.Size = new Size(50, 50);
                if (mayinler.Contains(i))
                {
                    button.Tag = -1;
                }
                else
                {
                    button.Tag = rast.Next(1, 20);
                }
                button.Click += button_Click;
                tableLayoutPanel1.Controls.Add(button);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ana_Sayfa ans = new Ana_Sayfa();
            ans.Show();
            this.Hide();
        }
    }
    
    }
