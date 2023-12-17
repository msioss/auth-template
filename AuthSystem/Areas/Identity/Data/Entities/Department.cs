namespace AuthSystem.Areas.Identity.Data.Entities;

public class Department
{
    public int Id { get; set; }
    public string DepartmentName { get; set; }
    public string Location { get; set; }

    public List<Post> Posts { get; set; }
}