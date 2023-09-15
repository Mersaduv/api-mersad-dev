﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using mersad_dev.Data;

#nullable disable

namespace mersad_dev.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("mersad_dev.Entities.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Instructor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Tuition")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("78debb24-e076-4f5a-a7ee-c84470463b70"),
                            Category = "course",
                            CategoryId = 1,
                            Created = new DateTime(2023, 9, 14, 8, 49, 1, 33, DateTimeKind.Utc).AddTicks(4711),
                            Instructor = "mrsd",
                            IsOnline = true,
                            LastUpdated = new DateTime(2023, 9, 14, 8, 49, 1, 33, DateTimeKind.Utc).AddTicks(4717),
                            Title = "evlore,pw",
                            Tuition = 100.0
                        },
                        new
                        {
                            Id = new Guid("de933b40-8150-4bc3-8f9f-29419fc6d136"),
                            Category = "course",
                            CategoryId = 1,
                            Created = new DateTime(2023, 9, 14, 8, 49, 1, 33, DateTimeKind.Utc).AddTicks(4721),
                            Instructor = "mrsd 2",
                            IsOnline = true,
                            LastUpdated = new DateTime(2023, 9, 14, 8, 49, 1, 33, DateTimeKind.Utc).AddTicks(4722),
                            Title = "evlore,pw",
                            Tuition = 200.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
