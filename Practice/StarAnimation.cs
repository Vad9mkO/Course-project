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
using System.Timers;
using System.Threading;

namespace AstronomicalDirectory 
{
    public partial class StarAnimation : Form
    {
        Rectangle spaceRect { get; }
        int earthAngle { get; set; }
        int blackholeAngle { get; set; }
        double speedIndex { get; set; }
        bool oneChoosen { get; set; }
        bool twoChoosen { get; set; }
        bool timeButClicked { get; set; }
        List<Star> choosenStar { get; set; }
        StarMovement firstStarToBeOutlined { get; set; }
        StarMovement secondStarToBeOutlined { get; set; }
        Space space { get; }
        MainForm main { get; set; }
        PictureBox earthBox { get; set; }
        PictureBox blackholeBox { get; set; }
        Image earthImage { get; set; }
        Image spaceImage { get; set; }
        Image blackholeImage { get; set; }

        Color[] colorPalette { get; set; }
        int stepsCounter;

        private TrackBar trackBar1;
        private int trackBarValue;
        private int trackBarDifference;

        public StarAnimation()
        {
            InitializeComponent();
            spaceRect = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            space = new Space(spaceRect.Width, spaceRect.Height);
            gridView.Visible = false;
            star1Label.Visible = false;
            star2Label.Visible = false;
            distanceLabel.Visible = false;
        }

        private void StarAnimation_Load(object sender, EventArgs e)
        {
            main = this.Owner as MainForm;
            stepsCounter = 0;
            gridView.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            gridView.EnableHeadersVisualStyles = false;
            yearLabel.Visible = false;

            earthAngle = 0;
            blackholeAngle = 0;
            speedIndex = 1;

            earthImage = Image.FromFile(@"C:\Users\User\Documents\Visual Studio 2015\Projects\Forms\Images\earthImage.png");
            spaceImage = Image.FromFile(@"C:\Users\User\Documents\Visual Studio 2015\Projects\Forms\Images\darkSpace.jpg");
            blackholeImage = Image.FromFile(@"C:\Users\User\Documents\Visual Studio 2015\Projects\Forms\Images\blackhole.png");
            earthBox = new PictureBox();
            blackholeBox = new PictureBox();

            colorPalette = new Color[9] { Color.Red, Color.OrangeRed, Color.DarkOrange, Color.Orange, Color.Gold, Color.Yellow, Color.LightYellow, Color.Aquamarine, Color.Aqua };
            Color curColor;
            Random randomBrightTimer = new Random();//in which time star will start to bright

            foreach (Star star in main.buffer[main.curBufIndex])
            {
                if (Math.Floor(star.StarMagnitude) < -1)
                {
                    curColor = colorPalette[0];
                }
                else
                {
                    curColor = colorPalette[(int)Math.Floor(star.StarMagnitude) + 2];
                }

                space.Stars.Add(new StarMovement(new Point(space.Width / 2, space.Height / 2), 5, Convert.ToInt32(star.RightAscension * 15), curColor, randomBrightTimer.Next(5, 25), star));
            }
            earthBox.Parent = blackholeBox.Parent = this;
            earthBox.Bounds = new Rectangle(this.ClientRectangle.Width / 2 - 20, this.ClientRectangle.Height / 2, earthImage.Width, earthImage.Height);
            earthBox.Paint += new PaintEventHandler(earthBox_Paint);
            blackholeBox.Bounds = new Rectangle(30, 590, blackholeImage.Width, blackholeImage.Height);
            blackholeBox.Paint += new PaintEventHandler(blackholeBox_Paint);

            this.trackBar1 = new TrackBar();

            this.Controls.Add(this.trackBar1);

            // Set up the TrackBar.
            this.trackBar1.Location = new Point(950, 650);
            this.trackBar1.Visible = false;
            
            this.trackBar1.Size = new Size(400, 5);
            this.trackBar1.TickStyle = TickStyle.None;
            this.trackBar1.Scroll += new EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new EventHandler(this.trackBar1_ValueChanged);

            trackBar1.Maximum = 5000;
            trackBar1.Value = 2016;
            trackBar1.TickFrequency = 1;
            trackBar1.LargeChange = 3;
            trackBar1.SmallChange = 2;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            yearLabel.Text = "" + trackBar1.Value;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if(trackBar1.Value != 2016)
            {
                int startValue = trackBarValue;
                int endValue = trackBar1.Value;
                trackBarDifference = Math.Abs(endValue - startValue);

                int stepCuantity = (trackBarDifference * 29500) % 1100;

                for (int i = 0; i < stepCuantity; i++)//1100 steps for one circle
                {
                    for (int j = 0; j < trackBarDifference; j++)
                    {
                        if (endValue - startValue > 0)
                        {
                            space.Step("left");
                        }
                        else
                        {
                            space.Step("right");
                        }
                    }
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            space.Step("left");//зменяет положение звезд
            DrawSpace();//рисуем их

            if (stepsCounter > 29500)
            {

                MessageBox.Show("SUCCEED");
                stepsCounter = 0;
                yearLabel.Text = "" + Int32.Parse(yearLabel.Text) + 1;//increment year
            }

            stepsCounter += 1;

            if (oneChoosen)
            {
                choosenStar[0].Distance = Space.CountDistance(firstStarToBeOutlined.curCenter, new Point(this.ClientRectangle.Width / 2 - 4, this.ClientRectangle.Height / 2 + 16));//distance from earth to star
                gridView.DataSource = null;
                gridView.DataSource = choosenStar;             
            }

            if(twoChoosen)
            {
                star1Label.Text = firstStarToBeOutlined.linkToStarFromBuffer.Name;
                star2Label.Text = secondStarToBeOutlined.linkToStarFromBuffer.Name;
                distanceLabel.Text = "Distance: " + Space.CountDistance(firstStarToBeOutlined.curCenter, secondStarToBeOutlined.curCenter).ToString();
            }

            trackBarValue = trackBar1.Value;
        }

        private void DrawSpace()
        {
            Bitmap buffer = new Bitmap(space.Width, space.Height);
            Graphics bg = Graphics.FromImage(buffer);

            bg.DrawImage(spaceImage, 0, 0, space.Width, space.Height);

            foreach (StarMovement star in space.Stars)
            {
                bg.FillPie(new SolidBrush(Color.FromArgb(star.alpha, star.bgcolor.R, star.bgcolor.G, star.bgcolor.B)), star.curCenter.X - star.radius, star.curCenter.Y - star.radius, 2 * star.radius, 2 * star.radius, 0, 360);
                //draw heart of the star : we draw in center of a star circle that is always bright and static 
                bg.FillPie(new SolidBrush(Color.FromArgb(star.bgcolor.R, star.bgcolor.G, star.bgcolor.B)), star.curCenter.X - 3, star.curCenter.Y - 3, 2 * 3, 2 * 3, 0, 360);//where 3 is radius of "heart"
            }

            earthAngle -= 1;
            blackholeAngle += 1;
            earthBox.Invalidate();
            blackholeBox.Invalidate();

            if(oneChoosen)//outline star by ellipse
            {
                bg.DrawEllipse(new Pen(Color.DarkRed, 3), firstStarToBeOutlined.curCenter.X - 10, firstStarToBeOutlined.curCenter.Y - 10, 20, 20);
            }
            if(twoChoosen)
            {
                Pen pen = new Pen(Color.Green, 3);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

                bg.DrawEllipse(new Pen(Color.DarkRed, 3), secondStarToBeOutlined.curCenter.X - 10, secondStarToBeOutlined.curCenter.Y - 10, 20, 20);
                bg.DrawLine(pen, firstStarToBeOutlined.curCenter, secondStarToBeOutlined.curCenter);
            }

            Graphics g = this.CreateGraphics();
            g.DrawImageUnscaled(buffer, spaceRect.Location);
        }

        void earthBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(earthImage.Width / 2, earthImage.Height / 2);
            e.Graphics.RotateTransform(earthAngle);
            e.Graphics.DrawImage(earthImage, -earthImage.Width / 2, -earthImage.Height / 2);
            e.Graphics.RotateTransform(-earthAngle);
            e.Graphics.TranslateTransform(-earthImage.Width / 2, -earthImage.Height / 2);
        }

        void blackholeBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(blackholeImage.Width / 2, blackholeImage.Height / 2);
            e.Graphics.RotateTransform(blackholeAngle);
            e.Graphics.DrawImage(blackholeImage, -blackholeImage.Width / 2, -blackholeImage.Height / 2);
            e.Graphics.RotateTransform(-blackholeAngle);
            e.Graphics.TranslateTransform(-blackholeImage.Width / 2, -blackholeImage.Height / 2);
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

        private void StarAnimation_Click(object sender, EventArgs e)
        {
            var p = this.PointToClient(Cursor.Position);
            bool starIsFound = false;
            foreach (StarMovement star in space.Stars)//starmovement is class which fields contain info about each star to draw them (coords etc.)
            {//check if we clicked in area where there is a star
                if (p.X > star.curCenter.X - star.radius && p.X < star.curCenter.X + star.radius && p.Y > star.curCenter.Y - star.radius && p.Y < star.curCenter.Y + star.radius)
                {
                    starIsFound = true;           
                   
                    if (twoChoosen)
                    {
                        secondStarToBeOutlined = star;
                    }
                    else if(oneChoosen)
                    {
                        if(choosenStar[0].Name != star.linkToStarFromBuffer.Name)
                        {
                            secondStarToBeOutlined = star;
                            star1Label.Visible = true;
                            star2Label.Visible = true;
                            distanceLabel.Visible = true;
                            gridView.Visible = false;
                            twoChoosen = true;
                        }                      
                    }
                    else
                    {
                        choosenStar = new List<Star>() { new Star(star.linkToStarFromBuffer) };
                        gridView.DataSource = choosenStar;

                        gridView.Visible = true;
                        firstStarToBeOutlined = star;
                        oneChoosen = true;
                    }
                    break;
                }
                
            }
            if (!starIsFound)
            {
                if (twoChoosen)
                {
                    twoChoosen = false;
                    star1Label.Visible = false;
                    star2Label.Visible = false;
                    distanceLabel.Visible = false;
                    gridView.Visible = true;
                }
                else if (oneChoosen)
                {
                    gridView.Visible = false;
                    oneChoosen = false;//stop drawing cirlce around a star    
                }
            }
        }
        
        private void buttonStop_Click(object sender, EventArgs e)
        {
            if(buttonStop.Text == "Freeze")
            {
                timer.Stop();
                buttonStop.Text = "Defrost";
            }
            else
            {
                timer.Start();
                buttonStop.Text = "Freeze";
            } 
        }

        private void slowButton_Click(object sender, EventArgs e)
        {
            foreach (StarMovement star in space.Stars)
            {
                star.speedRateAdditionalIndex /= 2;
            }
            speedLabel.Text = "Speed rate " + speedIndex / 2.0 + "X";
            speedIndex /= 2;
        }

        private void quickButton_Click(object sender, EventArgs e)
        {
            foreach (StarMovement star in space.Stars)
            {
                star.speedRateAdditionalIndex *= 2;
            }
            speedLabel.Text = "Speed rate " + speedIndex * 2.0 + "X";
            speedIndex *= 2;
        }

        private void yearButton_Click(object sender, EventArgs e)
        {
            if (timeButClicked)
            {
                timeButClicked = false;
                trackBar1.Visible = false;
                yearLabel.Visible = false;

            }
            else
            {
                yearLabel.Text = "2016"; 
                timeButClicked = true;
                trackBar1.Visible = true;
                yearLabel.Visible = true;
            }
        }
    }
}