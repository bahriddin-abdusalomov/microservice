namespace Hospital.Domain.Entities.Doctors;

public class DoctorInformation : BaseEntity
{
    public string Name { get; set; }
    public string Specialty { get; set; }
    public string ContactNumber { get; set; }
    public string Email { get; set; }
    public string Image { get; set; }
}
