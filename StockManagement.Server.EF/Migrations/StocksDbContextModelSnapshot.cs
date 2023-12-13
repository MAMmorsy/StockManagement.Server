﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockManagement.Server.EF.Context;

#nullable disable

namespace StockManagement.Server.EF.Migrations
{
    [DbContext(typeof(StocksDbContext))]
    partial class StocksDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StockManagement.Server.CORE.Models.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("StockId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("StockId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("StockManagement.Server.CORE.Models.Entities.Stock", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StockId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("StockId");

                    b.ToTable("Stocks");

                    b.HasData(
                        new
                        {
                            StockId = 1,
                            Name = "Vianet",
                            Price = 45.84m
                        },
                        new
                        {
                            StockId = 2,
                            Name = "Agritek",
                            Price = 13.25m
                        },
                        new
                        {
                            StockId = 3,
                            Name = "Akamai",
                            Price = 80.29m
                        },
                        new
                        {
                            StockId = 4,
                            Name = "Baidu",
                            Price = 74.10m
                        },
                        new
                        {
                            StockId = 5,
                            Name = "Blinkx",
                            Price = 89.96m
                        },
                        new
                        {
                            StockId = 6,
                            Name = "Blucora",
                            Price = 79.1m
                        },
                        new
                        {
                            StockId = 7,
                            Name = "Boingo",
                            Price = 17.84m
                        },
                        new
                        {
                            StockId = 8,
                            Name = "Brainybrawn",
                            Price = 76.26m
                        },
                        new
                        {
                            StockId = 9,
                            Name = "Carbonite",
                            Price = 65.17m
                        },
                        new
                        {
                            StockId = 10,
                            Name = "China Finance",
                            Price = 8.69m
                        },
                        new
                        {
                            StockId = 11,
                            Name = "ChinaCache",
                            Price = 48.22m
                        },
                        new
                        {
                            StockId = 12,
                            Name = "ADR",
                            Price = 67.97m
                        },
                        new
                        {
                            StockId = 13,
                            Name = "ChitrChatr",
                            Price = 66.91m
                        },
                        new
                        {
                            StockId = 14,
                            Name = "Cnova",
                            Price = 68.12m
                        },
                        new
                        {
                            StockId = 15,
                            Name = "Cogent",
                            Price = 65.83m
                        },
                        new
                        {
                            StockId = 16,
                            Name = "Crexendo",
                            Price = 5.14m
                        },
                        new
                        {
                            StockId = 17,
                            Name = "CrowdGather",
                            Price = 95.31m
                        },
                        new
                        {
                            StockId = 18,
                            Name = "EarthLink",
                            Price = 90.83m
                        },
                        new
                        {
                            StockId = 19,
                            Name = "Eastern",
                            Price = 57.43m
                        },
                        new
                        {
                            StockId = 20,
                            Name = "ENDEXX",
                            Price = 57.93m
                        },
                        new
                        {
                            StockId = 21,
                            Name = "Envestnet",
                            Price = 89.75m
                        },
                        new
                        {
                            StockId = 22,
                            Name = "Epazz",
                            Price = 56.45m
                        },
                        new
                        {
                            StockId = 23,
                            Name = "FlashZero",
                            Price = 84.69m
                        },
                        new
                        {
                            StockId = 24,
                            Name = "Genesis",
                            Price = 25.51m
                        },
                        new
                        {
                            StockId = 25,
                            Name = "InterNAP",
                            Price = 43.46m
                        },
                        new
                        {
                            StockId = 26,
                            Name = "MeetMe",
                            Price = 38.97m
                        },
                        new
                        {
                            StockId = 27,
                            Name = "Netease",
                            Price = 49.58m
                        },
                        new
                        {
                            StockId = 28,
                            Name = "Qihoo",
                            Price = 50.68m
                        });
                });

            modelBuilder.Entity("StockManagement.Server.CORE.Models.Entities.Order", b =>
                {
                    b.HasOne("StockManagement.Server.CORE.Models.Entities.Stock", "stock")
                        .WithMany("Orders")
                        .HasForeignKey("StockId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("stock");
                });

            modelBuilder.Entity("StockManagement.Server.CORE.Models.Entities.Stock", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
