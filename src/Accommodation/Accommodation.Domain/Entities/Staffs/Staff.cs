namespace Accommodation.Domain.Entities.Staffs;

public class Staff : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Position Position { get; set; }
    public decimal Salary { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public DateTime HireDate { get; set; }
    public string ImagePath { get ; set; }
    
    #region relations

    public long HotelId { get; set; }
    public  Hotel Hotel { get; set; }

    #endregion
}
