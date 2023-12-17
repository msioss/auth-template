namespace AuthSystem.Areas.Identity.Data.Entities;

public class AccessLog
{
    public int Id { get; set; }
    public DateTime LogInTime { get; set; }
    public DateTime LogOutTime { get; set; }
    
    public string UserId { get; set; }
    public User User { get; set; }
}