using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
     public class EmployeesRepository
    {
        public GetAllEmployees()

        {
            public List<Employees> GetAllEmployees()
            {
                List<Employees> result = new List<Employees>();
                using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT * FROM Students";

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        Employees S = new Employees();
                        S.Id = sqlDataReader.GetInt32(0);
                        S.Name = sqlDataReader.GetString(1);
                        S.Surname = sqlDataReader.GetString(2);
                        S.Salary = sqlDataReader.GetDecimal(3);
                        result.Add(S);
                    }

                }
            }
        }
    }
    }
}
