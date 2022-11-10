using EmployeePayRollSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace EmployeePayRollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given10EmployeeWhenAddedToListShouldMatchEmpEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();

            employeeDetails.Add(new EmployeeDetails(employeeID: 1, employeeName: "Rita", phoneNumber: 1234567890));
            employeeDetails.Add(new EmployeeDetails(employeeID: 2, employeeName: "Sam", phoneNumber: 1234567890));
            employeeDetails.Add(new EmployeeDetails(employeeID: 3, employeeName: "Joe", phoneNumber: 1234567890));
            employeeDetails.Add(new EmployeeDetails(employeeID: 4, employeeName: "Roe", phoneNumber: 1234567890));
            employeeDetails.Add(new EmployeeDetails(employeeID: 5, employeeName: "Ajay", phoneNumber: 1234567890));
            employeeDetails.Add(new EmployeeDetails(employeeID: 6, employeeName: "Vijay", phoneNumber: 1234567890));
            employeeDetails.Add(new EmployeeDetails(employeeID: 7, employeeName: "John", phoneNumber: 1234567890));

            EmployeePayRollOperation employeePayRollOperation = new EmployeePayRollOperation();
            DateTime startTime=DateTime.Now;
            employeePayRollOperation.AddEmployeeToPayRoll(employeeDetails);
            DateTime endTime=DateTime.Now;
            Console.WriteLine("Duration without thread "+(endTime-startTime));

            DateTime threadtartTime = DateTime.Now;
            employeePayRollOperation.AddEmployeeToPayRollWithThread(employeeDetails);
            DateTime threadendTime = DateTime.Now;
            Console.WriteLine("Duration with thread: "+(threadendTime- threadtartTime));
        }
    }
}
