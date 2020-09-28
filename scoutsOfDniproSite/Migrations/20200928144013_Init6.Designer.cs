﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using scoutsOfDniproSite;

namespace scoutsOfDniproSite.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200928144013_Init6")]
    partial class Init6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("scoutsOfDniproSite.Models.DocsLevel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("docsLevels");
                });

            modelBuilder.Entity("scoutsOfDniproSite.Models.DocsLevelPost", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("DocsLevelId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Text")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("WriterId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("docsLevelPosts");
                });

            modelBuilder.Entity("scoutsOfDniproSite.Models.Events", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Date")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Text")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("events");
                });

            modelBuilder.Entity("scoutsOfDniproSite.Models.Post", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("ShortText")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Text")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("WriterId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("scoutsOfDniproSite.Models.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("CanAcceptUsers")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("CanEditUsers")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("CanManageEvent")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("CanSetBadge")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("CanSetScoutMinimum")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("CanSetSkill")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("scoutsOfDniproSite.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("Class")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ForestName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("HomeAdress")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("JWTToken")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastEvent")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastSignIn")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Passport")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("School")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("SiteRoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("scoutsOfDniproSite.Models.requestUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ForestName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("usersRequests");
                });

            modelBuilder.Entity("scoutsOfDniproSite.Models.userScoutMinimum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("iGood1")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iGood2")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iGood3")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iGood4")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iGood5")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iGood6")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iGood7")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iGood8")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iGood9")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iScout1")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iScout10")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iScout11")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iScout12")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iScout13")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iScout2")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iScout3")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iScout4")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iScout5")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iScout6")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iScout7")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iScout8")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("iScout9")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("lifeInSociety1")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("lifeInSociety2")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("lifeInSociety3")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("lifeInSociety4")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("lifeInSociety5")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("lifeInSociety6")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("lifeInSociety7")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("lifeInSociety8")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("natureLife1")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("natureLife10")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("natureLife11")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("natureLife12")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("natureLife13")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("natureLife14")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("natureLife15")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("natureLife16")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("natureLife2")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("natureLife3")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("natureLife4")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("natureLife5")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("natureLife6")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("natureLife7")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("natureLife8")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("natureLife9")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("userScoutMinimums");
                });
#pragma warning restore 612, 618
        }
    }
}
