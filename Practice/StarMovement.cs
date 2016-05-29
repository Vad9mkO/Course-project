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
        internal Star linkToStarFromBuffer { get; }
        internal Point screenCenter { get; }
        internal Point curCenter;
        internal int radius { get; set; }
        internal Color bgcolor { get; }
        internal int alpha { get; set; }// transparency
        private bool makeRadiusBigger { get; set; }
        private double distFromCenter { get; }
        internal double speedRateAdditionalIndex { get; set; }

        private int brightnessCounter { get; set; }//constant
        private int counter { get; set; }//when this rqual to 'brightnessCounter' then star begins to bright (3 step of increasing radius and 3 steps of decreasing)

        double angle { get; set; }//on this depents where stars will appear
        double aSemiAxis { get; }//большая полуось
        double bSemiAxis { get; }// малая полуось

        public StarMovement(Point center, int radius, int angleOfAppearing, Color bgColor, int randBrightTimer, Star linkToStar)
        {
            this.angle = angleOfAppearing;
            this.screenCenter = center;
            this.curCenter = center;
            this.radius = radius;
            this.distFromCenter = Math.Round(linkToStar.Distance);
            this.linkToStarFromBuffer = linkToStar;
            this.bgcolor = bgColor;
            this.makeRadiusBigger = true;
            this.counter = 0;
            this.brightnessCounter = randBrightTimer;//in which time star will start to bright
            this.alpha = 15;

            aSemiAxis = distFromCenter / 0.09;
            bSemiAxis = distFromCenter / 0.15;
            this.speedRateAdditionalIndex = 1.0 / (distFromCenter * 10);//defines speed of stars
        }

        internal void Step(string rotateType)
        {
            //Ellipse
            /*

        int ugol;
        int rad = 200;
        double k = 0.3;

        double pi = Math.PI;
        double inc = Math.PI / 300;

        double t = 0;
         ugol = angleOfAppearing;


            var x1_t = (rad * Math.Cos(t));
            var y1_t = (rad * k * Math.Sin(t));
            
            curCenter.X = Convert.ToInt32(Math.Round(x1_t * Math.Cos(ugol) + y1_t * Math.Sin(ugol) + screenCenter.X));
            curCenter.Y = Convert.ToInt32(Math.Round(-1 * x1_t * Math.Sin(ugol) + y1_t * Math.Cos(ugol) + screenCenter.Y));


            t += inc;
            */


            curCenter.X = Convert.ToInt32(aSemiAxis * Math.Cos(angle) + screenCenter.X);
            curCenter.Y = Convert.ToInt32(bSemiAxis * Math.Sin(angle) + screenCenter.Y);

            if(rotateType == "left")
            {
                angle -= speedRateAdditionalIndex;
            }
            else
            {
                angle += speedRateAdditionalIndex;
            }
      

            counter++;
            if(counter == brightnessCounter)
            {
                if (makeRadiusBigger)//увеличиваем радиус увеличиваем прозрачность
                {
                    radius++;
                    alpha += 50;
                    if (radius == 8)//останавливаемся
                    {
                        makeRadiusBigger = false;
                    }
                }
                else//уменьшаем радиус уменьшаем прозрачность
                {
                    radius--;
                    alpha -= 50;
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
