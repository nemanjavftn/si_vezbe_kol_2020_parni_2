using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class BuisnessRepository
    {

        public List<Employees> GetAllEmployees()
        {
            List<Employees> results = new List<Employeest>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Employees";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Employees e = new Student();
                    e.Id = sqlDataReader.GetInt32(0);
                    e.Name = sqlDataReader.GetString(1);
                    e.IndexNumber = sqlDataReader.GetString(2);
                    e.AverageMark = sqlDataReader.GetInt32(3);

                    results.Add(e);
                }
            }

            return results;
        }
        public int InsertEmployees(Employees e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Employees VALUES ('{0}', '{1}', {2})",
                        e.Name, e.Surname, e.Salary);

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}