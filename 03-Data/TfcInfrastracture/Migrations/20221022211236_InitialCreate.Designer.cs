﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TfcInfrastracture.DbContext;

#nullable disable

namespace TfcInfrastracture.Migrations
{
    [DbContext(typeof(TheFootballClientContext))]
    [Migration("20221022211236_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TfcDomain.Models.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("FoundingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Club", (string)null);
                });

            modelBuilder.Entity("TfcDomain.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompetitionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("FirstClubId")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("FirstTeamScore")
                        .HasColumnType("int");

                    b.Property<int>("SecondClubId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("SecondTeamScore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FirstClubId");

                    b.HasIndex("SecondClubId");

                    b.ToTable("Match", (string)null);
                });

            modelBuilder.Entity("TfcDomain.Models.Match", b =>
                {
                    b.HasOne("TfcDomain.Models.Club", "FirstClub")
                        .WithMany("FirstClubMatches")
                        .HasForeignKey("FirstClubId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TfcDomain.Models.Club", "SecondClub")
                        .WithMany("SecondClubMatches")
                        .HasForeignKey("SecondClubId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("FirstClub");

                    b.Navigation("SecondClub");
                });

            modelBuilder.Entity("TfcDomain.Models.Club", b =>
                {
                    b.Navigation("FirstClubMatches");

                    b.Navigation("SecondClubMatches");
                });
#pragma warning restore 612, 618
        }
    }
}
