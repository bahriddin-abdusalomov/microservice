using Hospital.Domain.Entities.Doctors;
using Hospital.Domain.Entities.Patients;

namespace Hospital.Domain.Entities.Appointments;

public class AppointmentSchedule : BaseEntity
{
    public int PatientID { get; set; }
    public int DoctorID { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string Time { get; set; }

    public PatientInformation PatientInformation { get; set; }
    public DoctorInformation DoctorInformation { get; set; }
}
