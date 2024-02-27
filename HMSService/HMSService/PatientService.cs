using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMSService.CompositeTypes;

namespace HMSService
{
    public class PatientService : IPatientService
    {
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HospitalManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        string IPatientService.RegisterPatient(PatientRegistrationDetails p)
        {
            try
            {
                // Check if username or email already exists
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Check if username exists
                    SqlCommand checkUsernameCommand = new SqlCommand("SELECT COUNT(*) FROM patients WHERE username = @Username", connection);
                    checkUsernameCommand.Parameters.AddWithValue("@Username", p.Username);
                    int usernameCount = (int)checkUsernameCommand.ExecuteScalar();
                    if (usernameCount > 0)
                    {
                        return "Username already exists. Please try with another username.";
                    }

                    // Check if email exists
                    SqlCommand checkEmailCommand = new SqlCommand("SELECT COUNT(*) FROM patients WHERE email = @Email", connection);
                    checkEmailCommand.Parameters.AddWithValue("@Email", p.Email);
                    int emailCount = (int)checkEmailCommand.ExecuteScalar();
                    if (emailCount > 0)
                    {
                        return "Email already exists. Please try with another email.";
                    }
                }

                // If username and email are unique, proceed with registration
                string query = "INSERT INTO patients (name, username, password, email, phone, gender, address, age) VALUES (@Name, @Username, @Password, @Email, @Phone, @Gender, @Address, @Age)";

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", p.Name);
                        command.Parameters.AddWithValue("@Username", p.Username);
                        command.Parameters.AddWithValue("@Password", p.Password);
                        command.Parameters.AddWithValue("@Email", p.Email);
                        command.Parameters.AddWithValue("@Phone", p.Phone);
                        command.Parameters.AddWithValue("@Gender", p.Gender);
                        command.Parameters.AddWithValue("@Age", p.Age);
                        command.Parameters.AddWithValue("@Address", p.Address);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Registration Successful!";
                        }
                        else
                        {
                            return "Registration Failed!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return "An error occurred during registration: " + ex.Message;
            }
        }
        string IPatientService.PatientLogin(LoginDetails p)
        {
            try
            {
                // Check if username and password are correct
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM patients WHERE username = @Username AND password = @Password";
                    string adminquery = "SELECT COUNT(*) FROM admin WHERE username = @Username AND password = @Password";
                    string doctorquery = "SELECT COUNT(*) FROM doctors WHERE username = @Username AND password = @Password";

                    SqlCommand loginCommand = new SqlCommand(query, connection);
                    SqlCommand adminloginCommand = new SqlCommand(adminquery, connection);
                    SqlCommand doctorloginCommand = new SqlCommand(doctorquery, connection);

                    loginCommand.Parameters.AddWithValue("@Username", p.Username);
                    loginCommand.Parameters.AddWithValue("@Password", p.Password);

                    adminloginCommand.Parameters.AddWithValue("@Username", p.Username);
                    adminloginCommand.Parameters.AddWithValue("@Password", p.Password);

                    doctorloginCommand.Parameters.AddWithValue("@Username", p.Username);
                    doctorloginCommand.Parameters.AddWithValue("@Password", p.Password);


                    int loginCount = (int)loginCommand.ExecuteScalar();
                    int adminloginCount = (int)adminloginCommand.ExecuteScalar();
                    int doctorloginCount = (int)doctorloginCommand.ExecuteScalar();

                    if (loginCount > 0)
                    {
                        return "Login Successful!";
                    }
                    else if(adminloginCount > 0)
                    {
                        return "Admin Login Successful!";
                    }
                    else if(doctorloginCount > 0)
                    {
                        return "Doctor Login Successful!";
                    }
                    else
                    {
                        return "Incorrect username or password.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "An error occurred during login: " + ex.Message;
            }

        }
    }
}
