namespace Hospital.Domain.Entities.Users;

public class Administrator : BaseEntity
{
    public int UserID { get; set; }
    public string FullName { get; set; }
    public string ContactNumber { get; set; }
    public string Email { get; set; }

    public UserAuthorization UserAuthorization { get; set; }
}
