﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DangThiAnh037.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20230104012014_CompanyDTA037")]
    partial class CompanyDTA037
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("DangThiAnh037.Models.CompanyDTA037", b =>
                {
                    b.Property<string>("CompanyId")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("CompanyId");

                    b.ToTable("CompanyDTA037");
                });
#pragma warning restore 612, 618
        }
    }
}