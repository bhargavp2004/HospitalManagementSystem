using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HMSService.CompositeTypes
{
    [DataContract]
    public class LoginDetails
    {
        [DataMember]
        public string Username { get; set; } = string.Empty;
        [DataMember]
        public string Password { get; set; } = string.Empty;

        public LoginDetails()
        {
        }

        public LoginDetails(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
