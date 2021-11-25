﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace attendance.Migrations
{
    [DbContext(typeof(AttendanceContext))]
    partial class AttendanceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("attendance.Models.Attendance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("BreakeTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ClockingOut")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ClonkingIn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("WorkingDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("WorkingTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Attendance");
                });
#pragma warning restore 612, 618
        }
    }
}
