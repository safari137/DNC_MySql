using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySqlApi.DAL;

namespace MySqlApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170708160815_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("MySqlApi.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("Credit");

                    b.Property<decimal?>("Debit");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });
        }
    }
}
