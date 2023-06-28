using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatOrReadFile
{
    internal class Directoriesss
    {
        static void Main(string[] args)
        {

            //to create folder
            Directory.CreateDirectory(@"d:\Test1");
            Console.WriteLine("folder created");
            //to delete
            Directory.Delete("d:\\test1");
            Console.WriteLine("deleted");
            // to check for a folder
            bool b1 = Directory.Exists("d:\\hello");
            if (b1.Equals(true))
            {
                // write some code
            }
            else { Console.WriteLine("no such folder in path"); }
            //to display all file names of a given path
            string[] filenames = Directory.GetFiles("d:\\example in asp.net C#.net");
            // string to save more than one file name of path

            foreach (string onefile in filenames)
            {
                //  Console.WriteLine(onefile);
            }
            //to display all folders names
            string[] foldernames = Directory.GetDirectories("d:\\");
            foreach (string onefolder in foldernames)
            {
                //  Console.WriteLine(onefolder);
            }
            string[] alldrivenames = Directory.GetLogicalDrives();
            foreach (string oneDrive in alldrivenames)
            {
                // Console.WriteLine(oneDrive);
            }
        }

    }
}

