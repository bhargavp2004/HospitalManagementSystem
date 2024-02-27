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

namespace HMSClient
{
    public partial class AddDepartment : UserControl
    {
        public event EventHandler deptAddedSuccessfully;
        public AddDepartment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AdminServiceClient client = new AdminServiceClient();
            string deptName = deptNameText.Text;
            string result = client.AddDepartment(deptName);
            MessageBox.Show(result);

            if(result == "Department added successfully!")
            {
                deptAddedSuccessfully?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
