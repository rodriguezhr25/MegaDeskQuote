﻿// <auto-generated />
using System;
using MegaDeskQuote.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegaDeskQuote.Migrations
{
    [DbContext(typeof(MegaDeskQuoteContext))]
    [Migration("20200610012220_Depth")]
    partial class Depth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MegaDeskQuote.Models.DeskQuote", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CostSize")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<DateTime>("DateQuote")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DrawerCost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Drawers")
                        .HasColumnType("int");

                    b.Property<decimal>("Depth")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MaterialCost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("ShippingCost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("ShippingMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SizeOverage")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("TotalSize")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("ID");

                    b.ToTable("DeskQuote");
                });
#pragma warning restore 612, 618
        }
    }
}
