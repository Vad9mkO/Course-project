using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace AstronomicalDirectory
{
    class StarMovement
    {
        internal Space Space { get; set; }
        internal readonly Point screenCenter;            
        internal Point curCenter;
        internal int radius;           
        internal Color bgcolor;          
        internal int alpha = 45;// прозрачность
        private bool makeRadiusBigger;
        private double distFromCenter;
        private double index;

        private int brightnessCounter;//constant
        private int counter;//when this rqual to 'brightnessCounter' then star begins to bright (3 step of increasing radius and 3 steps of decreasing)

        double ang = 360;
        double a;//большая полуось, x  180
        double b;// малая полуось, y    69

        public StarMovement(Point center, int radius, double distFromCenter, Color bgColor, int randBrightTimer)
        {
            this.screenCenter = center;
            this.curCenter = center;
            this.radius = radius;
            this.distFromCenter = Math.Round(distFromCenter);
            this.bgcolor = bgColor;
            this.makeRadiusBigger = true;
            this.counter = 0;
            this.brightnessCounter = randBrightTimer;//in which time star will start to bright

            if(distFromCenter < 10)
            {
                a = distFromCenter * 20;
                b = distFromCenter * 10;
            }
            else
            {
                a = distFromCenter * 15;
                b = distFromCenter * 5;
            } 
            index = 1.0 / (distFromCenter / 2);//определяет скорость звезд
        }

        internal void Step()
        {
            //КРУГ
            //curCenter.X = screenCenter.X + (int)(distFromCenter * Math.Cos(angle * 6.30296));//ЗАДАЛИ НОВЫЕ КООРДИНАТЫ
            //curCenter.Y = screenCenter.Y + (int)(distFromCenter * Math.Sin(angle * 6.30296));
            //this.angle += d_angle;

            //ЭЛИПС
            curCenter.X = Convert.ToInt32(a * Math.Cos(ang * index) + screenCenter.X);
            curCenter.Y = Convert.ToInt32(b * Math.Sin(ang * index) + screenCenter.Y);
         
            ang -= 0.1;

            counter++;
            if(counter == brightnessCounter)
            {
                if (makeRadiusBigger)//увеличиваем радиус увеличиваем прозрачность
                {
                    radius++;
                    alpha += 70;
                    if (radius == 8)//останавливаемся
                    {
                        makeRadiusBigger = false;
                    }
                }
                else//уменьшаем радиус уменьшаем прозрачность
                {
                    radius--;
                    alpha -= 70;
                    if (radius == 5)
                    {
                        makeRadiusBigger = true;//and went out of this "increasing-decreasing cycle"
                    }
                }

                if(radius == 5)//normalized - means past cycle of increasing and decreasing
                {
                    counter = 0;//start count from begining
                }
                else
                {
                    counter--;//we stay in process of increasing and decreasing
                }
            }
        }
    }
}
