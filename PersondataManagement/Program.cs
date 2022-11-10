using System;
using System.Collections.Generic;
using System.Linq;

namespace PersondataManagement
{
    public class Person
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;

        public Person(string ssn, string name, string address, int age)
        {
            SSN = ssn;
            Name = name;
            Address = address;
            Age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<Person> listPerson=new List<Person>();
            AddRecords(listPerson);
            //RetrieveTopTwoRecords(listPerson);
            //RetrieveRecordsBet13To18(listPerson);
            //RetrieveAverageAge(listPerson);
            //CheckSpecificName(listPerson);
            //SkipRecordslessThan60(listPerson);
            RemoveSpecificName(listPerson);
        }
        private static void AddRecords(List<Person> listPerson)
        {
            listPerson.Add(new Person("234567", "John", "12 street", 25));
            listPerson.Add(new Person("243321", "SAM", "13 street", 17));
            listPerson.Add(new Person("123456", "Elan", "14 street", 55));
            listPerson.Add(new Person("345678", "Smith", "15 street", 65));
            listPerson.Add(new Person("765432", "SAM", "16 street", 75));
            listPerson.Add(new Person("765672", "Johny", "17 street", 15));
            //Console.WriteLine("Data Added successfully!!!!");
        }
        private static void RetrieveTopTwoRecords(List<Person> listPerson)
        {
            foreach(Person person in listPerson.FindAll(e=>(e.Age<60)).Take(2).ToList())
            {
                Console.WriteLine("Name: "+person.Name+"  Age: "+person.Age);
            }
        }
        private static void RetrieveRecordsBet13To18(List<Person> listPerson)
        {
            foreach(Person person in listPerson.FindAll(s=>(s.Age<18 && s.Age>13)).ToList())
            {
                Console.WriteLine("Name: "+person.Name+" Age: "+person.Age);
            }
        }
        //UC4-Average of age
        private static void RetrieveAverageAge(List<Person> listperson)
        {
            double avgAge = listperson.Average(e => e.Age);
            Console.WriteLine("Avrage age is: "+avgAge);
        }
        //UC5
        private static void CheckSpecificName(List<Person> listPerson)
        {
            bool val = listPerson.Any(a => a.Name == "Shweta");
            if(val)
            {
                Console.WriteLine("Name is present");
            }
            else
            {
                Console.WriteLine("Name is not present");
            }
        }
        private static void SkipRecordslessThan60(List<Person> listPerson)
        {
            foreach (Person person in listPerson.FindAll(e => (e.Age > 60)).ToList())
            {
                Console.WriteLine("Name "+person.Name+" Age "+person.Age);
            }
        }
        private static void RemoveSpecificName(List<Person> listPerson)
        {
            int val = listPerson.RemoveAll(e => e.Name == "SAM");

            foreach(Person person in listPerson)
            {
                Console.WriteLine("Name: "+person.Name+" Address: "+person.Address+" Age:  "+person.Age);
            }
        }
    }
}
