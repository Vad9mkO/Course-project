using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstronomicalDirectory
{
    public class StarList : List<Star>
    {
        public delegate bool Comparator(string str1, string str2);

        internal StarList SearchByName(string name)
        {
            StarList result = new StarList();
            foreach(Star star in this)
            {
                if(star.Name.ToLower().IndexOf(name.ToLower()) != -1)
                {
                    result.Add(star);
                }
            }
            return result.Count == 0 ? null : result;//made changes - before it returned empty list but not null;
        }
        internal StarList SearchByConstellation(string constellation)
        {
            StarList result = new StarList();
            foreach (Star star in this)
            {
                if (star.Constellation.ToLower().IndexOf(constellation.ToLower()) != -1)
                {
                    result.Add(star);
                }
            }
            return result.Count == 0 ? null : result;
        }
        internal StarList SearchMixed(string name, string constellation)
        {
            StarList result = new StarList();
            foreach(Star star in this)
            {
                if(star.Name.ToLower().IndexOf(name.ToLower()) != -1 && star.Constellation.ToLower().IndexOf(constellation.ToLower()) != -1)
                {
                    result.Add(star);
                }
            }
            return result.Count == 0 ? null : result;
        }

        internal Star Retrieve(string name)
        {
            foreach(Star star in this)
            {
                if(star.Name.ToLower() == name.Trim().ToLower())
                {
                    return star;
                }
            }
            return null;
        }
        internal StarList CloneList()
        {
            StarList newList = new StarList();
            foreach(Star star in this)
            {
                newList.Add(new Star(star.Name, star.Constellation, star.Distance, star.StarMagnitude, star.RightAscension, star.Declension));
            }
            return newList;
        }

        internal StarList SearchBrightest()
        {
            StarList newList = this.CloneList();
            newList.SortByMagnitude();
            int counter = (this.Count * 35) / 100; //show 35% of existing stars - let it be the brightest stars
            newList.RemoveRange(counter, this.Count - counter);
            return newList;
        }

        internal void SortByMagnitude()//descending, need for good reflecting in GridView (from brightest to less bright)
        {
            for (int i = 0; i < this.Count - 1; i++)
            {
                for (int j = 0; j < this.Count - i - 1; j++)
                {
                    if (this[j].StarMagnitude < this[j + 1].StarMagnitude)
                    {
                        Star temp = this[j];
                        this[j] = this[j + 1];
                        this[j + 1] = temp;
                    }
                }
            }
        }
        
        internal StarList SearchVisibleStars(double longitude, double latitude)// долгота, широта
        {
            StarList visibleStars = new StarList();
            DateTime date = DateTime.Now;
            int seconds = date.Second;
            int minutes = date.Minute;
            int hours = date.Hour;
            int day = date.Day;
            int month = date.Month;
            int year = date.Year;

            foreach (Star star in this)
            {
                if (latitude > 0 && star.Declension <= 90 - latitude || latitude < 0 && star.Declension >= 90 + latitude)
                {
                    continue;
                }
                // 1.Вычисление модифицированной юлианской даты на начало суток MD:
                if (month <= 2)
                {
                    month += 12;
                    year -= 1;
                }

                double var1 = year / 400 - year / 100 + year / 4;
                double var2 = 365 * year - 679004;
                double ModificatedDate = var1 + var2 + 306001 * (month + 1) / (10000 + day);//
                /*2. Вычисление местного звездного времени на момент всемирного времени UT:
                  a) модифицированная юлианская дата на начало суток в юлианских столетиях:*/
                double T0 = (ModificatedDate - 51544.5) / 36525;
                //b) звездное время в Гринвиче на начало суток в секундах:
                double const1 = 24110.54841;
                double const2 = 8640184.812;
                double const3 = 0.093104;
                double const4 = 0.0000062;
                double S0 = const1 + const2 * T0 + const3 * Math.Pow(T0, 2) - const4 * Math.Pow(T0, 3);
                //c) UT - всемирное время в часах на момент расчета:
               
                double UT = hours + minutes / 60 + seconds / 3600 - (longitude * 4) / 60;
                //d) количество секунд, прошедших от начала суток до момента наблюдения:
                double numberSeconds = 3600 * UT;
                //e) количество звездных секунд, прошедших от начала суток:
                double numberStarSeconds = (366.2422 / 365.2422) * numberSeconds;
                //f) гринвичское среднее звездное время в градусах:
                double SG = (S0 + numberStarSeconds) / (3600 * 15);//
                //g) местное звездное время:
                double ST = SG + longitude;
                /*3. Вычисление часового угла звезды Th и высоты над горизонтом H:
                  a) часовой угол звезды:*/
                double Th = ST - star.RightAscension;
                //b) косинус зенитного угла:
                double cosZ = Math.Sin(latitude * Math.PI / 180) 
                    * Math.Sin(star.Declension * Math.PI / 180) + Math.Cos(latitude * Math.PI / 180) 
                    * Math.Cos(star.Declension * Math.PI / 180) * Math.Cos(Th * Math.PI / 180);//синус должен быть в радианах
                //c) зенитный угол
                double ZRad = Math.Acos(cosZ);//в радианах
                double ZDeg = (ZRad * 180) / Math.PI;//в градусах
                //d) высота звезды над горизонтом 
                double H = 90 - ZDeg;
                
                if (H >= 0 && H < 180)
                {
                    visibleStars.Add(star);
                }
            }
            return visibleStars.Count == 0 ? null : visibleStars;
        }

        internal StarList SearchVisibleConstellations(double longitude, double latitude)
        {
            StarList visibleStars = this.SearchVisibleStars(longitude, latitude);
            if (visibleStars != null)
            {
                for (int i = 0; i < visibleStars.Count; i++)
                {
                    for (int j = i + 1; j < visibleStars.Count; j++)
                    {
                        if (visibleStars[j].Constellation == visibleStars[i].Constellation)
                        {
                            visibleStars.RemoveAt(j);//delete star with same constellation
                            j--;
                        }
                    }
                }
                return visibleStars;
            }
            else
            {
                return null;
            }
        }
 
        internal void BufferSort(string headerCellName, string sortType)
        {
            string type = sortType.ToLower();
            if(type == "ascending")
            {
                Sort(CompareAscending, headerCellName);
            }
            else if(type == "descending")
            {
                Sort(CompareDescending, headerCellName);
            }
        }

        private void Sort(Comparator comparator, string headerCellName)
        {
            for (int i = 0; i < this.Count - 1; i++)
            {
                for (int j = 0; j < this.Count - 1 - i; j++)
                {
                    if (headerCellName == "Name")
                    {
                        if (comparator(this[j].Name, this[j + 1].Name))
                        {
                            Star temp = this[j];
                            this[j] = this[j + 1];
                            this[j + 1] = temp;
                        }
                    }
                    else if (headerCellName == "Constellation")
                    {
                        if (comparator(this[j].Constellation, this[j + 1].Constellation))
                        {
                            Star temp = this[j];
                            this[j] = this[j + 1];
                            this[j + 1] = temp;
                        }
                    }
                    else if (headerCellName == "Distance")
                    {
                        if (comparator(this[j].Distance.ToString(), this[j + 1].Distance.ToString()))
                        {
                            Star temp = this[j];
                            this[j] = this[j + 1];
                            this[j + 1] = temp;
                        }
                    }
                    else if (headerCellName == "Star Magnitude")
                    {
                        if (comparator(this[j].StarMagnitude.ToString(), this[j + 1].StarMagnitude.ToString()))
                        {
                            Star temp = this[j];
                            this[j] = this[j + 1];
                            this[j + 1] = temp;
                        }
                    }
                    else if (headerCellName == "Right Ascension")
                    {
                        if (comparator(this[j].RightAscension.ToString(), this[j + 1].RightAscension.ToString()))
                        {
                            Star temp = this[j];
                            this[j] = this[j + 1];
                            this[j + 1] = temp;
                        }
                    }
                    else if (headerCellName == "Declension")
                    {
                        if (comparator(this[j].Declension.ToString(), this[j + 1].Declension.ToString()))
                        {
                            Star temp = this[j];
                            this[j] = this[j + 1];
                            this[j + 1] = temp;
                        }
                    }
                }
            }
        }

        private bool CompareAscending(string str1, string str2)
        {
            double firstNumber;
            double secondNumber;
            bool result1 = Double.TryParse(str1, out firstNumber);//assume that str2 is the same type as str1
            bool result2 = Double.TryParse(str2, out secondNumber);
            if (result1)
            {
                if (firstNumber > secondNumber)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (String.Compare(str1, str2) == 1)
                {
                    return true;
                }
                return false;
            }
        }

        private bool CompareDescending(string str1, string str2)
        {
            double firstNumber;
            double secondNumber;
            bool result1 = Double.TryParse(str1, out firstNumber);//assume that str2 is the same type as str1
            bool result2 = Double.TryParse(str2, out secondNumber);
            if (result1)
            {
                if (firstNumber < secondNumber)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (String.Compare(str1, str2) == -1)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
