using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AstronomicalDirectory
{
    class Space
    {
        internal int Width { get; }
        internal int Height { get; }
        internal List<StarMovement> Stars { get; }
        
        internal Space(int width, int height)
        {
            Width = width;
            Height = height;
            Stars = new List<StarMovement>();
        }

        internal void Step(string rotateType)
        {
            foreach(StarMovement star in Stars)
            {
                star.Step(rotateType);
            }
        }

        internal static double CountDistance(Point point1, Point point2)
        {
            return 0.13 * Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));//in pixels * on coefficient
        }
    
    }
}
