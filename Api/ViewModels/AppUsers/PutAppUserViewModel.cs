namespace WestcoastEducationApi.ViewModels.AppUsers;

public class PutAppUserViewModel
{
    public string? Id { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int AddressId { get; set; }
    public string? RoleName { get; set; }
}