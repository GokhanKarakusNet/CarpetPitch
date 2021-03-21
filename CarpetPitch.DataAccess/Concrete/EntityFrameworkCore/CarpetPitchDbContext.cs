using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarpetPitch.DataAccess.Concrete.EntityFrameworkCore.Mappings;
using CarpetPitch.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CarpetPitch.DataAccess.Concrete.EntityFrameworkCore
{
    public class CarpetPitchDbContext:DbContext
    {
        private readonly bool isMigration = false;
        public CarpetPitchDbContext()
        {
            isMigration = true;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (isMigration)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=carpetPitch;Integrated Security=SSPI;");
            }
        }
        public CarpetPitchDbContext(DbContextOptions<CarpetPitchDbContext> options):base(options)
        {
            
        }

        


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=IPHONE;Database=carpetPitch;integrated security=true;Connection Timeout=1800;MultipleActiveResultSets=True");
        //}

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        //public DbSet<Cities> Cities { get; set; }
        //public DbSet<Country> Countries { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration<User>(new UserMap());
        //    modelBuilder.ApplyConfiguration<Company>(new CompanyMap());
        //}
    }

}
