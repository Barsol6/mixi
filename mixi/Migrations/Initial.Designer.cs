﻿// <auto-generated />

#nullable disable

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using mixi.Modules.Database;

namespace mixi.Migrations
{
    [DbContext(typeof(MixiDbContext))]
    [Migration("20240520174514_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

           
            modelBuilder.Entity("Fracture.Server.Modules.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");
                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");
                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("TEXT");
                    b.HasKey("Id");

                    b.ToTable("Users");
                });
            
#pragma warning restore 612, 618
        }
    }
}
