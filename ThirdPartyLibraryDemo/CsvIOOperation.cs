using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace ThirdPartyLibraryDemo
{
    public class CsvIOOperation
    {
        public static void CsvSerialize()
        {
            Console.WriteLine("WelCome");
            Student s=new Student();

            string csvFilePath = @"D:\Lfp194\ThirdPartyLibraryDemo\CsvData.csv";

            List<Student> students = new List<Student>()
            { 
                new Student(){FName="Snehal",LName="jagtap",Address="Pune",ZipCode=987654},
                new Student(){FName="Joe",LName="doe",Address="Us",ZipCode=987654}
            };

            StreamWriter sw = new StreamWriter(csvFilePath);
            CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture);

            cw.WriteRecords<Student>(students);
            sw.Close();
            Console.WriteLine("Closed");
        }

        public static void CsvDeserialize()
        {
            string csvFilePath = @"D:\Lfp194\ThirdPartyLibraryDemo\CsvData.csv";

            string CopyFilepath = @"D:\Lfp194\ThirdPartyLibraryDemo\CopyCsvData.csv";

            string jsonFilePath = @"D:\Lfp194\ThirdPartyLibraryDemo\JsconData.json";
             StreamReader swReader=new StreamReader(csvFilePath);

            CsvReader csvReader =new CsvReader(swReader,CultureInfo.InvariantCulture);

            List<Student> students1 = csvReader.GetRecords<Student>().ToList();

            foreach(Student student in students1)
            {
                Console.WriteLine(student);
            }
            //csv to another csv
            //using(var writer=new StreamWriter(CopyFilepath))
            //using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            //{
            //    csvExport.WriteRecords<Student>(students1);
            //}

            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter stream = new StreamWriter(jsonFilePath))
                using(JsonWriter jsonWriter = new JsonTextWriter(stream))
            {
                serializer.Serialize(jsonWriter,students1);
            }
           
        }
    }


    public class Student
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }

        public override string ToString()
        {
            return $"{FName} {LName} {Address} {ZipCode}";
        }
    }
}
