namespace Accommodation.Domain.Exceptions.Hotels;

public class HotelNotFoundException : NotFoundException
{
    public HotelNotFoundException()
    {
        Message = "Hotel not found !";
    }
}
