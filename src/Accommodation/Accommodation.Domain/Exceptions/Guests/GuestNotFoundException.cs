namespace Accommodation.Domain.Exceptions.Guests;

public class GuestNotFoundException : NotFoundException
{
    public GuestNotFoundException()
    {
        Message = "Guest not found !";
    }
}
