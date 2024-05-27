using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using WebIntroEmpty.Models.Entities;

namespace WebIntroEmpty.Models.Contexts
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options)
            :base(options){ 
        }
        

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

          
         
        }
    }
}
