﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace attendance.Migrations
{
    [DbContext(typeof(AttendanceContext))]
<<<<<<< Updated upstream:attendance/Migrations/20211118080831_InitialCreate.Designer.cs
    [Migration("20211118080831_InitialCreate")]
=======
    [Migration("20211123111612_InitialCreate")]
>>>>>>> Stashed changes:attendance/Migrations/20211123111612_InitialCreate.Designer.cs
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("attendance.Models.Attendance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BreakeTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ClockingOut")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ClonkingIn")
                        .HasColumnType("TEXT");

<<<<<<< Updated upstream:attendance/Migrations/20211118080831_InitialCreate.Designer.cs
                    b.Property<string>("WorkingDate")
=======
                    b.Property<int?>("EmployeeID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("WorkingDate")
>>>>>>> Stashed changes:attendance/Migrations/20211123111612_InitialCreate.Designer.cs
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("WorkingTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Attendance");
                });

            modelBuilder.Entity("attendance.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("attendance.Models.Attendance", b =>
                {
                    b.HasOne("attendance.Models.Employee", "Employee")
                        .WithMany("Posts")
                        .HasForeignKey("EmployeeID");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("attendance.Models.Employee", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
