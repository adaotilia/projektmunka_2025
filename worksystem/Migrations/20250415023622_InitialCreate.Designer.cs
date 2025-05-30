﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using worksystem.Data;

#nullable disable

namespace worksystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250415023622_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("worksystem.Models.Checkpoint", b =>
                {
                    b.Property<int>("CheckpointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CheckInTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("CheckOutTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("SessionStatus")
                        .HasColumnType("int");

                    b.HasKey("CheckpointId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Checkpoints");
                });

            modelBuilder.Entity("worksystem.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("worksystem.Models.Monthlyreport", b =>
                {
                    b.Property<int>("MonthlyreportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal>("MonthlyOvertimeHours")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("MonthlyWorkDays")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("MonthlyWorkHours")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("OvertimeHours")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateOnly>("ReportMonth")
                        .HasColumnType("date");

                    b.Property<decimal>("WorkHours")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("MonthlyreportId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Monthlyreports");
                });

            modelBuilder.Entity("worksystem.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("EndTime")
                        .HasColumnType("time(6)");

                    b.Property<DateOnly>("ScheduledDate")
                        .HasColumnType("date");

                    b.Property<decimal>("ScheduledHours")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("ScheduledMonthlyHours")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("ScheduledWorkDays")
                        .HasColumnType("decimal(65,30)");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time(6)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ScheduleId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("worksystem.Models.Worklog", b =>
                {
                    b.Property<int>("WorklogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("MonthlyOvertimeHours")
                        .HasColumnType("int");

                    b.Property<decimal?>("MonthlyWorkDays")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("OvertimeHours")
                        .HasColumnType("int");

                    b.Property<DateOnly>("ScheduledDate")
                        .HasColumnType("date");

                    b.Property<int?>("ScheduledHours")
                        .HasColumnType("int");

                    b.Property<int?>("ScheduledOvertime")
                        .HasColumnType("int");

                    b.Property<int?>("ScheduledWorkDays")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int?>("WorkHours")
                        .HasColumnType("int");

                    b.HasKey("WorklogId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Worklogs");
                });

            modelBuilder.Entity("worksystem.Models.Checkpoint", b =>
                {
                    b.HasOne("worksystem.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("worksystem.Models.Monthlyreport", b =>
                {
                    b.HasOne("worksystem.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("worksystem.Models.Schedule", b =>
                {
                    b.HasOne("worksystem.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("worksystem.Models.Worklog", b =>
                {
                    b.HasOne("worksystem.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
