using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AnnotationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Console.WriteLine("Employee class validation ");
            Console.WriteLine();

            Employee employee=new Employee();
            employee.Name = "Sh";
            employee.Age = 12;
            employee.PhoneNumber = "1234abc";
            employee.Email = "abc@g";

            ValidationContext context = new ValidationContext(employee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(employee, context, results, true);

            if(!valid)
            {
                foreach(ValidationResult vr in results)
                {
                    Console.WriteLine("Member name  {0}",vr.MemberNames.First());
                    Console.WriteLine("Error message {0} {1}",vr.ErrorMessage,Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name: "+employee.Name+" Age"+employee.Age+" phone number "+employee.PhoneNumber+" Email "+employee.Email); 
            }
        }
    }
}
