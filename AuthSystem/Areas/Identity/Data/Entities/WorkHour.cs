namespace AuthSystem.Areas.Identity.Data.Entities;

public class WorkHour
{
    public int Id { get; set; }
    public DateOnly DateWorked { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    
    public string EmployeeId { get; set; }
    public Employee Employee { get; set; }
}