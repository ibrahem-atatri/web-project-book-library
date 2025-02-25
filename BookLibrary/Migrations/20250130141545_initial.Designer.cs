﻿// <auto-generated />
using System;
using BookLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookLibrary.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20250130141545_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BookLibrary.Models.Book", b =>
                {
                    b.Property<int>("bookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bookId"), 1L, 1);

                    b.Property<string>("bookCoverImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bookGenre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("bookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            bookId = 1,
                            bookCoverImage = "https://example.com/harry-potter.jpg",
                            bookGenre = "Fantasy",
                            bookName = "Harry Potter and the Philosopher's Stone"
                        },
                        new
                        {
                            bookId = 2,
                            bookCoverImage = "https://example.com/game-of-thrones.jpg",
                            bookGenre = "Fantasy",
                            bookName = "A Game of Thrones"
                        },
                        new
                        {
                            bookId = 3,
                            bookCoverImage = "https://example.com/the-shining.jpg",
                            bookGenre = "Horror",
                            bookName = "The Shining"
                        });
                });

            modelBuilder.Entity("BookLibrary.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"), 1L, 1);

                    b.Property<bool?>("userAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("userEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPassword")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("userId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            userId = 1,
                            userAdmin = true,
                            userEmail = "admin@gmail.com",
                            userName = "Admin",
                            userPassword = "Admin@123"
                        },
                        new
                        {
                            userId = 2,
                            userAdmin = false,
                            userEmail = "johndoe@gmail.com",
                            userName = "JohnDoe",
                            userPassword = "JohnDoe@123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
