using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    public class Salary
    {
        private static SqlConnection ConnectionSetup()
        {
            return new SqlConnection("Server=DESKTOP-QGMU8R3;Database=Demo194;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;Integrated Security=True");
        }

        public int UpdateEmployeeSalary(SalaryUpdateModel salaryUpdateModel)
        {
            SqlConnection sqlConnection = ConnectionSetup();
            int salary = 0;
            try
            {
                using(sqlConnection)
                {
                    SalaryDetailModel salaryDetailModel = new SalaryDetailModel();
                    SqlCommand command = new SqlCommand("SpUpdateEmployeeSalary", sqlConnection);
                    command.CommandType=System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@id", salaryUpdateModel.SalaryId);
                    command.Parameters.AddWithValue("@month", salaryUpdateModel.Month);
                    command.Parameters.AddWithValue("@salary", salaryUpdateModel.EmployeeSalary);
                    command.Parameters.AddWithValue("@empId", salaryUpdateModel.EmployeeId);

                    sqlConnection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            salaryDetailModel.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                            salaryDetailModel.EmployeeName = reader["EmployeeName"].ToString();
                            salaryDetailModel.JobDescription = reader["JobDescription"].ToString() ;
                            salaryDetailModel.Month = reader["Month"].ToString();
                            salaryDetailModel.Employeesalary = Convert.ToInt32(reader["EmployeeSalary"]);
                            salaryDetailModel.SalaryId = Convert.ToInt32(reader["SalaryId"]);

                            Console.WriteLine("{0}    {1}    {2}",salaryDetailModel.EmployeeName,salaryDetailModel.Employeesalary,salaryDetailModel.Month);

                            salary = salaryDetailModel.Employeesalary;
                        }
                    }
                    else
                    {
                        Console.WriteLine("data not found");
                    }
                    sqlConnection.Close();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return salary;
        }
    }
}
