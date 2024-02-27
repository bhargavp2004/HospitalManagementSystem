using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HMSService.CompositeTypes
{
    [DataContract]
    public class PatientRegistrationDetails
    {
        [DataMember]
        public string Name { get; set; } = string.Empty;
        [DataMember]
        public string Username { get; set; } = string.Empty;
        [DataMember]
        public string Password { get; set; } = string.Empty;
        [DataMember]
        public string Email { get; set; } = string.Empty;
        [DataMember]
        public string Phone { get; set; } = string.Empty;
        [DataMember]
        public string Gender { get; set; } = string.Empty;
        [DataMember]
        public int Age { get; set; } = 0;
        [DataMember]
        public string Address { get; set; } = string.Empty;

        public PatientRegistrationDetails()
        {
        }

        public PatientRegistrationDetails(string name, string username, string password, string email, string phone, string gender, int age, string address)
        {
            Name = name;
            Username = username;
            Password = password;
            Email = email;
            Phone = phone;
            Gender = gender;
            Age = age;
            Address = address;
        }
    }
}
