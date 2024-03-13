using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HMSService
{
    [ServiceContract]
    public interface IDepartmentService
    { 
        [OperationContract]
        List<string> GetDepartments();

        [OperationContract]
        int GetDeptId(string deptName);

    }
}
