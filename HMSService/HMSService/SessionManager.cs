using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HMSService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class SessionManager : ISessionManager
    {
        public bool isLogin;
        public string role;
        bool ISessionManager.GetIsLogin()
        {
            return isLogin;
        }

        void ISessionManager.SetIsLoginTrue()
        {
            isLogin = true;
        }
        void ISessionManager.SetIsLoginFalse()
        {
            isLogin = false;
        }
    }
}
