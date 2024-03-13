using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMSClient.AptServiceRef;
using HMSClient.DoctorServiceRef;
using HMSClient.PatientServiceRef;

namespace HMSClient
{
    public partial class AptList : UserControl
    {
        public AptList()
        {
            InitializeComponent();
        }

        private void AptList_Load(object sender, EventArgs e)
        {
        }

        private void getAptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AppointmentServiceClient client = new AppointmentServiceClient();
                DoctorServiceRef.DoctorServiceClient dclient = new DoctorServiceRef.DoctorServiceClient();
                PatientServiceRef.PatientServiceClient pclient = new PatientServiceRef.PatientServiceClient();
                AllAppointmentDetails[] apps;
                if (InformationManager.Role == "Patient")
                {
                    int patientId = pclient.GetPatientIdByUsername(InformationManager.Username);
                     apps = client.ViewAppointmentByPatientId(patientId);
                }
                else if(InformationManager.Role == "Doctor")
                {
                    int doctorId = dclient.GetDoctorIdByUserName(InformationManager.Username);

                    apps = client.ViewAppointmentByDoctorId(doctorId);
                }
                else
                {
                    apps = client.ViewAppointments();
                }

                if (apps != null && apps.Length > 0)
                {
                    List<AllAppointmentDetails> appointments = new List<AllAppointmentDetails>(apps);
                    dataGridViewAppointments.Columns.Clear();
                    dataGridViewAppointments.AutoGenerateColumns = false;
                    dataGridViewAppointments.Columns.Add("doctorName", "Doctor Name");
                    dataGridViewAppointments.Columns["doctorName"].DataPropertyName = "doctorName";

                    dataGridViewAppointments.Columns.Add("patientName", "Patient Name");
                    dataGridViewAppointments.Columns["patientName"].DataPropertyName = "patientName";

                    dataGridViewAppointments.Columns.Add("date", "Date");
                    dataGridViewAppointments.Columns["date"].DataPropertyName = "date";

                    dataGridViewAppointments.Columns.Add("slot_start", "Slot Start");
                    dataGridViewAppointments.Columns["slot_start"].DataPropertyName = "slot_start";

                    dataGridViewAppointments.Columns.Add("slot_end", "Slot End");
                    dataGridViewAppointments.Columns["slot_end"].DataPropertyName = "slot_end";
                    dataGridViewAppointments.DataSource = appointments;
                }
                else
                {
                    MessageBox.Show("No appointments found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginBtnUC_Click(object sender, EventArgs e)
        {

        }

        private void AptdeleteBtn_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewAppointments.SelectedRows[0];

                string doctorName = selectedRow.Cells["doctorName"].Value.ToString();
                string patientName = selectedRow.Cells["patientName"].Value.ToString();

                DoctorServiceRef.DoctorServiceClient dclient = new DoctorServiceRef.DoctorServiceClient();
                int doctorId = dclient.GetDoctorIdByName(doctorName);
                PatientServiceRef.PatientServiceClient pclient = new PatientServiceRef.PatientServiceClient();
                int patientId = pclient.GetPatientIdByName(patientName);
                DateTime date = (DateTime)selectedRow.Cells["date"].Value;
                TimeSpan slotStart = (TimeSpan)selectedRow.Cells["slot_start"].Value;
                TimeSpan slotEnd = (TimeSpan)selectedRow.Cells["slot_end"].Value;


                AppointmentServiceClient client = new AppointmentServiceClient();
                string result = client.DeleteAppointment(doctorId, patientId, date, slotStart, slotEnd);

                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
