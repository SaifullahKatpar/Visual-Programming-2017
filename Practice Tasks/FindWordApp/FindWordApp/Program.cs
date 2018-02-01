using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWordApp
{
    class Program
    {

        static Dictionary<String, int> countTypes = new Dictionary<String,int>(); 
        static void Main(string[] args)
        {

            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                DirectoryInfo[] dirInDrive =  new DirectoryInfo(drive.Name).GetDirectories();
                foreach (DirectoryInfo dir in dirInDrive)
                {
                    searchFile(dir);

                }
            }

            int sum = 0;
            StreamWriter sw = new StreamWriter(@"D:\Images.txt");
            foreach (string item in countTypes.Keys)
            {
                sum += countTypes[item];
                Console.WriteLine(item+"  : "+countTypes[item]);
            }
            File.AppendAllText(@"D:\Images.txt", "\n\nThere are "+ sum + "  files in D drive.");
        }



        public static void searchFile(DirectoryInfo dir)
        {
            try{

                FileInfo[] files = dir.GetFiles("*.cs");
                if (files != null)
                {
                    foreach (FileInfo aFile in files)
                    {
                        if(countTypes.ContainsKey(aFile.Name) ){
                            countTypes[aFile.Name] += 1;
                        }
                        else
                        {
                            countTypes.Add(aFile.Name,1);
                        }

//                        Console.WriteLine(aFile.Name + "\n");
                    }

                }
                DirectoryInfo[] inDir = dir.GetDirectories();

                if (inDir != null)
                {
                    foreach (DirectoryInfo aDir in inDir)
                    {

                        searchFile(aDir);
                    }
                    return;
                }

            }
            catch(UnauthorizedAccessException exc)
            {
                Console.WriteLine("Unauthorized Access");
            }



            }
    }
}
