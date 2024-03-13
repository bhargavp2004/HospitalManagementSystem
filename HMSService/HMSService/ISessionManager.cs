using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HMSService
{
    [ServiceContract]
    public interface ISessionManager
    {
        [OperationContract]
        bool GetIsLogin();

        [OperationContract]
        void SetIsLoginTrue();
        [OperationContract]
        void SetIsLoginFalse();

    }
}
