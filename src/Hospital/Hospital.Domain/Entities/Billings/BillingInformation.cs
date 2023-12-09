using Hospital.Domain.Entities.Patients;
using Hospital.Domain.Enums.Payments;

namespace Hospital.Domain.Entities.Billings;

public class BillingInformation : BaseEntity
{
    public int PatientID { get; set; }
    public decimal TotalAmount { get; set; }
    public PaymentStatus PaymentStatus { get; set; }

    public PatientInformation PatientInformation { get; set; }
}
