using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstronomicalDirectory
{
    class Space
    {
        internal int Width { get; set; }
        internal int Height { get; set; }
        internal List<StarMovement> Stars { get; set; }
        
        internal Space(int width, int height)
        {
            Width = width;
            Height = height;
            Stars = new List<StarMovement>();
        }

        internal void Step()
        {
            foreach(StarMovement star in Stars)
            {
                star.Step();
            }
        }
    
    }
}
