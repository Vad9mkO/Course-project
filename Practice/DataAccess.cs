using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace AstronomicalDirectory
{
    class DataAccess
    {
        public static StarList CreateListFromFile()
        {
            StarList list = new StarList();
            try
            {
                using (StreamReader read = new StreamReader(new FileStream(@"database.txt", FileMode.Open, FileAccess.Read)))
                {
                    object firstString = read.ReadLine();
                    if (firstString != null)//check if file isn`t empty
                    {
                        int quantity = Int32.Parse(firstString.ToString());
                        for (int i = 0; i < quantity; i++)
                        {
                            list.Add(new Star(read.ReadLine(), read.ReadLine(), Double.Parse(read.ReadLine()), Double.Parse(read.ReadLine()), Double.Parse(read.ReadLine()), Double.Parse(read.ReadLine())));
                        }
                        read.Close();
                        return list;
                    }
                    return firstString as StarList;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("File can`t be read!", ex);
            } 
        }
        
        public static void WriteToFile(List<Star> list)
        {
            StreamWriter write = new StreamWriter(new FileStream(@"database.txt", FileMode.Truncate, FileAccess.Write));//C:\\Users\\User\\Documents\\Visual Studio 2015\\Projects\\Forms\\Practice\\database.txt"
            if (list != null)
            { 
                write.WriteLine(list.Count);
                for (int i = 0; i < list.Count; i++)
                {
                    write.WriteLine(list[i].Name);
                    write.WriteLine(list[i].Constellation);
                    write.WriteLine(list[i].Distance);
                    write.WriteLine(list[i].StarMagnitude);
                    write.WriteLine(list[i].RightAscension);
                    write.WriteLine(list[i].Declension);
                }
            }
            write.Close();
        }
    }
}
