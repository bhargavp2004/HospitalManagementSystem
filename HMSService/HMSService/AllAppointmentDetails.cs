using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HMSService
{
    public class AllAppointmentDetails
    {
        [DataMember]
        public DateTime date { get; set; }

        [DataMember]
        public TimeSpan slot_start { get; set; }

        [DataMember]
        public TimeSpan slot_end { get; set; }

        [DataMember]
        public string doctorName{ get; set; }

        [DataMember]
        public string patientName { get; set; }
    }
}
