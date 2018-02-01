using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filing
{
    class FileClass
    {
        private string dataPath = @"C:\Users\saifullah\Desktop\timestamps.txt";

        Dictionary<String, String> sundays = new Dictionary<string, string>();
         
        public void selectDays()
        {

            CreateSampleFile();
            var JulyWeekends = from line in File.ReadLines(dataPath)
                               where (line.StartsWith("Saturday") ||
                               line.StartsWith("Sunday")) &&
                               line.Contains("July")
                               select line;


            File.WriteAllLines(@"C:\Users\saifullah\Desktop\selectedDays.txt", JulyWeekends);
            var MarchMondays = from line in File.ReadAllLines(dataPath)
                               where line.StartsWith("Monday")
                               && line.Contains("March")
                               select line;


            File.AppendAllLines(@"C:\Users\saifullah\Desktop\selectedDays.txt", MarchMondays);


        }

        public void EncryptFile()
        {
        }

        public void copyFiles(string source, string destination)
        {
            File.Copy(source,destination);
        }

        public void SelectSundays()
        {
            var sundays = from line in File.ReadLines(dataPath)
                          where line.StartsWith("Sunday")
                          select line;

            File.AppendAllLines(@"C:\Users\saifullah\Desktop\AllSundays.txt",sundays);
             
        }

        private void CreateSampleFile()
        {
            DateTime TimeStamp = new DateTime(2017, 1, 1);

            using (StreamWriter sw = new StreamWriter(dataPath))
            {
                for (int i = 0; i < 500; i++)
                {
                    DateTime TS1 = TimeStamp.AddYears(i);
                    DateTime TS2 = TS1.AddMonths(i);
                    DateTime TS3 = TS2.AddDays(i);
                    sw.WriteLine(TS3.ToLongDateString());
                }
            }
        }


    }
}
