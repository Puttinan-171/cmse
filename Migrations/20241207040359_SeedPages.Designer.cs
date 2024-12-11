﻿// <auto-generated />
using CMSECommerce.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CMSECommerce.Migrations
{
    [DbContext(typeof(Datacontext))]
    [Migration("20241207040359_SeedPages")]
    partial class SeedPages
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CMSECommerce.Models.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "This is the home page",
                            Slug = "home",
                            Title = "Home"
                        },
                        new
                        {
                            Id = 2,
                            Body = "This is the about page",
                            Slug = "about",
                            Title = "About"
                        },
                        new
                        {
                            Id = 3,
                            Body = "This is the service page",
                            Slug = "services",
                            Title = "Services"
                        },
                        new
                        {
                            Id = 4,
                            Body = "This is the contact page",
                            Slug = "contact",
                            Title = "Contact"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
