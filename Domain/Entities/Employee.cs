namespace Domain.Entities;

public class Employee
{
    public int EmployeeId { get; set; }
    public string? EmployeeName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Image { get; set; }
    public int DepartmentId { get; set; }
}