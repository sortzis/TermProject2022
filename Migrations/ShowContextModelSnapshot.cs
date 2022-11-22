﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TermProject.Models;

#nullable disable

namespace TermProject.Migrations
{
    [DbContext(typeof(ShowContext))]
    partial class ShowContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TermProject.Models.Show", b =>
                {
                    b.Property<int>("ShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShowId"));

                    b.Property<double?>("Rating")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ShowId");

                    b.ToTable("Shows");

                    b.HasData(
                        new
                        {
                            ShowId = 1,
                            Rating = 5.75,
                            Title = "Love is Blind",
                            Year = 2020
                        },
                        new
                        {
                            ShowId = 2,
                            Rating = 3.25,
                            Title = "Jersey Shore",
                            Year = 2009
                        },
                        new
                        {
                            ShowId = 3,
                            Rating = 6.0999999999999996,
                            Title = "The Bachelorette",
                            Year = 2003
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
