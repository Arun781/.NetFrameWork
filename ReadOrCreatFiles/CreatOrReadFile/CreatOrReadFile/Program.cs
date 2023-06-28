using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatOrReadFile
{
    internal class Program
    {
        public static void WriteFiles()
        {
            StreamWriter writer1 = new StreamWriter("E:\\WorkForTat\\ReadOrCreatFiles\\CreatOrReadFile\\Creat.txt");
            writer1.WriteLine("Hello from third time stream writer class");
            writer1.Close();// must so cleans the stream of junk values
            Console.WriteLine("done");
        }
        public static void ReadFiles()
        {
            StreamReader  reader1 = new StreamReader("E:\\WorkForTat\\ReadOrCreatFiles\\CreatOrReadFile\\Creat.txt");
            string content = reader1.ReadToEnd();
            reader1.Close();// must so cleans the stream of junk values
            Console.WriteLine(content);
        }
        public static void FileStreamExample() {
            FileStream stream = new FileStream("E:\\WorkForTat\\ReadOrCreatFiles\\CreatOrReadFile\\Stream.txt",FileMode.Create,FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream); 
            Console.WriteLine("stream file has write permission...");
            writer.Close();

            //If we creat a file to Create and Write den v have to Open and read it...

            FileStream stream1 = new FileStream("E:\\WorkForTat\\ReadOrCreatFiles\\CreatOrReadFile\\Stream.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader  (stream1);
            string content = reader.ReadToEnd();    
            reader.Close();
            Console.WriteLine(content);
        }

        public static void FileExample()
        {
            string filePath = "E:\\WorkForTat\\ReadOrCreatFiles\\CreatOrReadFile\\Stream.txt";
            //view file details
            DateTime dt1 = File.GetCreationTime(filePath);
            DateTime dt2 = File.GetLastAccessTime(filePath);
            Console.WriteLine("file created  " + dt1);
            Console.WriteLine("file last accessed" + dt2);
            // to open file to read
            StreamReader sr1 = File.OpenText(filePath);
            string content = sr1.ReadToEnd();
            Console.WriteLine(content);
            //lets check for files
            bool b1 = File.Exists(filePath);
            //if (b1.Equals(true))
            if (b1 == true)
            {// lets delete the file
             //File.Delete(filePath);
             //  Console.WriteLine("got deleted");
            }
            else
            {
                //  StreamWriter sw1 = File.CreateText(filePath);
                // sw1.WriteLine("created by File class");
                //  sw1.Close();
                //  Console.WriteLine("no file , so just created");
            }

        }
        public static void DirectoryExmaple()
        {
            //to create folder
            Directory.CreateDirectory(@"E:\Test1");
            Console.WriteLine("folder created");
           // to delete
            Directory.Delete("E:\\test1");
            Console.WriteLine("deleted");
            // to check for a folder
            bool b1 = Directory.Exists("E:\\hello");
            if (b1.Equals(true))
            {
                // write some code
            }
            else { Console.WriteLine("no such folder in path"); }
            //to display all file names of a given path
            string[] filenames = Directory.GetFiles("E:\\example in asp.net C#.net");
            // string to save more than one file name of path

            foreach (string onefile in filenames)
            {
                //  Console.WriteLine(onefile);
            }
            //to display all folders names
            string[] foldernames = Directory.GetDirectories("E:\\");
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
        public static void FileInfoExample()
        {
            FileInfo info = new FileInfo("E:\\WorkForTat\\ReadOrCreatFiles\\CreatOrReadFile\\Stream.txt");
            string fileextention = info.Extension;
            Console.WriteLine(fileextention);

            // display only txt not .txt
            // calculate number of docs in path , txt files in path xls
            //check difference between name and fullname

        }
        public static void DirectoryInfoExample()
        {
            DirectoryInfo info1 = new DirectoryInfo("e:\\peers");

        }

        static void Main(string[] args)
        {
            WriteFiles();
            ReadFiles();
            FileStreamExample();
            FileExample();
            DirectoryExmaple();
            FileInfoExample ();
            DirectoryInfoExample ();
        }
    }
}
