using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIODemo
{
    public class FileOperation
    {
        public void ReadFromStreamReader(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while((s=sr.ReadLine()) !=null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void WriteusingStreamReader(string path)
        {
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("I am from bridgelabz");
                sr.Close();

                Console.WriteLine(File.ReadAllText(path));
            }
        }

    }
}
