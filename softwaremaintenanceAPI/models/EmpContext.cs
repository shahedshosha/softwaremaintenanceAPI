using Microsoft.EntityFrameworkCore;

namespace softwaremaintenanceAPI.models
{
    public class EmpContext : DbContext 
    {
        public EmpContext(DbContextOptions options ) : base(options) 
        { 
        }
        // add the entity collection for your tables here 
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


    }
}
