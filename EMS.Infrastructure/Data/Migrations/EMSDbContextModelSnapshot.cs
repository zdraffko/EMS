﻿// <auto-generated />
using System;
using EMS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EMS.Infrastructure.Data.Migrations
{
    [DbContext(typeof(EMSDbContext))]
    partial class EMSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EMS.Core.Domain.Entities.ManagerAggregate.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmployeeGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid>("ManagerGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(9,2)");

                    b.HasKey("Id");

                    b.HasIndex("ManagerId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 20,
                            Department = "Development",
                            EmployeeGuid = new Guid("67faf954-a542-41a7-a5f7-d5b041511a07"),
                            FirstName = "Employee",
                            LastName = "One",
                            ManagerGuid = new Guid("783e92f6-85c0-48cd-9a09-c25beafc570c"),
                            ManagerId = 1,
                            Salary = 5000m
                        },
                        new
                        {
                            Id = 2,
                            Age = 22,
                            Department = "HR",
                            EmployeeGuid = new Guid("f62625cd-962c-4c14-a3f4-bafa8bb22e50"),
                            FirstName = "Employee",
                            LastName = "Two",
                            ManagerGuid = new Guid("783e92f6-85c0-48cd-9a09-c25beafc570c"),
                            ManagerId = 1,
                            Salary = 2000m
                        },
                        new
                        {
                            Id = 3,
                            Age = 27,
                            Department = "Security",
                            EmployeeGuid = new Guid("b13be80f-f491-44b7-81e9-0693bcd866ba"),
                            FirstName = "Employee",
                            LastName = "Three",
                            ManagerGuid = new Guid("783e92f6-85c0-48cd-9a09-c25beafc570c"),
                            ManagerId = 1,
                            Salary = 7000m
                        });
                });

            modelBuilder.Entity("EMS.Core.Domain.Entities.ManagerAggregate.Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<Guid>("ManagerGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Managers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 24,
                            FirstName = "Manager",
                            LastName = "One",
                            ManagerGuid = new Guid("783e92f6-85c0-48cd-9a09-c25beafc570c")
                        });
                });

            modelBuilder.Entity("EMS.Core.Domain.Entities.ManagerAggregate.Employee", b =>
                {
                    b.HasOne("EMS.Core.Domain.Entities.ManagerAggregate.Manager", null)
                        .WithMany("Employees")
                        .HasForeignKey("ManagerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
