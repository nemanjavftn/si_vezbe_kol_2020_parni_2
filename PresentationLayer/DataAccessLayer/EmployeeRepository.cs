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
        public List<Employee> GetAllStudents()
        {
            List<Employee> results = new List<Employee>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Employees";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                   Employee s = new Employee();
                    s.Id = sqlDataReader.GetInt32(0);
                    s.Name = sqlDataReader.GetString(1);
                    s.IndexNumber = sqlDataReader.GetString(2);
                    s.AverageMark = sqlDataReader.GetDecimal(3);

                    results.Add(s);
                }
            }

            return results;
        }

        public int InsertEmployee(Employee s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Employees VALUES ('{0}', '{1}', {2})",
                        s.Name, s.Surname, s.Salary);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}

