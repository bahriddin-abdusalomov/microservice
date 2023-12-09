using Hospital.Domain.Enums.User;

namespace Hospital.Domain.Entities.Patients;

public class PatientInformation : BaseEntity
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public DateTime AdmissionDate { get; set; }
    public string Diagnosis { get; set; }
}
