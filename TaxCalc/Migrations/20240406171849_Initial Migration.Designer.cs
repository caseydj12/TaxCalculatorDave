﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaxCalc.Data;

#nullable disable

namespace TaxCalc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240406171849_Initial Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TaxCalc.Models.TaxViewModel", b =>
                {
                    b.Property<Guid>("TaxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("AnnualTaxPaid")
                        .HasColumnType("float");

                    b.Property<double>("GrossAnnualSalary")
                        .HasColumnType("float");

                    b.Property<double>("GrossMonthlySalary")
                        .HasColumnType("float");

                    b.Property<double>("MonthlyTaxPaid")
                        .HasColumnType("float");

                    b.Property<double>("NetAnnualSalary")
                        .HasColumnType("float");

                    b.Property<double>("NetMonthlySalary")
                        .HasColumnType("float");

                    b.HasKey("TaxId");

                    b.ToTable("TaxIds");
                });
#pragma warning restore 612, 618
        }
    }
}
