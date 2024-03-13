using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSService
{
    public class DepartmentService : IDepartmentService
    {
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HospitalManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public List<string> GetDepartments()
        {
            List<string> deptList = new List<string>();
            try
            {
                string query = @"SELECT deptName FROM Departments";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            deptList.Add(reader["deptName"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while getting departments: " + ex.Message);
            }

            return deptList;
        }

        public int GetDeptId(string deptName)
        {
            try
            {
                string query = @"SELECT deptId FROM Departments WHERE deptName = @DeptName";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DeptName", deptName);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int deptId))
                        {
                            return deptId;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while getting department ID: " + ex.Message);
                return -1;
            }
        }
    }
}
