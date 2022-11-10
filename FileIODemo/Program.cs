using System;
using System.IO;

namespace FileIODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string path = @"D:\Lfp194\FileIODemo\Demo.txt";
            //CheckFileExists(path);
            //ReadAllLinesFromFile(path);
            //ReadAllTextFromFile(path);
            //FileCopyFromFile(path);
            //DeleteFromFile();
            FileOperation fileOperation = new FileOperation();
            // fileOperation.ReadFromStreamReader(path);
            fileOperation.WriteusingStreamReader(path);
        }
        public static void CheckFileExists(string path)
        {
            if(File.Exists(path))
            {
                Console.WriteLine("File exists");
            }
            else
                Console.WriteLine("File is not exists");
        }

        public static void ReadAllLinesFromFile(string path)
        {
            string[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine(lines[2]);
        }
        public static void ReadAllTextFromFile(string path)
        {
            string line;
            line=File.ReadAllText(path);

            Console.WriteLine(line);
        }
        public static void FileCopyFromFile(string path)
        {
            string copyPath = @"D:\Lfp194\FileIODemo\CopyDemo.txt";

            File.Copy(path, copyPath);
        }
        public static void DeleteFromFile()
        {
            string copyPath = @"D:\Lfp194\FileIODemo\CopyDemo.txt";
            File.Delete(copyPath);
        }
       
    }
}
