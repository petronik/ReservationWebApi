﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReservationWebApi.Data;

namespace ReservationWebApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("ReservationWebApi.Models.MenuItem", b =>
                {
                    b.Property<int>("M_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("M_name")
                        .HasColumnType("longtext");

                    b.Property<double>("M_price")
                        .HasColumnType("double");

                    b.HasKey("M_Id");

                    b.ToTable("MenuItem");
                });

            modelBuilder.Entity("ReservationWebApi.Models.Reservation", b =>
                {
                    b.Property<int>("R_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("R_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("R_Name")
                        .HasColumnType("longtext");

                    b.HasKey("R_Id");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("ReservationWebApi.Models.ReservationMenuItem", b =>
                {
                    b.Property<int>("Rm_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("MenuItem_Id")
                        .HasColumnType("int");

                    b.Property<int>("Reservation_Id")
                        .HasColumnType("int");

                    b.HasKey("Rm_Id");

                    b.HasIndex("MenuItem_Id");

                    b.HasIndex("Reservation_Id");

                    b.ToTable("ReservationMenuItem");
                });

            modelBuilder.Entity("ReservationWebApi.Models.ReservationMenuItem", b =>
                {
                    b.HasOne("ReservationWebApi.Models.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItem_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ReservationWebApi.Models.Reservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("Reservation_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");

                    b.Navigation("Reservation");
                });
#pragma warning restore 612, 618
        }
    }
}
