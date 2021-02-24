﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication9;

namespace WebApplication9.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210224221300_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("WebApplication8.Domain.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CarOwnerId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CarOwnerId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("WebApplication8.Domain.CarOwner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CarOwners");
                });

            modelBuilder.Entity("WebApplication8.Domain.Car", b =>
                {
                    b.HasOne("WebApplication8.Domain.CarOwner", "CarOwner")
                        .WithMany("Cars")
                        .HasForeignKey("CarOwnerId");

                    b.Navigation("CarOwner");
                });

            modelBuilder.Entity("WebApplication8.Domain.CarOwner", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}