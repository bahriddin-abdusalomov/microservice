namespace Accommodation.Domain.Exceptions.Images;

public class ImageNotFoundException : NotFoundException
{
    public ImageNotFoundException()
    {
        Message = "Image not found !";
    }
}
