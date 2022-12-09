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
    public class BrandMap : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {


            builder.Property(x => x.BrandId).IsRequired();
            builder.Property(x => x.BrandStatu).HasDefaultValue(false);
            builder.Property(x => x.BrandName).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();

            builder.HasData(new Brand
            {
                BrandId = 1,
                BrandStatu = true,
                BrandName = "Apple"
            });
        }
    }
}
