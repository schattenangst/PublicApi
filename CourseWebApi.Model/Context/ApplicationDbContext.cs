
namespace CourseWebApi.Model.Context
{
    using Microsoft.EntityFrameworkCore;

    public partial class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //public DbSet<Autor> Autores { get; set; }
        //public DbSet<Libro> Libros { get; set; }
    }
}
