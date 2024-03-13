using HMSService.CompositeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HMSService
{
    [ServiceContract]
    public interface IPatientService
    {
        [OperationContract]
        string RegisterPatient(PatientRegistrationDetails p);

        [OperationContract]
        string PatientLogin(LoginDetails d);

        [OperationContract]
        int GetPatientIdByUsername(string username);

        [OperationContract]
        int GetPatientIdByName(string name);
    }
}
