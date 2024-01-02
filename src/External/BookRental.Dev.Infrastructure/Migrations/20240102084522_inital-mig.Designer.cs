﻿// <auto-generated />
using System;
using BookRental.Dev.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BookRental.Dev.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240102084522_inital-mig")]
    partial class initalmig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BookPublisher", b =>
                {
                    b.Property<Guid>("BooksId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PublishersId")
                        .HasColumnType("uuid");

                    b.HasKey("BooksId", "PublishersId");

                    b.HasIndex("PublishersId");

                    b.ToTable("BookPublisher");
                });

            modelBuilder.Entity("BookRental.Dev.Domain.Entities.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bfbfc67b-05bb-4409-bdf4-7bb945eb2ca6"),
                            Age = 45,
                            CreateDate = new DateTime(2024, 1, 2, 11, 45, 22, 619, DateTimeKind.Local).AddTicks(6989),
                            FirstName = "Author1 FirstName",
                            LastName = "Author1 LastName",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("1333fa6e-bdaa-4a16-a532-4f7671b961cf"),
                            Age = 65,
                            CreateDate = new DateTime(2024, 1, 2, 11, 45, 22, 619, DateTimeKind.Local).AddTicks(7008),
                            FirstName = "Author2 FirstName",
                            LastName = "Author2 LastName",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BookRental.Dev.Domain.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Stock")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookRental.Dev.Domain.Entities.Publisher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PublisherSpecId")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5062fa98-70c3-4271-a8b5-8b4357d55c2c"),
                            CreateDate = new DateTime(2024, 1, 2, 11, 45, 22, 619, DateTimeKind.Local).AddTicks(7128),
                            Name = "Publisher1",
                            PublisherSpecId = "1k8g6Hf0ad9Z4",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("959e4999-3845-46e6-938c-b6472362785f"),
                            CreateDate = new DateTime(2024, 1, 2, 11, 45, 22, 619, DateTimeKind.Local).AddTicks(7131),
                            Name = "Publisher2",
                            PublisherSpecId = "L9jf71jfyh9F9",
                            UpdateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BookPublisher", b =>
                {
                    b.HasOne("BookRental.Dev.Domain.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookRental.Dev.Domain.Entities.Publisher", null)
                        .WithMany()
                        .HasForeignKey("PublishersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookRental.Dev.Domain.Entities.Book", b =>
                {
                    b.HasOne("BookRental.Dev.Domain.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("BookRental.Dev.Domain.Entities.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
