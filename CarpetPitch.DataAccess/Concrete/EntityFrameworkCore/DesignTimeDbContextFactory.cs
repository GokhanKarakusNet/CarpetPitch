using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;


namespace CarpetPitch.DataAccess.Concrete.EntityFrameworkCore
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CarpetPitchDbContext>
    {
        public CarpetPitchDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<CarpetPitchDbContext>();
            var connectionString = configuration.GetConnectionString("MsSQLConnection");
            builder.UseSqlServer(connectionString);

            return new CarpetPitchDbContext(builder.Options);
        }

    }
}
