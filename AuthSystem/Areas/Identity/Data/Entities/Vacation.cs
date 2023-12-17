namespace AuthSystem.Areas.Identity.Data.Entities;

public class Vacation
{
    public int Id { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public string Reason { get; set; }
    
    public string EmployeeId { get; set; }
    public Employee Employee { get; set; }
}