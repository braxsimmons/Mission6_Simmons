﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_Simmons.Models;

#nullable disable

namespace Mission6_Simmons.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240211041753_plswork")]
    partial class plswork
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("Mission6_Simmons.Models.MovieModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<int>("RatingId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RatingId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Mission6_Simmons.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("Mission6_Simmons.Models.MovieModel", b =>
                {
                    b.HasOne("Mission6_Simmons.Models.Rating", "Rating")
                        .WithMany("Movies")
                        .HasForeignKey("RatingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rating");
                });

            modelBuilder.Entity("Mission6_Simmons.Models.Rating", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
