﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission10API_fairbanks.Data;

#nullable disable

namespace mission10API_fairbanks.Migrations
{
    [DbContext(typeof(BowlerDbContext))]
    [Migration("20250314212142_MakeFieldsNullable")]
    partial class MakeFieldsNullable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.13");

            modelBuilder.Entity("mission10API_fairbanks.Data.Bowler", b =>
                {
                    b.Property<int>("BowlerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BowlerAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerLastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerMiddleInit")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerPhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerState")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerZip")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TeamID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BowlerID");

                    b.HasIndex("TeamID");

                    b.ToTable("Bowlers");
                });

            modelBuilder.Entity("mission10API_fairbanks.Data.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TeamID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("mission10API_fairbanks.Data.Bowler", b =>
                {
                    b.HasOne("mission10API_fairbanks.Data.Team", "Team")
                        .WithMany("Bowlers")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Team");
                });

            modelBuilder.Entity("mission10API_fairbanks.Data.Team", b =>
                {
                    b.Navigation("Bowlers");
                });
#pragma warning restore 612, 618
        }
    }
}
