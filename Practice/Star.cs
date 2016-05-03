using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstronomicalDirectory
{
    public class Star
    {
        public string name;
        string constellation;
        double distance;
        double starMagnitude;
        double rightAscension; //прямое восхождение
        double declension; //склонение

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Constellation
        {
            get { return constellation; }
            set { constellation = value; }
        }
        public double StarMagnitude
        {
            get { return starMagnitude; }
            set { starMagnitude = value; }
        }
        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        public double RightAscension
        {
            get { return rightAscension; }
            set { rightAscension = Double.Parse(value.ToString()); }
        }
        public double Declension
        {
            get { return declension; }
            set { declension = Double.Parse(value.ToString()); }
        }
        public Star(): this(string.Empty, string.Empty, -1, -1, -1, -1){}
        public Star(string n, string c, double d, double sm, double dec, double ra)
        {
            name = n;
            constellation = c;
            distance = d;
            starMagnitude = sm;
            rightAscension = dec;
            declension = ra;
        }
    }
}
