using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Oyunlar_Menüsü_Mehmetcan_Arslan__Aliş_
{
    public partial class X_Ball : Form
    {
        public X_Ball()
        {
            InitializeComponent();
        }
        int level = 1, kutusayısı = 10;
        ArrayList kutucuklar = new ArrayList();
        int yerX = 5, yerY = 5, hak = 3;
        private void X_Ball_Load(object sender, EventArgs e)
        {
            this.Text = "Kalan Hak =" + hak.ToString() + "level =" + level.ToString();
            kutucukOluştur();
            yenile();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ballHareket();
            carpmaDenetimi();
            KalanHak(sender, e);
            OyunBittimi(sender, e);
        }
        private void yenile()
        {
            kutusayısı = 10 * level;
            Random rnd = new Random();
            int x = rnd.Next(0, 50);
            int y = rnd.Next(300, 350);
            ball.Location = new Point(x, y);
            timer1.Enabled = true;
            timer1.Interval = 5;
            yerX = 1 + level * 1;
            yerY = -1 - level * 1;
        }
        private void carpmaDenetimi()
        {
            Rectangle r = new Rectangle();
            Rectangle t = new Rectangle();
            t.X = ball.Left;
            t.Y = ball.Top;
            t.Height = ball.Height;
            t.Width = ball.Width;
            for (int i = 0; i < kutucuklar.Count; i++)
            {
                PictureBox btn = ((PictureBox)kutucuklar[i]);
                r.X = btn.Left;
                r.Y = btn.Top;
                r.Height = btn.Height;
                r.Width = btn.Width;
                if (r.IntersectsWith(t))
                {
                    kutusayısı--;
                    kutucuklar.RemoveAt(i);
                    if (yerY > 0 && yerX > 0)
                    {
                        if (btn.Top <= ball.Bottom && btn.Left < ball.Right)
                        {
                            yerY = yerX * -1;
                        }
                        else
                        {
                            yerX = yerX * -1;
                        }
                    }
                    else  if (yerX  > 0 && yerX < 0 )
                        {
                            if (btn.Top <= ball.Bottom && btn.Right > ball.Right)
                            {
                                yerY = yerY * -1;
                            }
                            else
                            {
                                yerX = yerX * -1;
                            }
                        
                    }
                    else if (yerX  < 0 && yerX > 0)
                        {
                            if (btn.Top >= ball.Bottom && btn.Right < ball.Right)
                            {
                                yerY = yerY * -1;
                            }
                            else
                            {
                                yerX = yerX * -1;
                            }
                        }

                    else 


                        {
                            if (btn.Bottom >= ball.Top && btn.Right > ball.Right)
                            {
                                yerY = yerY * -1;
                            }
                            else
                            {
                                yerX = yerX * -1;
                            }
                        }
                    btn.Dispose();
                }
            }
        }

        private void X_Ball_MouseMove(object sender, MouseEventArgs e)
        {
            kontrol.Left = e.X;
        }
        private void kutucukOluştur()
        {
            for (int j = 0; j < level; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    PictureBox btn = new PictureBox();
                    if (level == 1)
                    {
                        btn.ImageLocation = "kutu.png";
                    }
                    else if (level == 2 )
                    {
                        btn.ImageLocation = "kutu.png";
                    }
                    else if (level == 3)
                    {
                        btn.ImageLocation = "kutu.png";
                    }
                    btn.Name = i.ToString();
                    btn.SizeMode = PictureBoxSizeMode.StretchImage;
                    btn.Size = new Size(70, 65);
                    btn.Location = new Point(20 + i * 120, j * 90 + 20);
                    btn.BackColor = Color.Transparent;
                    this.Controls.Add(btn);
                    kutucuklar.Add(btn);
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yenile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ana_Sayfa ans = new Ana_Sayfa();
            ans.Show();
            this.Hide();
        

    }

        private void OyunBittimi(object sender, EventArgs e)
        {
            DialogResult dr = DialogResult.None;
            if (kutusayısı==0)
            {
                timer1.Enabled = false;
                dr = MessageBox.Show("Tebrikler!! Seviye=" + level + "Bitirdiniz!!");
                level++;
            }
            if (dr == DialogResult.OK)
            {
                X_Ball_Load(sender, e);
            }

                }
        private void KalanHak(object sender, EventArgs e)
        {
            if (ball.Bottom > kontrol.Bottom && ! (ball.Right >= kontrol. Left && ball.Left <= kontrol.Right))
            {
                hak--;
                for (int i = 0; i < kutucuklar.Count; i++)
                {
                    PictureBox btn = ((PictureBox)kutucuklar[i]);
                    ((PictureBox)kutucuklar[i]).Dispose();
                }
                kutucuklar.Clear();
                timer1.Enabled = false;
                DialogResult dr = DialogResult.None;
                    if (hak > 0)
                {
                    dr = MessageBox.Show("Kaybettiniz Kalan Hakkınız=" + hak.ToString());
                    if (dr==DialogResult.OK)
                    {
                        X_Ball_Load(sender, e);
                    }

                }
                else if (hak == 0)
                {
                    MessageBox.Show("Game Over!!!");
                }
            }
        }
         private void ballHareket()
        {
            if (this.ClientSize.Width <= ball.Right)
            {
                yerX = yerX * -1;
            }
            else if (0 >= ball.Left)
            {
                yerX = yerX * -1;
            }
            if (this.ClientSize.Height <= ball.Bottom)
            {
                yerY = yerY * -1;
            }
            else if (0 >= ball.Top)
            {
                yerY = yerY * -1;
            }
            else if (ball.Bottom >= kontrol.Top && ball.Right >= kontrol.Left && ball.Left<= kontrol.Right)
            {
                yerY = yerY * -1;
            }
            ball.Location = new Point(ball.Left + yerX, ball.Top + yerY);
        }
    }
}
