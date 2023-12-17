using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace AuthSystem.Areas.Identity.Data.Entities;

// Add profile data for application users by adding properties to the ApplicationUser class
public class User : IdentityUser
{
    public Employee Employee { get; set; }
    public List<AccessLog> AccessLogs { get; set; }
}

