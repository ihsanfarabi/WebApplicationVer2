﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplicationVer2.Models;

namespace WebApplicationVer2.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210302135757_Fourth")]
    partial class Fourth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplicationVer2.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.HasIndex("GroupId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("WebApplicationVer2.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("WebApplicationVer2.Models.Warehouse", b =>
                {
                    b.Property<int>("WarehouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WarehouseId");

                    b.HasIndex("GroupId")
                        .IsUnique()
                        .HasFilter("[GroupId] IS NOT NULL");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("WebApplicationVer2.Models.City", b =>
                {
                    b.HasOne("WebApplicationVer2.Models.Group", "Group")
                        .WithMany("Cities")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("WebApplicationVer2.Models.Warehouse", b =>
                {
                    b.HasOne("WebApplicationVer2.Models.Group", "Group")
                        .WithOne("Warehouses")
                        .HasForeignKey("WebApplicationVer2.Models.Warehouse", "GroupId");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("WebApplicationVer2.Models.Group", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("Warehouses");
                });
#pragma warning restore 612, 618
        }
    }
}
