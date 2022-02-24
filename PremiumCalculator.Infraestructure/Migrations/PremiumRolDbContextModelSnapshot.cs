﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PremiumCalculator.Infraestructure;

#nullable disable

namespace PremiumCalculator.Infraestructure.Migrations
{
    [DbContext(typeof(PremiumRolDbContext))]
    partial class PremiumRolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("PremiumCalculator.Domain.Period", b =>
                {
                    b.Property<string>("IdPeriod")
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<int>("Factor")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NamePeriod")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("IdPeriod");

                    b.ToTable("Periods");

                    b.HasData(
                        new
                        {
                            IdPeriod = "M",
                            Factor = 1,
                            NamePeriod = "Montly"
                        },
                        new
                        {
                            IdPeriod = "Q",
                            Factor = 3,
                            NamePeriod = "Quartely"
                        },
                        new
                        {
                            IdPeriod = "S",
                            Factor = 6,
                            NamePeriod = "Semi-Anually"
                        },
                        new
                        {
                            IdPeriod = "A",
                            Factor = 12,
                            NamePeriod = "Annually"
                        });
                });

            modelBuilder.Entity("PremiumCalculator.Domain.Plan", b =>
                {
                    b.Property<string>("PlanId")
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<string>("PlanName")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("PlanId");

                    b.ToTable("Plans");

                    b.HasData(
                        new
                        {
                            PlanId = "A",
                            PlanName = "Plan A"
                        },
                        new
                        {
                            PlanId = "B",
                            PlanName = "Plan B"
                        },
                        new
                        {
                            PlanId = "C",
                            PlanName = "Plan C"
                        });
                });

            modelBuilder.Entity("PremiumCalculator.Domain.PremiumRol", b =>
                {
                    b.Property<int>("PremiumRolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Age")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Carrier")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MonthOfBirth")
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Plan")
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<double>("Premium")
                        .HasColumnType("REAL");

                    b.Property<string>("State")
                        .HasMaxLength(3)
                        .HasColumnType("TEXT");

                    b.HasKey("PremiumRolID");

                    b.ToTable("PremiumRols");

                    b.HasData(
                        new
                        {
                            PremiumRolID = 1,
                            Age = "21-45",
                            Carrier = "Qwerty",
                            Id = 0,
                            MonthOfBirth = "September",
                            Plan = "A",
                            Premium = 150.0,
                            State = "NY"
                        },
                        new
                        {
                            PremiumRolID = 2,
                            Age = "46-65",
                            Carrier = "Qwerty",
                            Id = 0,
                            MonthOfBirth = "January",
                            Plan = "B",
                            Premium = 200.5,
                            State = "NY"
                        },
                        new
                        {
                            PremiumRolID = 3,
                            Age = "18-65",
                            Carrier = "Qwerty",
                            Id = 0,
                            MonthOfBirth = "*",
                            Plan = "A,C",
                            Premium = 120.98999999999999,
                            State = "NY"
                        },
                        new
                        {
                            PremiumRolID = 4,
                            Age = "18-65",
                            Carrier = "Qwerty",
                            Id = 0,
                            MonthOfBirth = "November",
                            Plan = "A",
                            Premium = 85.5,
                            State = "AL"
                        },
                        new
                        {
                            PremiumRolID = 5,
                            Age = "18-65",
                            Carrier = "Qwerty",
                            Id = 0,
                            MonthOfBirth = "*",
                            Plan = "C",
                            Premium = 100.0,
                            State = "AL"
                        },
                        new
                        {
                            PremiumRolID = 6,
                            Age = "65+",
                            Carrier = "Qwerty",
                            Id = 0,
                            MonthOfBirth = "December",
                            Plan = "A",
                            Premium = 175.19999999999999,
                            State = "AK"
                        },
                        new
                        {
                            PremiumRolID = 7,
                            Age = "18-64",
                            Carrier = "Qwerty",
                            Id = 0,
                            MonthOfBirth = "December",
                            Plan = "A",
                            Premium = 125.16,
                            State = "AK"
                        },
                        new
                        {
                            PremiumRolID = 8,
                            Age = "18-65",
                            Carrier = "Qwerty",
                            Id = 0,
                            MonthOfBirth = "*",
                            Plan = "B",
                            Premium = 100.8,
                            State = "AK"
                        },
                        new
                        {
                            PremiumRolID = 9,
                            Age = "18-65",
                            Carrier = "Qwerty",
                            Id = 0,
                            MonthOfBirth = "*",
                            Plan = "A,C",
                            Premium = 90.0,
                            State = "*"
                        },
                        new
                        {
                            PremiumRolID = 10,
                            Age = "21-45",
                            Carrier = "Asdf",
                            Id = 0,
                            MonthOfBirth = "October",
                            Plan = "A",
                            Premium = 150.0,
                            State = "NY"
                        },
                        new
                        {
                            PremiumRolID = 11,
                            Age = "46-65",
                            Carrier = "Asdf",
                            Id = 0,
                            MonthOfBirth = "January",
                            Plan = "B",
                            Premium = 184.5,
                            State = "NY"
                        },
                        new
                        {
                            PremiumRolID = 12,
                            Age = "18-65",
                            Carrier = "Asdf",
                            Id = 0,
                            MonthOfBirth = "*",
                            Plan = "A",
                            Premium = 129.94999999999999,
                            State = "NY"
                        },
                        new
                        {
                            PremiumRolID = 13,
                            Age = "18-65",
                            Carrier = "Asdf",
                            Id = 0,
                            MonthOfBirth = "November",
                            Plan = "A",
                            Premium = 84.5,
                            State = "AL"
                        },
                        new
                        {
                            PremiumRolID = 14,
                            Age = "18-65",
                            Carrier = "Asdf",
                            Id = 0,
                            MonthOfBirth = "*",
                            Plan = "B",
                            Premium = 100.0,
                            State = "WY"
                        },
                        new
                        {
                            PremiumRolID = 15,
                            Age = "18-65",
                            Carrier = "Asdf",
                            Id = 0,
                            MonthOfBirth = "*",
                            Plan = "B,C",
                            Premium = 100.8,
                            State = "AK"
                        },
                        new
                        {
                            PremiumRolID = 16,
                            Age = "18-65",
                            Carrier = "Asdf",
                            Id = 0,
                            MonthOfBirth = "*",
                            Plan = "A,C",
                            Premium = 89.989999999999995,
                            State = "*"
                        });
                });

            modelBuilder.Entity("PremiumCalculator.Domain.State", b =>
                {
                    b.Property<string>("StateId")
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<string>("StateName")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("StateId");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            StateId = "AL",
                            StateName = "AL - Alamaba"
                        },
                        new
                        {
                            StateId = "AK",
                            StateName = "AK - Arkansas"
                        },
                        new
                        {
                            StateId = "NJ",
                            StateName = "NJ - New Jersey"
                        },
                        new
                        {
                            StateId = "NY",
                            StateName = "NY - New York"
                        },
                        new
                        {
                            StateId = "WY",
                            StateName = "WY - Wyoming"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}