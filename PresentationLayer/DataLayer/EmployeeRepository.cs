using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EmployeeRepository
    {
        public List<Employee> getemployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM dbo.Employees;";

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Employee employee = new Employee();
                    employee.Id = reader.GetInt32(0);
                    employee.Name = reader.GetString(1);
                    employee.Surname = reader.GetString(2);
                    employee.Salary = reader.GetDecimal(3);

                    employees.Add(employee);
                }
            }
            return employees;
        }

        public int InsertEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(Constants.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = string.Format("INSERT INTO dbo.Employees(Name, Surname, Salary) VALUES('{0}','{1}',{2});",employee.Name, employee.Surname, employee.Salary);


                int result = command.ExecuteNonQuery();

                return result;
            }
        }



    }
}
