using DataLayer.Models;
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

        public List<Person> getPerson()
        {
            List<Person> pr = new List<Person>();
            string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CompanyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                string command = "select * from Automobili";
                SqlCommand com = new SqlCommand(command, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                    pr.Add(new Person(dr.GetInt32(0),dr.GetString(1), dr.GetString(2), dr.GetDecimal(4)));

            }
            return pr;
        }
        public int insertPerson(Person p)
        {
          
                int result;
                string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CompanyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    string command = "insert into Employees (Name, Surname, Salary) values (@n, @s, @salary)";
                    SqlCommand com = new SqlCommand(command, con);
                    com.Parameters.AddWithValue("@n", p.name);
                    com.Parameters.AddWithValue("@s", p.surname);
                    com.Parameters.AddWithValue("@salary", p.salary);
                    
                    result = com.ExecuteNonQuery();
                }
                return result;
         }
        public int updatePerson(Person p)
        {
            int result;
            string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CompanyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                string commandText = "Update Employees Id=@id, Name=@name, Surname=@surname, Salary=@salary";
                SqlCommand com = new SqlCommand(commandText, con);
                com.Parameters.AddWithValue("@name", p.name );
                com.Parameters.AddWithValue("@id", p.id );
                com.Parameters.AddWithValue("@surname", p.surname );
                com.Parameters.AddWithValue("@salary", p.salary);

                result = com.ExecuteNonQuery();
            }
            return result;
        }

    }


}


