﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NBDcase.Data;

namespace NBDcase.Data.NBDMigrations
{
    [DbContext(typeof(NBDContext))]
    partial class NBDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("NBD")
                .HasAnnotation("ProductVersion", "3.1.13");

            modelBuilder.Entity("NBDcase.Models.Bid", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ApprovalbyClient")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("ApprovalbyNBD")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("BidAmount")
                        .HasColumnType("decimal(19,2)");

                    b.Property<DateTime>("BidDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("BidHours")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DesignerID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EstBeginDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EstComplDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SalesID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("DesignerID");

                    b.HasIndex("ProjectID");

                    b.HasIndex("SalesID");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("NBDcase.Models.BidEmployees", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BidID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("BidID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("BidEmployees");
                });

            modelBuilder.Entity("NBDcase.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NBDcase.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<long>("Phone")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("NBDcase.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("LaborID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<long>("Phone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("eMail")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.HasKey("ID");

                    b.HasIndex("LaborID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("NBDcase.Models.EmployeeAcc", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<string>("FavouriteIceCream")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("EmployeeAccs");
                });

            modelBuilder.Entity("NBDcase.Models.Inventory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BidID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaterialID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("BidID");

                    b.HasIndex("MaterialID");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("NBDcase.Models.Labor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("LaborCost")
                        .HasColumnType("decimal(19,2)");

                    b.Property<decimal>("LaborPrice")
                        .HasColumnType("decimal(19,2)");

                    b.Property<string>("LaborType")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Labors");
                });

            modelBuilder.Entity("NBDcase.Models.Material", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(10);

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(19,2)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("NBDcase.Models.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ClientID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CompleteDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("ProjectSite")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("NBDcase.Models.Staff", b =>
                {
                    b.Property<int>("BidID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LaborID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Hours")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(19,2)");

                    b.HasKey("BidID", "LaborID");

                    b.HasIndex("LaborID");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("NBDcase.Models.Bid", b =>
                {
                    b.HasOne("NBDcase.Models.Employee", "Designer")
                        .WithMany()
                        .HasForeignKey("DesignerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NBDcase.Models.Project", "Project")
                        .WithMany("Bids")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NBDcase.Models.Employee", "Sales")
                        .WithMany()
                        .HasForeignKey("SalesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NBDcase.Models.BidEmployees", b =>
                {
                    b.HasOne("NBDcase.Models.Bid", "Bid")
                        .WithMany("BidEmployees")
                        .HasForeignKey("BidID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NBDcase.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NBDcase.Models.Employee", b =>
                {
                    b.HasOne("NBDcase.Models.Labor", "Labor")
                        .WithMany("Employees")
                        .HasForeignKey("LaborID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("NBDcase.Models.Inventory", b =>
                {
                    b.HasOne("NBDcase.Models.Bid", "Bid")
                        .WithMany("Inventories")
                        .HasForeignKey("BidID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NBDcase.Models.Material", "Material")
                        .WithMany("Inventories")
                        .HasForeignKey("MaterialID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("NBDcase.Models.Material", b =>
                {
                    b.HasOne("NBDcase.Models.Category", "Category")
                        .WithMany("Materials")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("NBDcase.Models.Project", b =>
                {
                    b.HasOne("NBDcase.Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("NBDcase.Models.Staff", b =>
                {
                    b.HasOne("NBDcase.Models.Bid", "Bid")
                        .WithMany("Staffs")
                        .HasForeignKey("BidID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NBDcase.Models.Labor", "Labor")
                        .WithMany("Staffs")
                        .HasForeignKey("LaborID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
