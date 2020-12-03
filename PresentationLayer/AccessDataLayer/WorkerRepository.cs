using AccessDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDataLayer
{
   public class WorkerRepository
    {
        public List<Worker> GetAllEmployees()
        {

            List<Worker> result = new List<Worker>();
            {
                using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT * FROM Employees ";
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Worker w = new Worker();
                        w.Id = sqlDataReader.GetInt32(0);
                        w.Name = sqlDataReader.GetString(1);
                        w.Surname = sqlDataReader.GetString(2);
                        w.Salary = sqlDataReader.GetDecimal(3);
                        result.Add(w);
                    }
                }
                return result;
            }
        }
            public int InsertEmployees(Worker w)
            {
                using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = String.Format("INSERT INTO Worker VALUES ('{0}','{1}','{2}')", w.Name, w.Surname, w.Salary);
                    sqlConnection.Open();
                    return sqlCommand.ExecuteNonQuery();
                }
            }
        }

    }
