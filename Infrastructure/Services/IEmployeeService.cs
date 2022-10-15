using Domain.Dtos;

namespace Infrastructure.Services;

public interface IEmployeeService
{
<<<<<<< Updated upstream
    Task<List<EmployeeDto>> GetEmployees();
    Task<EmployeeDto> GetEmployee(int id);
    Task<EmployeeDto> CreateEmployee(AddEmployeeDto employeeDto);
    Task<EmployeeDto> UpdateEmployee(UpdateEmployeeDto employeeDto);
    Task<bool> DeleteEmployee(int id);
=======
    Task<Response<GetEmployeeDto>> AddEmployee(GetEmployeeDto model);
    Task<Response<List<GetEmployeeWithDepartmentDto>>> GetEmployeeWithDepartmentDto();
 
>>>>>>> Stashed changes
}