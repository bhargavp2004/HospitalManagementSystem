using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace HMSService
{
    public class AppointmentService : IAppointmentService
    {
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HospitalManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        public List<AllAppointmentDetails> ViewAppointments()
        {
            List<AllAppointmentDetails> aptList = new List<AllAppointmentDetails>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = @"SELECT A.date, A.slotStart, A.slotEnd, D.name AS doctorName, P.name AS patientName
                        FROM Appointments A INNER JOIN Doctors D ON A.doctorId = D.doctorId INNER JOIN Patients P ON A.patientId = P.patientId;";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        AllAppointmentDetails appointment = new AllAppointmentDetails
                        {
                            date = reader.GetDateTime(0),
                            slot_start = reader.GetTimeSpan(1),
                            slot_end = reader.GetTimeSpan(2),
                            doctorName = reader.GetString(3),
                            patientName = reader.GetString(4)
                        };
                        aptList.Add(appointment);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return aptList;
        }



        public List<AllAppointmentDetails> ViewAppointmentByDoctorId(int doctorId)
        {
            List<AllAppointmentDetails> aptList = new List<AllAppointmentDetails>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = @"SELECT A.date, A.slotStart, A.slotEnd, D.name AS doctorName, P.name AS patientName
                FROM Appointments A 
                INNER JOIN Doctors D ON A.doctorId = D.doctorId
                INNER JOIN Patients P ON A.patientId = P.patientId
                WHERE A.doctorId = @doctorId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@doctorId", doctorId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        AllAppointmentDetails appointment = new AllAppointmentDetails
                        {
                            date = reader.GetDateTime(0),
                            slot_start = reader.GetTimeSpan(1),
                            slot_end = reader.GetTimeSpan(2),
                            doctorName = reader.GetString(3),
                            patientName = reader.GetString(4)
                        };
                        aptList.Add(appointment);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return aptList;
        }

        public List<AllAppointmentDetails> ViewAppointmentByPatientId(int patientId)
        {
            List<AllAppointmentDetails> aptList = new List<AllAppointmentDetails>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = @"SELECT A.date, A.slotStart, A.slotEnd, D.name AS doctorName, P.name AS patientName
                FROM Appointments A 
                INNER JOIN Doctors D ON A.doctorId = D.doctorId
                INNER JOIN Patients P ON A.patientId = P.patientId
                WHERE A.patientId = @patientId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PatientId", patientId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        AllAppointmentDetails appointment = new AllAppointmentDetails
                        {
                            date = reader.GetDateTime(0),
                            slot_start = reader.GetTimeSpan(1),
                            slot_end = reader.GetTimeSpan(2),
                            doctorName = reader.GetString(3),
                            patientName = reader.GetString(4)
                        };
                        aptList.Add(appointment);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return aptList;
        }

        public string BookAppointment(AppointmentDetails appointment)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "INSERT INTO Appointments (date, slotStart, slotEnd, doctorId, patientId) VALUES (@Date, @SlotStart, @SlotEnd, @DoctorId, @PatientId)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Date", appointment.date);
                command.Parameters.AddWithValue("@SlotStart", appointment.slot_start);
                command.Parameters.AddWithValue("@SlotEnd", appointment.slot_end);
                command.Parameters.AddWithValue("@DoctorId", appointment.doctorId);
                command.Parameters.AddWithValue("@PatientId", appointment.patientId);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if(rowsAffected > 0)
                    {
                        return "Appointment Booked Successfully!";
                    }
                    return "Booking Failed!";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return "Booking Failed!" + ex.Message;
                }
            }
        }


        private List<TimeSpan> GenerateAllSlots()
        {
            List<TimeSpan> allSlots = new List<TimeSpan>();
            TimeSpan startTime = TimeSpan.FromHours(9);
            TimeSpan endTime = TimeSpan.FromHours(17);

            TimeSpan slotDuration = TimeSpan.FromMinutes(30);

            TimeSpan currentSlot = startTime;
            while (currentSlot < endTime)
            {
                allSlots.Add(currentSlot);
                currentSlot = currentSlot.Add(slotDuration);
            }
            return allSlots;
        }
        private List<TimeSpan> GetExistingAppointments(DateTime selectedDate, int doctorId)
        {
            List<TimeSpan> existingSlots = new List<TimeSpan>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT slotStart, slotEnd FROM Appointments WHERE date = @SelectedDate AND doctorId=@doctorId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SelectedDate", selectedDate);
                command.Parameters.AddWithValue("@doctorId", doctorId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TimeSpan slotStart = reader.GetTimeSpan(0);
                        TimeSpan slotEnd = reader.GetTimeSpan(1);

                        existingSlots.Add(slotStart);
                        existingSlots.Add(slotEnd);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return existingSlots;
        }
        public List<TimeSpan> GetAvailableSlots(DateTime selectedDate, int doctorId)
        {

            List<TimeSpan> existingSlots = GetExistingAppointments(selectedDate, doctorId);
            List<TimeSpan> allSlots = GenerateAllSlots();
            List<TimeSpan> availableSlots = allSlots.Except(existingSlots).ToList();

            return availableSlots;
        }

        public string DeleteAppointment(int doctorId, int patientId, DateTime date, TimeSpan slotStart, TimeSpan slotEnd)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "DELETE FROM Appointments WHERE doctorId = @DoctorId AND patientId = @PatientId AND date = @Date AND slotStart = @SlotStart AND slotEnd = @SlotEnd";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DoctorId", doctorId);
                command.Parameters.AddWithValue("@PatientId", patientId);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@SlotStart", slotStart);
                command.Parameters.AddWithValue("@SlotEnd", slotEnd);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return "Appointment deleted successfully!";
                    }
                    return "Appointment deletion failed!";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return "Appointment deletion failed! " + ex.Message;
                }
            }
        }
    }
}
