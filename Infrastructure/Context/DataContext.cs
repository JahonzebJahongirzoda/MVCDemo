using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

<<<<<<< Updated upstream
public class DataContext:DbContext
{
    
    //dbcontext options
    public DataContext(DbContextOptions<DataContext> options):base(options)
    {
        
    }
    
=======
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
>>>>>>> Stashed changes
    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }

}