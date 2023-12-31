﻿// <auto-generated />
using HW1API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HW1API.Migrations
{
    [DbContext(typeof(HomeworkDbContext))]
    [Migration("20230924224129_NewLessonModel")]
    partial class NewLessonModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("HW1API.Entities.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LessonSubject")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("LessonId");

                    b.ToTable("LessonChart");
                });

            modelBuilder.Entity("HW1API.Entities.Template", b =>
                {
                    b.Property<int>("TempleteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<float>("TrueValue")
                        .HasColumnType("REAL");

                    b.HasKey("TempleteID");

                    b.ToTable("Table Example");
                });
#pragma warning restore 612, 618
        }
    }
}
