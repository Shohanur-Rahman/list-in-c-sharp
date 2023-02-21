using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

namespace MyWebApp.DB
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Student> students { get; set; }



    }
}
