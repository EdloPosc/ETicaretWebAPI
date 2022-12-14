// <auto-generated />
using System;
using ETicaret.DataAccessLayer.Concretes.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ETicaret.DataAccessLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrandSubCategory", b =>
                {
                    b.Property<int>("BrandsBrandId")
                        .HasColumnType("int");

                    b.Property<int>("SubCategoriesSubCategoryId")
                        .HasColumnType("int");

                    b.HasKey("BrandsBrandId", "SubCategoriesSubCategoryId");

                    b.HasIndex("SubCategoriesSubCategoryId");

                    b.ToTable("BrandSubCategory");
                });

            modelBuilder.Entity("ETicaret.EntityLayer.Concretes.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("BrandStatu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("BrandId");

                    b.ToTable("Brand");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            BrandName = "Apple",
                            BrandStatu = true
                        });
                });

            modelBuilder.Entity("ETicaret.EntityLayer.Concretes.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("CategoryStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<short>("SortKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)0);

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Elektronik",
                            CategoryStatus = true,
                            SortKey = (short)1
                        });
                });

            modelBuilder.Entity("ETicaret.EntityLayer.Concretes.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("date");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CustomerName");

                    b.Property<bool>("CustomerStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("CustomerStatus");

                    b.Property<string>("CustomerUserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("varchar");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            BirthDay = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreateDate = new DateTime(2022, 12, 9, 11, 24, 11, 426, DateTimeKind.Local).AddTicks(2744),
                            CustomerEmail = "tt@gmail.com",
                            CustomerLastName = "Tanin",
                            CustomerName = "Tuncay",
                            CustomerStatus = true,
                            CustomerUserName = "tt",
                            PhoneNumber = "+905327411235"
                        });
                });

            modelBuilder.Entity("ETicaret.EntityLayer.Concretes.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ETicaret.EntityLayer.Concretes.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<short>("SortKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValue((short)0);

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("SubCategoryStatu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            SubCategoryId = 1,
                            CategoryId = 1,
                            SortKey = (short)1,
                            SubCategoryName = "Telefon",
                            SubCategoryStatu = true
                        });
                });

            modelBuilder.Entity("ETicaret.EntityLayer.Concretes.SubCategoryBrand", b =>
                {
                    b.Property<int>("SubCategoryBrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<bool>("SubCategoryBrandStatu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("SubCategoryBrandId");

                    b.HasIndex("BrandId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("SubCategoryBrand");

                    b.HasData(
                        new
                        {
                            SubCategoryBrandId = 1,
                            BrandId = 1,
                            SubCategoryBrandStatu = true,
                            SubCategoryId = 1
                        });
                });

            modelBuilder.Entity("BrandSubCategory", b =>
                {
                    b.HasOne("ETicaret.EntityLayer.Concretes.Brand", null)
                        .WithMany()
                        .HasForeignKey("BrandsBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ETicaret.EntityLayer.Concretes.SubCategory", null)
                        .WithMany()
                        .HasForeignKey("SubCategoriesSubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ETicaret.EntityLayer.Concretes.Product", b =>
                {
                    b.HasOne("ETicaret.EntityLayer.Concretes.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("ETicaret.EntityLayer.Concretes.SubCategory", b =>
                {
                    b.HasOne("ETicaret.EntityLayer.Concretes.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ETicaret.EntityLayer.Concretes.SubCategoryBrand", b =>
                {
                    b.HasOne("ETicaret.EntityLayer.Concretes.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ETicaret.EntityLayer.Concretes.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("ETicaret.EntityLayer.Concretes.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("ETicaret.EntityLayer.Concretes.SubCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
