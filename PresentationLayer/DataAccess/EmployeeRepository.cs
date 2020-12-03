using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EmployeeRepository
    {
        public List<Employee> GetEmployess()

        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection sqlConnection= new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Employees";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Employee e = new Employee();
                    e.Id = sqlDataReader.GetInt32(0);
                    e.Name = sqlDataReader.GetString(1);
                    e.Surname = sqlDataReader.GetString(2);
                    e.Salary = sqlDataReader.GetDecimal(3);
                    employees.Add(e);
                }
                return employees;
                    
               }
        }
        public int Insert(Employee e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =string.Format("INSERT INTO Employees VALUES ('{0}','{1}',{2})",e.Name,e.Surname, e.Salary);

                int result=sqlCommand.ExecuteNonQuery();
                return result;
            }

        }
    }
}
