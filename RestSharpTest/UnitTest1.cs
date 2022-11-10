using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace RestSharpTest
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
    }
    [TestClass]
    public class UnitTest1
    {
        RestClient client;
        [TestInitialize]
        public void Setup()
        {
            client = new RestClient("http://localhost:4000");
        }
        private IRestResponse getEmployeeList()
        {
            RestRequest request = new RestRequest("/employees", Method.GET);
            IRestResponse response = client.Execute(request);
            return response;
        }
        [TestMethod]
        public void OnCallingListReturnEmployeeList()
        {
            IRestResponse response = getEmployeeList();

            Assert.AreEqual(response.StatusCode, System.Net.HttpStatusCode.OK);

            List<Employee> datarResponse=JsonConvert.DeserializeObject<List<Employee>>(response.Content);

            Assert.AreEqual(3,datarResponse.Count);
            foreach (Employee emp in datarResponse)
            {
                System.Console.WriteLine("id "+emp.id+" name: "+emp.name+" salary "+emp.salary);
            }
        }
    }
}
