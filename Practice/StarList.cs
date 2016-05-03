using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstronomicalDirectory
{
    public class StarList : List<Star>
    {
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
                /*Прямое восхождение Ra и склонение Dec звезды нам известны из базы данных,
                  долгота Lon и широта Lat получены при помощи GPS.
                  Если наблюдатель находится в северном полушарии (Lat>0), то звезды со склонением
                  Dec≤90-Lat являются невосходящими, следовательно для них высоту считать не нужно, она
                  будет всегда отрицательна. Для наблюдателя в южном полушарии (Lat<0) невосходящими
                  будут звезды со склонением Dec≥90+Lat. Если наблюдатель находится на экваторе (широта = 0 latitude == 0), то
                  вычислять высоту нужно для всех звезд*/
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
                double ModificatedDate = var1 + var2 + 306001 * (month + 1) / (10000 + day);///////////////но в источнике (10000 + day) - слитно, а не раздельно!!!!!
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
                /*Всемирное время UT - местное среднее солнечное время гринвичского (λ=0) 
                меридиана. Если долготу  места на Земле выражать в часовой мере и считать
                положительной к востоку от Гринвича, то имеет место следующее соотношение:  Тм = UT0 + λ
                Из того что Земля за 1 ч поворачивается на 15°, следует: 1° соответствует 4 мин, а 1 (угловая минута) – 4 с.*/
                double UT = hours + minutes / 60 + seconds / 3600 - (longitude * 4) / 60;//походу просто время по гринвичу ( можно получить так: DateTime.Now.ToUniversalTime() )
                //d) количество секунд, прошедших от начала суток до момента наблюдения:
                double numberSeconds = 3600 * UT;
                //e) количество звездных секунд, прошедших от начала суток:
                double numberStarSeconds = (366.2422 / 365.2422) * numberSeconds;
                //f) гринвичское среднее звездное время в градусах:
                double SG = (S0 + numberStarSeconds) / (3600 * 15);///////////////////////////////////////////////////////////////////////
                //g) местное звездное время:
                double ST = SG + longitude;
                /*3. Вычисление часового угла звезды Th и высоты над горизонтом H:
                  a) часовой угол звезды:*/
                double Th = ST - star.RightAscension;
                //b) косинус зенитного угла:
                double cosZ = Math.Sin(latitude * Math.PI / 180) * Math.Sin(star.Declension * Math.PI / 180) + Math.Cos(latitude * Math.PI / 180) * Math.Cos(star.Declension * Math.PI / 180) * Math.Cos(Th * Math.PI / 180);//синус должен быть в радианах
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
        /*
            Пример:
            Lon =  32,  Lat =  55
            Year =  2009 , Mon =  10 , Day =  17, UT =  7
            MD =  55121
            ST =  162.915907736159
            Пусть звезда имеет координаты:
            RA =  279.316 , DEC =  38.797
            Тогда
            Th =  243.599907736159
            H = 18.329728 ‘ звезда над горизонтом
       */
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
    }
}
