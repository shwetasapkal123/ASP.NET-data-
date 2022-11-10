using EmployeeManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeeManagementTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSalaryDetailAbleToUpdateSalaryDetails()
        {
            //Arrange
            Salary salary = new Salary();
            SalaryUpdateModel salaryUpdateModel = new SalaryUpdateModel()
            {
                SalaryId=2,
                Month="Feb",
                EmployeeSalary=9000,
                EmployeeId=1
            };

            //Act
            int EmpSalary = salary.UpdateEmployeeSalary(salaryUpdateModel);

            //Assert
            Assert.AreEqual(salaryUpdateModel.EmployeeSalary, EmpSalary);
        }
    }
}
