using Acme.StoreManagementDemo.Categories;
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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ConfigureByConvention();
            builder.Property(p => p.Id).ValueGeneratedNever();
            builder.Property(p => p.Name).HasMaxLength(StoreManagementDemoConsts.MaxNameLength).IsRequired(); ;
            builder.Property(p => p.Description).HasMaxLength(StoreManagementDemoConsts.MaxDescriptionLength).IsRequired();
            builder.ToTable("Categories");

        }
    }
}
