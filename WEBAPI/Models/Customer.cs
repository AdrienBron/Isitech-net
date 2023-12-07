namespace WEBAPI.Models;

public class Customer : BaseModel
{
    public int Id { get; set; }
    public string FirstName { get; set; } = String.Empty;
    public string? LastName { get; set; }
    public string Identifiant { get; set; } = String.Empty;
    public string Password { get; set; } = String.Empty;
    public string Key { get; set; } = String.Empty;
}