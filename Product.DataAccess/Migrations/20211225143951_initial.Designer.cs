﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Product.DataAccess.Concrete.EntityFramework.Contexts;

namespace Product.DataAccess.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20211225143951_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Product.Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Decription")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("OperationClaim");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 12, 25, 17, 39, 51, 174, DateTimeKind.Local).AddTicks(2071),
                            Decription = "Admin tüm yetkilere sahiptir",
                            IsActive = true,
                            IsDeleted = false,
                            ModifedDate = new DateTime(2021, 12, 25, 17, 39, 51, 174, DateTimeKind.Local).AddTicks(2075),
                            ModifiedByName = "InitialCreate",
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("Product.Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModifedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("VARBINARY(500)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("OperationClaimId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 12, 25, 17, 39, 51, 188, DateTimeKind.Local).AddTicks(2640),
                            Email = "theeaslann1@gmail.com",
                            FirstName = "Onur",
                            IsActive = true,
                            IsDeleted = false,
                            LastName = "Aslan",
                            ModifedDate = new DateTime(2021, 12, 25, 17, 39, 51, 188, DateTimeKind.Local).AddTicks(2644),
                            ModifiedByName = "InitialCreate",
                            OperationClaimId = 1,
                            PasswordHash = new byte[] { 100, 51, 50, 52, 53, 98, 48, 48, 100, 97, 97, 51, 101, 54, 101, 102, 52, 97, 102, 97, 100, 52, 55, 98, 54, 57, 50, 49, 50, 99, 102, 50 }
                        });
                });

            modelBuilder.Entity("Product.Entities.Concrete.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandName = "Asus",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 12, 25, 17, 39, 51, 168, DateTimeKind.Local).AddTicks(926),
                            IsActive = true,
                            IsDeleted = false,
                            ModifedDate = new DateTime(2021, 12, 25, 17, 39, 51, 168, DateTimeKind.Local).AddTicks(1199),
                            ModifiedByName = "InitialCreate"
                        });
                });

            modelBuilder.Entity("Product.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Teknolojik Aletler",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 12, 25, 17, 39, 51, 171, DateTimeKind.Local).AddTicks(6534),
                            Description = "Teknolojik Ürünler; teknoloji kullanılarak üretilen aletler, araç-gereçlerdir ",
                            IsActive = true,
                            IsDeleted = false,
                            ModifedDate = new DateTime(2021, 12, 25, 17, 39, 51, 171, DateTimeKind.Local).AddTicks(6543),
                            ModifiedByName = "InitialCreate"
                        });
                });

            modelBuilder.Entity("Product.Entities.Concrete.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ColorName = "Siyah",
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 12, 25, 17, 39, 51, 172, DateTimeKind.Local).AddTicks(8825),
                            IsActive = true,
                            IsDeleted = false,
                            ModifedDate = new DateTime(2021, 12, 25, 17, 39, 51, 172, DateTimeKind.Local).AddTicks(8834),
                            ModifiedByName = "InitialCreate"
                        });
                });

            modelBuilder.Entity("Product.Entities.Concrete.Productt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedByName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedByName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.ToTable("Productts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CategoryId = 1,
                            ColorId = 1,
                            CreatedByName = "InitialCreate",
                            CreatedDate = new DateTime(2021, 12, 25, 17, 39, 51, 179, DateTimeKind.Local).AddTicks(2454),
                            IsActive = true,
                            IsDeleted = false,
                            ModifedDate = new DateTime(2021, 12, 25, 17, 39, 51, 179, DateTimeKind.Local).AddTicks(2463),
                            ModifiedByName = "InitialCreate",
                            Price = 7500.0,
                            ProductName = "Bilgisayar",
                            Stock = 20
                        });
                });

            modelBuilder.Entity("Product.Core.Entities.Concrete.User", b =>
                {
                    b.HasOne("Product.Core.Entities.Concrete.OperationClaim", "OperationClaim")
                        .WithMany("User")
                        .HasForeignKey("OperationClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperationClaim");
                });

            modelBuilder.Entity("Product.Entities.Concrete.Productt", b =>
                {
                    b.HasOne("Product.Entities.Concrete.Brand", "Brand")
                        .WithMany("Productts")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Product.Entities.Concrete.Category", "Category")
                        .WithMany("Productts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Product.Entities.Concrete.Color", "Color")
                        .WithMany("Productts")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Color");
                });

            modelBuilder.Entity("Product.Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("Product.Entities.Concrete.Brand", b =>
                {
                    b.Navigation("Productts");
                });

            modelBuilder.Entity("Product.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Productts");
                });

            modelBuilder.Entity("Product.Entities.Concrete.Color", b =>
                {
                    b.Navigation("Productts");
                });
#pragma warning restore 612, 618
        }
    }
}
