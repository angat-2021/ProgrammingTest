using System;
using System.IO;

namespace FileInfoDirectoryAndPath
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Angat Yogi\source\repos\angat-2021\ProgrammingTest.sln";

            //String
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: "+Path.GetExtension(path));
            Console.WriteLine("File Name: "+Path.GetFileName(path));
            Console.WriteLine("File Name Without Extension: "+Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: "+Path.GetDirectoryName(path));

            

            
            //Fileinfo class c#
            //Directory
            /*
            Directory.CreateDirectory(@"c:\temp\folder1");
            //Get Files in given directory
            string[] files = Directory.GetFiles(@"C:\Users\Angat Yogi\source\repos\angat-2021\ProgrammingTest", "*.sln", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            //Only directory
            var directories = Directory.GetDirectories(@"C:\Users\Angat Yogi\source\repos\angat-2021\ProgrammingTest", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }
            Directory.Exists("...");

            //DirectoryInfo

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();




            //File
            var path1 = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path1);
            if (File.Exists(path1))
            {
                //
            }
            string content = File.ReadAllText(path);

            //FileInfo

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }
            */
        }
        static void Problem1()
        {

        }
    }
}
