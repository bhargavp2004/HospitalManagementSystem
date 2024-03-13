using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HMSService
{
    [ServiceContract]
    public interface IAppointmentService
    {
        [OperationContract]
        List<AllAppointmentDetails> ViewAppointments();

        [OperationContract]
        List<AllAppointmentDetails> ViewAppointmentByDoctorId(int doctorId);

        [OperationContract]
        List<AllAppointmentDetails> ViewAppointmentByPatientId(int patientId);

        [OperationContract]
        string BookAppointment(AppointmentDetails appointment);

        [OperationContract]
        List<TimeSpan> GetAvailableSlots(DateTime selectedDate, int doctorId);

        [OperationContract]
        string DeleteAppointment(int doctorId, int patientId, DateTime date, TimeSpan slotStart, TimeSpan slotEnd);


    }
}
