using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HMSService
{
    public class AdminService : IAdminService
    {
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HospitalManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public string AddDoctor(DoctorDetails d)
        {
            try
            {
                string query = @"INSERT INTO Doctors (username, password, name, email, gender, address, deptId, phone)
                                 VALUES (@Username, @Password, @Name, @Email, @Gender, @Address, @DeptId, @Phone);";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", d.username);
                        command.Parameters.AddWithValue("@Password", d.password);
                        command.Parameters.AddWithValue("@Name", d.name);
                        command.Parameters.AddWithValue("@Email", d.email);
                        command.Parameters.AddWithValue("@Gender", d.gender);
                        command.Parameters.AddWithValue("@Address", d.address);
                        command.Parameters.AddWithValue("@DeptId", d.deptId);
                        command.Parameters.AddWithValue("@Phone", d.mobile_no);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return "Doctor added successfully!";
                        }
                        else
                        {
                            return "Failed to add doctor!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "An error occurred while adding doctor: " + ex.Message;
            }
        }

        public string AddDepartment(string deptName)
        {
            try
            {
                string query = @"INSERT INTO Departments (deptName)
                                 VALUES (@DeptName);";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DeptName", deptName);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return "Department added successfully!";
                        }
                        else
                        {
                            return "Failed to add department!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "An error occurred while adding department: " + ex.Message;
            }
        }
    }
}
