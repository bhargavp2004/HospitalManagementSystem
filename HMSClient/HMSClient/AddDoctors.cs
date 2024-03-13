using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMSClient.AdminServiceRef;
using HMSClient.DeptServiceRef;

namespace HMSClient
{
    
    public partial class AddDoctors : UserControl
    {
        public event EventHandler doctorAddedSuccessfully;
        public AddDoctors()
        {
            InitializeComponent();
        }

        private void getDeptBtn_Click(object sender, EventArgs e)
        {
            DepartmentServiceClient client = new DepartmentServiceClient();
            string[] deptList = client.GetDepartments();

            foreach(string dept in deptList)
            {
                deptListBox.Items.Add(dept);
            }
        }

        private void addDoctorBtn_Click(object sender, EventArgs e)
        {
            if(deptListBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select department");
            }

            else
            {
                string username = usernameText.Text;
                string password = passwordText.Text;
                string email = emailText.Text;
                string name = nameText.Text;
                string mobile_no = phoneText.Text;
                string address = addressText.Text;
                string gender = "";
                string deptName = deptListBox.SelectedItem.ToString();
                if (radioButton1.Checked == true)
                {
                    gender = "Male";
                }
                else if(radioButton2.Checked == true) 
                {
                    gender = "Female";
                }
                else
                {
                    MessageBox.Show("Please select gender");
                }

                if (username == "" || password == "" || email == "" || mobile_no == "" || name == "" || address == "" || gender == "" || deptName == "")
                {
                    MessageBox.Show("Please fill in all the details properly!");
                }
                else
                {
                    DepartmentServiceClient deptClient = new DepartmentServiceClient();
                    int deptId = deptClient.GetDeptId(deptName);

                    AdminServiceRef.AdminServiceClient client = new AdminServiceRef.AdminServiceClient();
                    AdminServiceRef.DoctorDetails d = new AdminServiceRef.DoctorDetails(name, username, password, email, mobile_no, deptId, address, gender);
                    string result = client.AddDoctor(d);
                    MessageBox.Show(result);

                    if (result == "Doctor added successfully!")
                    {
                        doctorAddedSuccessfully?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
        }

        private void deptListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
