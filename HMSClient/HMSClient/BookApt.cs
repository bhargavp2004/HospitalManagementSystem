using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using HMSClient.DeptServiceRef;
using HMSClient.DoctorServiceRef;
using HMSClient.AptServiceRef;
using HMSClient.PatientServiceRef;

namespace HMSClient
{
    public partial class BookApt : UserControl
    {
        int doctorId, patientId;
        public BookApt()
        {
            InitializeComponent();
        }

        private void getDeptBtn_Click(object sender, EventArgs e)
        {
            DepartmentServiceClient client = new DepartmentServiceClient();
            string[] deptList = client.GetDepartments();

            foreach (string dept in deptList)
            {
                deptListBox.Items.Add(dept);
            }
        }

        private void deptListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] doctorsList;
            string selectedDept = deptListBox.SelectedItem.ToString();

            DepartmentServiceClient client = new DepartmentServiceClient();
            int deptId = client.GetDeptId(selectedDept);

            DoctorServiceRef.DoctorServiceClient dclient = new DoctorServiceRef.DoctorServiceClient();
            doctListBox.Items.Clear();
            doctorsList = dclient.GetDoctorsByDeptId(deptId);

            foreach (string doctor in doctorsList)
            {
                doctListBox.Items.Add(doctor);
            }
        }



        private void bookBtn_Click(object sender, EventArgs e)
        {
            if (slotListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a time slot to book an appointment.");
                return;
            }

            string selectedSlot = slotListBox.SelectedItem.ToString();
            string[] slotParts = selectedSlot.Split(new string[] { " - " }, StringSplitOptions.None);

            TimeSpan slotStart = TimeSpan.Parse(slotParts[0]);
            TimeSpan slotEnd = TimeSpan.Parse(slotParts[1]);

            string selectedDoctor = doctListBox.SelectedItem.ToString();
            InformationManager.SelectedDoctorName = selectedDoctor;
            DoctorServiceRef.DoctorServiceClient client = new DoctorServiceRef.DoctorServiceClient();
            int doctorId = client.GetDoctorIdByName(selectedDoctor);
            string patientUsername = InformationManager.Username;
            PatientServiceClient pClient = new PatientServiceClient();
            int patientId = pClient.GetPatientIdByUsername(patientUsername);

            AppointmentDetails appointment = new AppointmentDetails
            {
                date = monthCalendar1.SelectionRange.Start,
                slot_start = slotStart,
                slot_end = slotEnd,
                doctorId = doctorId,
                patientId = patientId
            };

            AppointmentServiceClient aptClient = new AppointmentServiceClient();
            string result = aptClient.BookAppointment(appointment);

            MessageBox.Show(result);
            deptListBox.Items.Clear();
            doctListBox.Items.Clear();
            slotListBox.Items.Clear();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
            AppointmentServiceClient client = new AppointmentServiceClient();
            string selectedDoctor = doctListBox.SelectedItem.ToString();
            InformationManager.SelectedDoctorName = selectedDoctor;
            DoctorServiceRef.DoctorServiceClient dclient = new DoctorServiceRef.DoctorServiceClient();
            int doctorId = dclient.GetDoctorIdByName(selectedDoctor);
            TimeSpan[] availableSlots = client.GetAvailableSlots(selectedDate, doctorId);

            slotListBox.Items.Clear();
            foreach (TimeSpan slot in availableSlots)
            {
                TimeSpan slotEnd = slot.Add(TimeSpan.FromMinutes(30));
                string formattedSlot = slot.ToString(@"hh\:mm\:ss") + " - " + slotEnd.ToString(@"hh\:mm\:ss");
                slotListBox.Items.Add(formattedSlot);
            }
        }
    }
}
