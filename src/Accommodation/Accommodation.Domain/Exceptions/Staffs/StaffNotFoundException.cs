namespace Accommodation.Domain.Exceptions.Staffs;

public class StaffNotFoundException : NotFoundException
{
    public StaffNotFoundException()
    {
        Message = "Staff not found !";
    }
}
