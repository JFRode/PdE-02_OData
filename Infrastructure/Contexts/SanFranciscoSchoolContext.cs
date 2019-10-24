using Microsoft.EntityFrameworkCore;
using SanFranciscoSchool.Models;

namespace SanFranciscoSchool.Infrastructure.Contexts
{
    public class SanFranciscoSchoolContext : DbContext
    {
        public DbSet<SchoolClass> SchoolClasses { get; set; }
        public DbSet<Student> Students { get; set; }

        public SanFranciscoSchoolContext(DbContextOptions<SanFranciscoSchoolContext> options) : base(options)
        {
        }
    }
}