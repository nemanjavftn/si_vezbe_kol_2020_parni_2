using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EmployeeRepository
    {
        public List<Employee> GettAllEmployees()
        {
            List<Employee> result = new List<Employee>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Employees";
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Employee s = new Employee();
                    s.Id = sqlDataReader.GetInt32(0);
                    s.Name = sqlDataReader.GetString(1);
                    s.Surname = sqlDataReader.GetString(2);
                    s.Salary = sqlDataReader.GetDecimal(3);
                    result.Add(s);
                }
                return result;

            }
        }

        public int InsertEmpoyee(Employee s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = String.Format("INSERT INTO Employees VALUES('{0}','{1}',{2})",s.Name,s.Surname,s.Salary);
                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
