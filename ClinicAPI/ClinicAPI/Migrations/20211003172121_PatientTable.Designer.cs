﻿// <auto-generated />
using ClinicAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClinicAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20211003172121_PatientTable")]
    partial class PatientTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClinicAPI.Data.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<string>("Speciality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Adelaida",
                            OfficeId = 1,
                            Speciality = "Gynecology",
                            Surname = "Timko"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Zehang",
                            OfficeId = 2,
                            Speciality = "Surgery",
                            Surname = "Wang"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sasha",
                            OfficeId = 3,
                            Speciality = "Psychology",
                            Surname = "Steklovata"
                        });
                });

            modelBuilder.Entity("ClinicAPI.Data.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Offices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Floor = 1,
                            Name = "Gynecology office"
                        },
                        new
                        {
                            Id = 2,
                            Floor = 1,
                            Name = "Surgeon office"
                        },
                        new
                        {
                            Id = 3,
                            Floor = 1,
                            Name = "Psychiatry office"
                        });
                });

            modelBuilder.Entity("ClinicAPI.Data.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DoctorId = 1,
                            Name = "Natasha",
                            Surname = "Sasha"
                        },
                        new
                        {
                            Id = 2,
                            DoctorId = 1,
                            Name = "Katyusha",
                            Surname = "Miroshnychenko"
                        },
                        new
                        {
                            Id = 3,
                            DoctorId = 1,
                            Name = "Sasha",
                            Surname = "Kovt"
                        },
                        new
                        {
                            Id = 4,
                            DoctorId = 2,
                            Name = "Anastasia",
                            Surname = "Shutova"
                        },
                        new
                        {
                            Id = 5,
                            DoctorId = 3,
                            Name = "Anja",
                            Surname = "Melchenko"
                        });
                });

            modelBuilder.Entity("ClinicAPI.Data.Doctor", b =>
                {
                    b.HasOne("ClinicAPI.Data.Office", "Office")
                        .WithMany()
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Office");
                });

            modelBuilder.Entity("ClinicAPI.Data.Patient", b =>
                {
                    b.HasOne("ClinicAPI.Data.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });
#pragma warning restore 612, 618
        }
    }
}