using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HMSService
{
    [ServiceContract]
    public interface IDoctorService
    {
        [OperationContract]
        string[] GetDoctorsByDeptId(int deptId);
        [OperationContract]
        int GetDoctorIdByName(string name);

        [OperationContract]
        int GetDoctorIdByUserName(string userName);
    }
}
