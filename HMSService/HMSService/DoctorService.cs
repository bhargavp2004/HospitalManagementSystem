using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSService
{
    public class DoctorService : IDoctorService
    {
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HospitalManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public string[] GetDoctorsByDeptId(int deptId)
        {
            List<string> doctorsList = new List<string>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT name FROM Doctors WHERE deptId = @DeptId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DeptId", deptId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string doctorName = reader.GetString(0);
                        doctorsList.Add(doctorName);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return doctorsList.ToArray();
        }

        public int GetDoctorIdByName(string name)
        {
            int doctorId = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT doctorId FROM Doctors WHERE name = @Name";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        doctorId = reader.GetInt32(0);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return doctorId;
        }

        public int GetDoctorIdByUserName(string username)
        {
            int doctorId = -1;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT doctorId FROM Doctors WHERE username = @userName";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userName", username);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        doctorId = reader.GetInt32(0);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return doctorId;
        }

    }
}
