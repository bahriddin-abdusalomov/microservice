namespace Hospital.Domain.Entities.Users;

public class UserAuthorization : BaseEntity
{
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string Role { get; set; }
}