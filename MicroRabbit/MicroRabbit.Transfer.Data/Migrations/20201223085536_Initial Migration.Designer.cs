﻿// <auto-generated />
using MicroRabbit.Transfer.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MicroRabbit.Transfer.Data.Migrations
{
    [DbContext(typeof(TransferDbContext))]
    [Migration("20201223085536_Initial Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("MicroRabbit.Transfer.Domain.Models.TransferLog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("FromAccount")
                        .HasColumnType("int");

                    b.Property<int>("ToAccount")
                        .HasColumnType("int");

                    b.Property<decimal>("TransferAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("TransferLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
