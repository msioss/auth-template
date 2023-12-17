namespace AuthSystem.Areas.Identity.Data.Entities;

public class MilitaryRegistration
{
    public int Id { get; set; }
    public string MilitaryRank { get; set; }
    public DateOnly RegistrationDate { get; set; }
    
    public string EmployeeId { get; set; }
    public Employee Employee { get; set; }
}