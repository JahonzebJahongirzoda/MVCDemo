namespace Domain.Dtos;

public class GetEmployeeDto
{
    public int EmployeeId { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Image { get; set; }
    //department
    public int DepartmentId { get; set; }
 
}