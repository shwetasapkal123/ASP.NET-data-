using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayRollADO
{
    public class EmployeeRepo
    {
        public static string connectionString = @"Server=DESKTOP-QGMU8R3;Database=Demo194;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        public void GetAllEmployee()
        {
            try
            {
                EmployeeModel model = new EmployeeModel();
                using(connection)
                {
                    string query = @"select EmployeeId,EmployeeName,PhoneNumber,Address,Department,Gender,
	BasicPay,Deduction,TaxablePay,Tax,NetPay,City,Country from Employee_Payroll";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            model.EmployeeId = reader.GetInt32(0);
                            model.EmployeeName = reader.GetString(1);
                            model.PhoneNumber = Convert.ToInt64(reader["PhoneNumber"]);
                            model.Address=Convert.ToString(reader["Address"]);
                            model.Department = Convert.ToString(reader["Department"]);
                            model.Gender = Convert.ToChar(reader["Gender"]);
                            model.BasicPay = Convert.ToDouble(reader["BasicPay"]);
                            model.Deduction = Convert.ToDouble(reader["Deduction"]);
                            model.TaxablePay = Convert.ToDouble(reader["TaxablePay"]);
                            model.Tax = Convert.ToDouble(reader["Tax"]);
                            model.NetPay = Convert.ToDouble(reader["NetPay"]);
                            model.City = Convert.ToString(reader["City"]);
                            model.Country = Convert.ToString(reader["Country"]);

                            Console.WriteLine("{0}  {1}   {2}",model.EmployeeName,model.PhoneNumber,model.Address); 
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public bool AddEmployee(EmployeeModel employeeModel)
        {
            try
            {
                using(connection)
                {
                    SqlCommand command=new SqlCommand("SpAddEmployeedetails",connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeName", employeeModel.EmployeeName);
                    command.Parameters.AddWithValue("@PhoneNumber", employeeModel.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", employeeModel.Address);
                    command.Parameters.AddWithValue("@Department", employeeModel.Department);
                    command.Parameters.AddWithValue("@Gender", employeeModel.Gender);
                    command.Parameters.AddWithValue("@BasicPay", employeeModel.BasicPay);
                    command.Parameters.AddWithValue("@Deduction", employeeModel.Deduction);
                    command.Parameters.AddWithValue("@TaxablePay", employeeModel.TaxablePay);
                    command.Parameters.AddWithValue("@Tax", employeeModel.Tax);
                    command.Parameters.AddWithValue("@NetPay", employeeModel.NetPay);
                    //command.Parameters.AddWithValue("@StartDate", employeeModel.StartDate);
                    command.Parameters.AddWithValue("@City", employeeModel.City);
                    command.Parameters.AddWithValue("@Country", employeeModel.Country);

                    connection.Open();
                    var result=command.ExecuteNonQuery();
                    if(result!=0)
                        return true;
                    return false;
                    connection.Close();
                }
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
