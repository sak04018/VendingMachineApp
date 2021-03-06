﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VendingMachineApp;

namespace VendingMachineApp.Migrations
{
    [DbContext(typeof(VendingModel))]
    [Migration("20181030212017_MyMigration")]
    partial class MyMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VendingMachineApp.Transaction", b =>
                {
                    b.Property<int>("TransactionNumber")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Selection");

                    b.Property<string>("SnackName");

                    b.Property<DateTime>("TransactionDate");

                    b.HasKey("TransactionNumber")
                        .HasName("Transaction_Number");

                    b.ToTable("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
