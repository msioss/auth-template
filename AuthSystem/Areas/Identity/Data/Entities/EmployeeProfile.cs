using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthSystem.Areas.Identity.Data.Entities;

public class EmployeeProfile
{
    public string Id { get; set; }
    public string? Sex { get; set; }
    public DateOnly? BirthDate { get; set; }
    public string? Image { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string? HomeAddress { get; set; }
    public string? FamilyStatus { get; set; }
    public string? PassportNumber { get; set; }
    public DateOnly? PassportIssueDate { get; set; }
    public string? PassportIssueBy { get; set; }
    public DateOnly? PassportExpirationDate { get; set; }
    public Employee Employee { get; set; }
}