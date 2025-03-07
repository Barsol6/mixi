﻿// <auto-generated />
using System;
using System.Net.Mime;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mixi.Modules.Database;

#nullable disable

namespace Fracture.Server.Migrations
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
                    b.HasKey("Id");

                    b.ToTable("Users");
                });
            
#pragma warning restore 612, 618
        }
    }
}
