namespace Accommodation.Domain.Exceptions;

public class NotFoundException : Exception
{
    public string Message { get; set; }
}
