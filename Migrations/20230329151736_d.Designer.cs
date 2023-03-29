﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task2.Context;

#nullable disable

namespace Task2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230329151736_d")]
    partial class d
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Task2.Models.BookingCustomerTb", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerTbCustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DeleteBy")
                        .HasColumnType("datetime2");

                    b.Property<int>("DroneLocationTbLocationId")
                        .HasColumnType("int");

                    b.Property<int>("DroneShotTbDronShotId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("drone_shot_id")
                        .HasColumnType("int");

                    b.Property<int>("location_Id")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("CustomerTbCustomerId");

                    b.HasIndex("DroneLocationTbLocationId");

                    b.HasIndex("DroneShotTbDronShotId");

                    b.ToTable("BookingCustomerTbs");
                });

            modelBuilder.Entity("Task2.Models.CustomerTb", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteBy")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerId");

                    b.ToTable("CustomerTbs");
                });

            modelBuilder.Entity("Task2.Models.DroneLocationTb", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("DroneLocationTbs");
                });

            modelBuilder.Entity("Task2.Models.DroneShotTb", b =>
                {
                    b.Property<int>("DronShotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DronShotId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DroneShotName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DurationInMinutes")
                        .HasColumnType("int");

                    b.Property<int>("MaxNumberOfPassengers")
                        .HasColumnType("int");

                    b.Property<int>("MaxSpeedInMPH")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("DronShotId");

                    b.ToTable("DroneShotTbs");
                });

            modelBuilder.Entity("Task2.Models.BookingCustomerTb", b =>
                {
                    b.HasOne("Task2.Models.CustomerTb", "CustomerTb")
                        .WithMany()
                        .HasForeignKey("CustomerTbCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Task2.Models.DroneLocationTb", "DroneLocationTb")
                        .WithMany()
                        .HasForeignKey("DroneLocationTbLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Task2.Models.DroneShotTb", "DroneShotTb")
                        .WithMany()
                        .HasForeignKey("DroneShotTbDronShotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerTb");

                    b.Navigation("DroneLocationTb");

                    b.Navigation("DroneShotTb");
                });
#pragma warning restore 612, 618
        }
    }
}
