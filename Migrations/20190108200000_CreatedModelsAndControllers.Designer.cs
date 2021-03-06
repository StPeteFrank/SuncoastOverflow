﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using content;

namespace content.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190108200000_CreatedModelsAndControllers")]
    partial class CreatedModelsAndControllers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SuncoastOverflow.Models.Answers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnswerAuthor");

                    b.Property<string>("AnswerBody");

                    b.Property<DateTime>("AnswerCreatedTime");

                    b.Property<int>("AnswerVotes");

                    b.Property<int>("QuestionId");

                    b.Property<int?>("QuestionsId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionsId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("SuncoastOverflow.Models.Questions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("QuestionAuthor");

                    b.Property<string>("QuestionBody");

                    b.Property<DateTime>("QuestionCreatedTime");

                    b.Property<string>("QuestionTitle");

                    b.Property<int>("QuestionVotes");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("SuncoastOverflow.Models.Answers", b =>
                {
                    b.HasOne("SuncoastOverflow.Models.Questions", "Questions")
                        .WithMany("Answer")
                        .HasForeignKey("QuestionsId");
                });
#pragma warning restore 612, 618
        }
    }
}
