using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarpetPitch.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarpetPitch.DataAccess.Concrete.EntityFrameworkCore.Mappings
{
    public class UserMap:IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(@"User", @"dbo");
            builder.HasKey(d => d.UserId);

            builder.Property(d => d.UserId).HasColumnName("UserId");
            builder.Property(d => d.FirstName).HasColumnName("FirstName");
            //builder.Property(d => d.Cname).HasColumnName("Cname");
            //builder.Property(d => d.CompanyAddress).HasColumnName("CompanyAddress");
            //builder.Property(d => d.Details).HasColumnName("Details");
            //builder.Property(d => d.Email).HasColumnName("Email");
            //builder.Property(d => d.ImageUrl).HasColumnName("ImageUrl");
            //builder.Property(d => d.IsActive).HasColumnName("IsActive");
            //builder.Property(d => d.Password).HasColumnName("Password");
            //builder.Property(d => d.PhoneNumber).HasColumnName("PhoneNumber");
            //builder.Property(d => d.TaxNumber).HasColumnName("TaxNumber");
            //builder.Property(d => d.TsCreated).HasColumnName("TsCreated");
            //builder.Property(d => d.TsUpdated).HasColumnName("TsUpdated");
        }
    }
}
