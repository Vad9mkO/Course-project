using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstronomicalDirectory 
{
    public partial class StarAnimation : Form
    {
        readonly Rectangle spaceRect;
        Space space;
        MainForm main;
        PictureBox earthBox;
        int angle = 0;
        Image earth;
        Color[] colorPalette;

        public StarAnimation()
        {
            InitializeComponent();
            spaceRect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            space = new Space(spaceRect.Width, spaceRect.Height);
        }

        private void StarAnimation_Load(object sender, EventArgs e)
        {
            main = this.Owner as MainForm;
            earth = Image.FromFile(@"C:\Users\User\Documents\Visual Studio 2015\Projects\Forms\Images\earthImage.png");
            earthBox = new PictureBox();
            colorPalette = new Color[9] { Color.Red, Color.OrangeRed, Color.DarkOrange, Color.Orange, Color.Gold, Color.Yellow, Color.LightYellow, Color.Aquamarine, Color.Aqua };
            Color curColor;
            Random randomBrightTimer = new Random();//in which time star will start to bright

            foreach (Star star in main.buffer[main.curBufIndex])//Aqua
            {
                if(Math.Floor(star.StarMagnitude) < -1)
                {
                    curColor = colorPalette[0];
                }
                else
                {
                    curColor = colorPalette[(int)Math.Floor(star.StarMagnitude) + 2];
                }
                       
                space.Stars.Add(new StarMovement(new Point(space.Width / 2, space.Height / 2), 5, star.Distance, curColor, randomBrightTimer.Next(5, 25)));
            }
            earthBox.Parent = this;
            earthBox.Bounds = new Rectangle(this.ClientRectangle.Width/2 - 20, this.ClientRectangle.Height/2, earth.Width, earth.Height);
            earthBox.Paint += new PaintEventHandler(earthBox_Paint);    
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            space.Step();//изменяет положение звезд
            DrawSpace();//рисуем их
        }

        private void DrawSpace()
        {
            Bitmap buffer = new Bitmap(space.Width, space.Height);
            Graphics bg = Graphics.FromImage(buffer);
            bg.FillRectangle(Brushes.Black, 0, 0, space.Width, space.Height);
            //bg.Clear(Color.Black);

            foreach (StarMovement star in space.Stars)
            {
                bg.FillPie(new SolidBrush(Color.FromArgb(star.alpha, star.bgcolor.R, star.bgcolor.G, star.bgcolor.B)), star.curCenter.X - star.radius, star.curCenter.Y - star.radius, 2 * star.radius, 2 * star.radius, 0, 360);
            }
            angle -= 1;
            earthBox.Invalidate();

            Graphics g = this.CreateGraphics();
            g.DrawImageUnscaled(buffer, spaceRect.Location);

            /*
            Graphics graph = this.CreateGraphics();
            graph.FillRectangle(Brushes.Black, spaceRect);
            foreach(StarMovement star in space.Stars)
            {
                graph.FillPie(new SolidBrush(star.bgcolor), star.curCenter.X - star.radius, star.curCenter.Y - star.radius, 2 * star.radius, 2 * star.radius, 0, 360);
            }
            angle -= 1;
            earthBox.Invalidate();
            */
        }

        void earthBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(earth.Width / 2, earth.Height / 2);
            e.Graphics.RotateTransform(angle);
            e.Graphics.DrawImage(earth, -earth.Width / 2, -earth.Height / 2);
            e.Graphics.RotateTransform(-angle);
            e.Graphics.TranslateTransform(-earth.Width / 2, -earth.Height / 2);
        }

        private void StarAnimation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CloseForm();
            }
        }

        private void StarAnimation_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm();
        }

        private void CloseForm()
        {
            timer.Stop();
            main.Show();
            this.Close();
        }
    }
}
