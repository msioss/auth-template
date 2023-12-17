using System.ComponentModel.DataAnnotations.Schema;

namespace AuthSystem.Areas.Identity.Data.Entities;

public class Employee
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; }
    public string Inn { get; set; }
    
    public int? PostId { get; set; }
    public Post Post { get; set; }

    public User User { get; set; }
    public EmployeeProfile EmployeeProfile { get; set; }
    public List<Vacation> Vacations { get; set; }
    public List<WorkHour> WorkHours { get; set; }
    public List<MilitaryRegistration> MilitaryRegistrations { get; set; }
}