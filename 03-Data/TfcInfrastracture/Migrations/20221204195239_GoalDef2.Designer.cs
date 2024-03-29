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
    [Migration("20221204195239_GoalDef2")]
    partial class GoalDef2
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

            modelBuilder.Entity("TfcDomain.Models.Competition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("TfcDomain.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EmployeePositionId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeePositionId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("TfcDomain.Models.EmployeePosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmployeePositions");
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

                    b.HasIndex("CompetitionId");

                    b.HasIndex("FirstClubId");

                    b.HasIndex("SecondClubId");

                    b.ToTable("Match", (string)null);
                });

            modelBuilder.Entity("TfcDomain.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Birthplace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("TfcDomain.Models.PlayerAttributeSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte>("Acceleration")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Adaptability")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Aggression")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Agility")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Ambition")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Anticipation")
                        .HasColumnType("tinyint");

                    b.Property<byte>("ArealReach")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Balance")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Bravery")
                        .HasColumnType("tinyint");

                    b.Property<byte>("CommandOfArea")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Communication")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Composure")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Concentration")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Consistency")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Controversy")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Corners")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Crossing")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Decisions")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Determination")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Dirtiness")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Drybbling")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Eccentricity")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Finishing")
                        .HasColumnType("tinyint");

                    b.Property<byte>("FirstTouch")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Flair")
                        .HasColumnType("tinyint");

                    b.Property<byte>("FreeKicks")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Handling")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Heading")
                        .HasColumnType("tinyint");

                    b.Property<byte>("ImportantMatches")
                        .HasColumnType("tinyint");

                    b.Property<byte>("InjuryProneness")
                        .HasColumnType("tinyint");

                    b.Property<byte>("JumpingReach")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Kicking")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("Leadership")
                        .HasColumnType("tinyint");

                    b.Property<byte>("LongShots")
                        .HasColumnType("tinyint");

                    b.Property<byte>("LongThrows")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Loyality")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Marking")
                        .HasColumnType("tinyint");

                    b.Property<byte>("NaturalFitness")
                        .HasColumnType("tinyint");

                    b.Property<byte>("OffTheBall")
                        .HasColumnType("tinyint");

                    b.Property<byte>("OneOnOnes")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Pace")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Passing")
                        .HasColumnType("tinyint");

                    b.Property<byte>("PenalityTaking")
                        .HasColumnType("tinyint");

                    b.Property<int>("PlayerID")
                        .HasColumnType("int");

                    b.Property<byte>("Positioning")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Pressure")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Professionalism")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Reflex")
                        .HasColumnType("tinyint");

                    b.Property<byte>("RushingOut")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Sportmanship")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Stamina")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Strength")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Tackling")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Teamwork")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Technique")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Temperament")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Throwing")
                        .HasColumnType("tinyint");

                    b.Property<byte>("TrendToPunch")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Versatility")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Vision")
                        .HasColumnType("tinyint");

                    b.Property<byte>("WorkRate")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.HasIndex("PlayerID");

                    b.ToTable("PlayerAttributeSets");
                });

            modelBuilder.Entity("TfcDomain.Models.Employee", b =>
                {
                    b.HasOne("TfcDomain.Models.EmployeePosition", "EmployeePosition")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeePositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeePosition");
                });

            modelBuilder.Entity("TfcDomain.Models.Match", b =>
                {
                    b.HasOne("TfcDomain.Models.Competition", "Competition")
                        .WithMany("Matches")
                        .HasForeignKey("CompetitionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TfcDomain.Models.Club", "FirstClub")
                        .WithMany("FirstClubMatches")
                        .HasForeignKey("FirstClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TfcDomain.Models.Club", "SecondClub")
                        .WithMany("SecondClubMatches")
                        .HasForeignKey("SecondClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competition");

                    b.Navigation("FirstClub");

                    b.Navigation("SecondClub");
                });

            modelBuilder.Entity("TfcDomain.Models.PlayerAttributeSet", b =>
                {
                    b.HasOne("TfcDomain.Models.Player", null)
                        .WithMany("PlayerAttributeSet")
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TfcDomain.Models.Club", b =>
                {
                    b.Navigation("FirstClubMatches");

                    b.Navigation("SecondClubMatches");
                });

            modelBuilder.Entity("TfcDomain.Models.Competition", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("TfcDomain.Models.EmployeePosition", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("TfcDomain.Models.Player", b =>
                {
                    b.Navigation("PlayerAttributeSet");
                });
#pragma warning restore 612, 618
        }
    }
}
