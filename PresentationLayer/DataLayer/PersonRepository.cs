using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    class PersonRepository
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CompanyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public List<Person> GetAllEmployeess()
        {
            List<Person> p = new List<Person>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection;
                sqlCommand.CommandText = "SELECT * FROM Person";
                connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Person a = new Person();
                    a.id = reader.GetInt32(0);
                    a.name = reader.GetString(1);
                    a.surname = reader.GetString(2);
                    p.Add(a);
                }
                return p;
            }
            void InsertEmployee(Employee r) {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = connection;
                    sqlCommand.CommandText = $"INSERT INTO Employee VALUES('{r.Salary}')";
                    connection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                }


            }
        }
    } }
