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
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = Constants.connectionString;
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Employees";

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Employee e = new Employee();
                    e.Id = reader.GetInt32(0);
                    e.Name = reader.GetString(1);
                    e.Surname = reader.GetString(2);
                    e.Salary = reader.GetDecimal(3);
                }


            }
            return employees;
        }
        public int InsertEmployee(Employee e)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = Constants.connectionString;
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = string.Format("INSERT INTO Employees VALUES ('{0}','{1}',{2})", e.Name, e.Surname, e.Salary);
                int result = command.ExecuteNonQuery();
                return result;
            }
        }

    }   
}
