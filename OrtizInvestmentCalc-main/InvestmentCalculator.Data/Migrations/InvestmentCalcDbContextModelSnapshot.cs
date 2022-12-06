﻿// <auto-generated />
using InvestmentCalculator.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InvestmentCalculator.Data.Migrations
{
    [DbContext(typeof(InvestmentCalcDbContext))]
    partial class InvestmentCalcDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("InvestmentCalculator.Data.Models.InvestmentCalc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Compounds")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Full")
                        .HasColumnType("REAL");

                    b.Property<double>("Interest")
                        .HasColumnType("REAL");

                    b.Property<double>("Principal")
                        .HasColumnType("REAL");

                    b.Property<int>("Years")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("InvestmentCalcs");
                });
#pragma warning restore 612, 618
        }
    }
}
