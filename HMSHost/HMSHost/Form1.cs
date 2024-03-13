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
using System.ServiceModel.Description;
using HMSService;


namespace HMSHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceHost sh = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            Uri baseUri = new Uri("http://localhost:8733/Design_Time_Addresses/HMSService/");
            Uri patientServiceUri = new Uri(baseUri, "PatientService/");
            sh = new ServiceHost(typeof(PatientService), patientServiceUri);
            WSHttpBinding httpBinding = new WSHttpBinding();
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

            Uri deptServiceUri = new Uri(baseUri, "DepartmentService/");
            ServiceHost shDept = new ServiceHost(typeof(DepartmentService), deptServiceUri);
            shDept.Description.Behaviors.Add(mBehave);
            shDept.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            shDept.AddServiceEndpoint(typeof(IDepartmentService), httpBinding, deptServiceUri);
            shDept.Open();

            Uri SMSURI = new Uri(baseUri, "SessionManager/");
            ServiceHost shSMS = new ServiceHost(typeof(SessionManager), SMSURI);
            shSMS.Description.Behaviors.Add(mBehave);
            shSMS.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            shSMS.AddServiceEndpoint(typeof(ISessionManager), httpBinding, SMSURI);
            shSMS.Open();

            Uri doctorServiceUri = new Uri(baseUri, "DoctorService/");
            ServiceHost shDoct = new ServiceHost(typeof(DoctorService), doctorServiceUri);
            shDoct.Description.Behaviors.Add(mBehave);
            shDoct.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            shDoct.AddServiceEndpoint(typeof(IDoctorService), httpBinding, doctorServiceUri);
            shDoct.Open();


            Uri aptServiceUri = new Uri(baseUri, "AppointmentService/");
            ServiceHost shApt = new ServiceHost(typeof(AppointmentService), aptServiceUri);
            shApt.Description.Behaviors.Add(mBehave);
            shApt.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            shApt.AddServiceEndpoint(typeof(IAppointmentService), httpBinding, aptServiceUri);
            shApt.Open();

            label1.Text = "Services Running";
        }
    }
}
