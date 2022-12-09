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
    public class SubCategoryMap : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {


            builder.Property(x => x.SubCategoryId).IsRequired();
            builder.Property(x => x.SubCategoryName).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(x => x.SortKey).HasDefaultValue(0);
            builder.Property(x => x.CategoryId).HasDefaultValue(0);
            builder.Property(x => x.SubCategoryStatu).HasDefaultValue(false);



            builder.HasData(new SubCategory
            {
                SubCategoryId = 1,
                SubCategoryName = "Telefon",
                SortKey = 1,
                CategoryId = 1,
                SubCategoryStatu = true
            });
        }
    }
}
