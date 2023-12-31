﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using mersad_dev.Data;

#nullable disable

namespace mersad_dev.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20230921041545_ModifyCourseThumbnail")]
    partial class ModifyCourseThumbnail
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("mersad_dev.Entities.Courses.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Descriptions")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Episode")
                        .HasColumnType("integer");

                    b.Property<string>("Instructor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Keyword")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte[]>("Thumbnail")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("ThumbnailFileExtention")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ThumbnailFileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("ThumbnailFileSize")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<long>("Tuition")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("InitCourses", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
