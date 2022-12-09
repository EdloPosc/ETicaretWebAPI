using ETicaret.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Mappings
{
    public class SubCategoryBrandMap : IEntityTypeConfiguration<SubCategoryBrand>
    {
        public void Configure(EntityTypeBuilder<SubCategoryBrand> builder)
        {


            builder.Property(x => x.SubCategoryBrandId).IsRequired();
            builder.Property(x => x.BrandId).HasDefaultValue(0);
            builder.Property(x => x.SubCategoryId).HasDefaultValue(0);
            builder.Property(x => x.SubCategoryBrandStatu).HasDefaultValue(false);


            builder.HasData(new SubCategoryBrand
            {
                SubCategoryBrandId = 1,
                BrandId = 1,
                SubCategoryId = 1,
                SubCategoryBrandStatu = true
            });
        }
    }
}
