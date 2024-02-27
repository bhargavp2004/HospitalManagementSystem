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
    public partial class RegForm : UserControl
    {
        public event EventHandler RegistrationSuccessful;
        public RegForm()
        {
            InitializeComponent();
        }

        private void registerBtnUC_Click(object sender, EventArgs e)
        {
            PatientServiceClient client = new PatientServiceClient();
            string name = nameText.Text;
            string username = usernameText.Text;
            string password = passwordText.Text;
            string email = emailText.Text;
            string phone = phoneText.Text;
            string gender = genderText.Text;
            string address = addressText.Text;
            string ageS = ageText.Text;

            if(name == "" || username == "" || password == "" || email == "" || phone == "" || gender == "" || address == "" || ageS == "")
            {
                MessageBox.Show("Please fill in all the details properly!");
            }
            else
            {
                int age = int.Parse(ageS);
                PatientRegistrationDetails p = new PatientRegistrationDetails(name, username, password, email, phone, gender, age, address);
                string Result = client.RegisterPatient(p);

                MessageBox.Show(Result);
                if(Result == "Registration Successful!")
                {
                    nameText.Clear();
                    usernameText.Clear();
                    passwordText.Clear();
                    emailText.Clear();
                    phoneText.Clear();
                    genderText.Clear();
                    addressText.Clear();
                    ageText.Clear();
                    RegistrationSuccessful?.Invoke(this, EventArgs.Empty);
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
