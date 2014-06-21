using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        Bitmap screen = new Bitmap(400, 400);
        Color c = new Color();
        List<Sand> sand = new List<Sand>();
        int delay;
        int count;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1;
            timer1.Enabled = true;

            count = 0;
            delay = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw();
            Calc();
        }

        public void Draw()
        {

            Graphics scn = Graphics.FromImage(screen);      //판떼기에 그래픽을 그릴꺼야
            Graphics g = this.CreateGraphics();		        //Real 판떼기
            Bitmap back = Properties.Resources.FRAME2;
            SolidBrush sb = new SolidBrush(Color.Black);
            scn.Clear(Color.White);
            Rectangle tt = new Rectangle(0, 300, 400, 4);
            scn.DrawImage(back, 0, 0);
            scn.FillRectangle(sb, tt);
            for (int i = 0; i < sand.Count; i++)
            {
                Rectangle rect = new Rectangle(sand[i].GetX(), sand[i].GetY(), 1, 1);
                scn.FillRectangle(sb, rect);
            }
            g.DrawImage(screen, 0, 0);
        }
        void Check()
        {
            for (int i = 0; i < sand.Count; i++)
            {

                int posx = sand[i].GetX();
                int posy = sand[i].GetY();
                Color peekl = GetPixelColor(posx - 1, posy + 1);
                Color peekm = GetPixelColor(posx, posy + 1);
                Color peekr = GetPixelColor(posx + 1, posy + 1);

                if(peekm.R == 0)
                {
                    if (peekl.R != 0 && peekr.R != 0)
                    {
                        sand[i].MoveRight();
                        sand[i].MoveSend();
                    }
                    else if (peekl.R == 0 && peekr.R != 0)
                    {
                        sand[i].MoveRight();
                        sand[i].MoveSend();

                    }
                    else if (peekl.R != 0 && peekr.R == 0)
                    {
                        sand[i].MoveLaft();
                        sand[i].MoveSend();
                    }
                    else if (peekl.R == 0 && peekr.R == 0)
                    {
                        continue;
                    }
                }
                else
                {
                    sand[i].MoveSend();
                }  
            }
        }

        Color GetPixelColor(int x, int y)
        {
            return screen.GetPixel(x, y);
        }
        public void Calc()
        {
            Check();

            if(count < 10000 && delay == 15)
            {
                Sand s = new Sand(200, 0);
                sand.Add(s);
                count++;
                delay = 0;
            }
            delay++;
        }
    }
}
