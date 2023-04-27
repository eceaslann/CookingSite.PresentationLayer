﻿// <auto-generated />
using CookingSite.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CookingSite.DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230427184014_mig-cookingsite")]
    partial class migcookingsite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CookingSite.EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CookingSite.EntityLayer.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CookingSite.EntityLayer.Concrete.Cooker", b =>
                {
                    b.Property<int>("CookerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CookerImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CookerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CookerRecipesCount")
                        .HasColumnType("int");

                    b.HasKey("CookerID");

                    b.ToTable("Cookers");
                });

            modelBuilder.Entity("CookingSite.EntityLayer.Concrete.Recipes", b =>
                {
                    b.Property<int>("RecipesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RecipesImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipesName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipesReview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipesServices")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecipesID");

                    b.ToTable("Recipess");
                });
#pragma warning restore 612, 618
        }
    }
}
