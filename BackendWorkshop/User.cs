namespace BackendWorkshop;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LirstName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

public class AbstractUser
{
    public string Email { get; set; }
    public int Id { get; set; }
    public int ExternalId { get; set; }
    public string RegionId { get; set; }
}