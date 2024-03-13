using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HMSService
{
    [DataContract]
    public class DoctorDetails
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string username { get; set; }
        [DataMember]
        public string password { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string mobile_no { get; set; }
        [DataMember]
        public int deptId { get; set; }
        [DataMember]
        public string address { get; set; }
        [DataMember]
        public string gender { get; set; }

        public DoctorDetails()
        {
        }

        public DoctorDetails(string name, string username, string password, string email, string mobile_no, int deptId, string address, string gender)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.email = email;
            this.mobile_no = mobile_no;
            this.deptId = deptId;
            this.address = address;
            this.gender = gender;
        }
    }

}
