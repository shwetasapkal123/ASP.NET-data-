using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ThirdPartyLibraryDemo
{
    public class XmlOperation
    {
        public static void XmlSerialize()
        {
            string xmlFilePath = @"D:\Lfp194\ThirdPartyLibraryDemo\XmlData.xml";
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    FName="Harry",LName="Doe",Address="USA",ZipCode=234567
                }
            };
            FileStream stream = new FileStream(xmlFilePath, FileMode.OpenOrCreate);

            XmlSerializer xml = new XmlSerializer(typeof(Student));

            foreach(Student student in students)
            {
                xml.Serialize(stream,student);
            }
        }

        public static void XmlDeserialize()
        {
            string xmlFilePath = @"D:\Lfp194\ThirdPartyLibraryDemo\XmlData.xml";
            FileStream stream = new FileStream(xmlFilePath, FileMode.OpenOrCreate);

            XmlSerializer xml=new XmlSerializer(typeof(Student));

            Student res=(Student)xml.Deserialize(stream);

            Console.WriteLine(res);
        }
    }
}
