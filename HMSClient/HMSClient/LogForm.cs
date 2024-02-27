using HMSClient.PatientServiceRef;
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
    public partial class LogForm : UserControl
    {
        public event EventHandler LoginSuccessful;
        public event EventHandler AdminLoginSuccessful;
        public event EventHandler DoctorLoginSuccessful;
        public LogForm()
        {
            InitializeComponent();
        }

        private void loginBtnUC_Click(object sender, EventArgs e)
        {
            PatientServiceClient client = new PatientServiceClient();
            string username = usernameText.Text;
            string password = passwordText.Text;

            if(username == "" || password == "")
            {
                MessageBox.Show("Please fill in all the details properly!");
            }
            else
            {
                LoginDetails loginDetails = new LoginDetails(username, password) ; 
                string result = client.PatientLogin(loginDetails);
                MessageBox.Show(result);
                if(result == "Login Successful!")
                {
                    usernameText.Text = "";
                    passwordText.Text = "";
                    LoginSuccessful?.Invoke(this, EventArgs.Empty);
                }
                else if(result == "Admin Login Successful!")
                {
                    usernameText.Text = "";
                    passwordText.Text = "";
                    AdminLoginSuccessful?.Invoke(this, EventArgs.Empty);
                }
                else if(result == "Doctor Login Successful!")
                {
                    usernameText.Text = "";
                    passwordText.Text = "";
                    DoctorLoginSuccessful?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
