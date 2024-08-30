using Acme.StoreManagementDemo.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.StoreManagementDemo.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ConfigureByConvention();

            builder.Property(p => p.Id).ValueGeneratedNever();
            builder.Property(p => p.Name).HasMaxLength(StoreManagementDemoConsts.MaxNameLength).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(StoreManagementDemoConsts.MaxDescriptionLength);
            builder.Property(p => p.Price).IsRequired();

            builder.HasOne(p => p.Category).WithMany().HasForeignKey(p => p.CategoryId).IsRequired();    
            builder.ToTable("Products");
        }
    }
}
