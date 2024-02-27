using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using HMSService;
using System.ServiceModel.Description;
namespace HMSHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        ServiceHost sh = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            Uri baseUri = new Uri("http://localhost:8733/Design_Time_Addresses/HMSService/");
            Uri patientServiceUri = new Uri(baseUri, "PatientService/");
            sh = new ServiceHost(typeof(PatientService), patientServiceUri);
            BasicHttpBinding httpBinding = new BasicHttpBinding();
            ServiceMetadataBehavior mBehave = new ServiceMetadataBehavior();
            sh.Description.Behaviors.Add(mBehave);
            sh.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            sh.AddServiceEndpoint(typeof(IPatientService), httpBinding, patientServiceUri);
            sh.Open();

            Uri adminServiceUri = new Uri(baseUri, "AdminService/");
            ServiceHost shAdmin = new ServiceHost(typeof(AdminService), adminServiceUri);
            shAdmin.Description.Behaviors.Add(mBehave);
            shAdmin.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            shAdmin.AddServiceEndpoint(typeof(IAdminService), httpBinding, adminServiceUri);
            shAdmin.Open();


            label1.Text = "Services Running";
        }
    }
}
