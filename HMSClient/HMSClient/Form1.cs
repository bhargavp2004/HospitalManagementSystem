using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSClient
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logForm1.Hide();
            regForm1.Hide();
            logoutBtn.Hide();
            addDoctorsBtn.Hide();
            viewAptBtn.Hide();
            addDepartmentBtn.Hide();
            homeMain1.Hide();
            regForm1.Show();
            addDepartment1.Hide();
            addDoctors1.Hide();
            bookAptBtn.Hide();
            regForm1.RegistrationSuccessful += RegForm_RegistrationSuccessful;
            logForm1.LoginSuccessful += LogForm_LoginSuccessful;
            logForm1.AdminLoginSuccessful += LogForm1_AdminLoginSuccessful;
            addDepartment1.deptAddedSuccessfully += AddDepartment1_deptAddedSuccessfully;
            addDoctors1.doctorAddedSuccessfully += AddDoctors1_DoctorAddedSuccessfully;
            logForm1.DoctorLoginSuccessful += LogForm1_DoctorLoginSuccessful;
        }

        private void LogForm1_DoctorLoginSuccessful(object sender, EventArgs e)
        {
            viewAptBtn.Show();
            loginBtn.Hide();
            registerBtn.Hide();
            bookAptBtn.Hide();
            homeMain1.Show();
            logoutBtn.Show();
        }

        private void AddDoctors1_DoctorAddedSuccessfully(object sender, EventArgs e)
        {
            addDoctors1.Hide();
            homeMain1.Show();
        }

        private void AddDepartment1_deptAddedSuccessfully(object sender, EventArgs e)
        {
            addDepartment1.Hide();
            homeMain1.Show();
        }

        private void LogForm1_AdminLoginSuccessful(object sender, EventArgs e)
        {
            logForm1.Hide();
            registerBtn.Hide();
            loginBtn.Hide();
            homeMain1.Show();
            viewAptBtn.Show();
            logoutBtn.Show();
            addDepartmentBtn.Show();
            addDoctorsBtn.Show();
            bookAptBtn.Hide();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            logForm1.Hide();
            homeMain1.Hide();
            addDepartment1.Hide();
            addDoctors1.Hide(); 
            regForm1.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            regForm1.Hide();
            homeMain1.Hide();
            addDepartment1.Hide();
            addDoctors1.Hide();
            logForm1.Show();
        }

        private void addDoctorsBtn_Click(object sender, EventArgs e)
        {
            homeMain1.Hide();
            addDoctors1.Show();
        }

        private void viewAptBtn_Click(object sender, EventArgs e)
        {

        }

        private void addDepartmentBtn_Click(object sender, EventArgs e)
        {
            regForm1.Hide();
            homeMain1.Hide();
            addDepartment1.Hide();
            addDoctors1.Hide();
            logForm1.Hide();
            addDepartment1.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {

        }

        private void RegForm_RegistrationSuccessful(object sender, EventArgs e)
        {
            regForm1.Hide();
            logForm1.Show();
        }

        private void LogForm_LoginSuccessful(object sender, EventArgs e)
        {
            logForm1.Hide();
            registerBtn.Hide();
            loginBtn.Hide();
            homeMain1.Show();
            bookAptBtn.Show();
            viewAptBtn.Show();
            logoutBtn.Show();
        }
    }
}
