﻿// <auto-generated />
using System;
using DntHukuk.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DntHukuk.Web.Migrations
{
    [DbContext(typeof(AuthDbContext))]
    [Migration("20200527115345_Dosyalar")]
    partial class Dosyalar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DntHukuk.Web.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("userEmail")
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("userFirstName")
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("userImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userLastName")
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("DntHukuk.Web.Models.CezaMahkemesiMuvekkilKonumu", b =>
                {
                    b.Property<int>("cezaHukukuMuvekkilKonumuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cezaHukukuMuvekkilKonumuTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("cezaHukukuMuvekkilKonumuId");

                    b.ToTable("CezaHukukuMuvekkilKonumu");
                });

            modelBuilder.Entity("DntHukuk.Web.Models.DosyaDurumu", b =>
                {
                    b.Property<int>("dosyaDurumuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dosyaDurumuTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("dosyaDurumuId");

                    b.ToTable("DosyaDurumu");
                });

            modelBuilder.Entity("DntHukuk.Web.Models.Dosyalar", b =>
                {
                    b.Property<int>("DosyaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DosyaAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DosyaBaslamaTarihi")
                        .HasColumnType("DateTime");

                    b.Property<DateTime>("DosyaBitisTarihi")
                        .HasColumnType("DateTime");

                    b.Property<int>("DosyaDurumuId")
                        .HasColumnType("int");

                    b.Property<string>("DosyaIlce")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DosyaKarsiTarafBilgi")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("DosyaKarsiTarafEvraklariPath")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("DosyaKarsiTarafId")
                        .HasColumnType("int");

                    b.Property<string>("DosyaKonu")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("DosyaMahkemeAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DosyaMerciEvraklari")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("DosyaMuvekkilEvraklariPath")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("DosyaSehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DosyaSiraNo")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DosyaSonDurum")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<int>("DosyaTuru")
                        .HasColumnType("int");

                    b.Property<Guid>("MuvekkilId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MuvekkilKonumuId")
                        .HasColumnType("int");

                    b.Property<Guid>("SorumluAvukatId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DosyaId");

                    b.ToTable("Dosyalar");
                });

            modelBuilder.Entity("DntHukuk.Web.Models.HukukMahkemesiMuvekkilKonumu", b =>
                {
                    b.Property<int>("hukukMahkemesiMuvekkilKonumuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("hukukMahkemesiMuvekkilKonumuTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("hukukMahkemesiMuvekkilKonumuId");

                    b.ToTable("HukukMahkemesiMuvekkilKonumu");
                });

            modelBuilder.Entity("DntHukuk.Web.Models.IcraHukukuMuvekkilKonumu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IcraHukukMuvekkilKonumu")
                        .IsRequired()
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("Id");

                    b.ToTable("IcraHukukuMuvekkilKonumu");
                });

            modelBuilder.Entity("DntHukuk.Web.Models.IdareMahkemesiMahkemeTuru", b =>
                {
                    b.Property<int>("idareMahkemesiMahkemeTuruId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("idareMahkemesiMahkemeTuruu")
                        .IsRequired()
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("idareMahkemesiMahkemeTuruId");

                    b.ToTable("IdareMahkemesiMahkemeTuru");
                });

            modelBuilder.Entity("DntHukuk.Web.Models.IdareMahkemesiMuvekkilKonumu", b =>
                {
                    b.Property<int>("idareMahkemesiMuvekkilKonumuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("idareMahkemesiMuvekkilKonumuTuru")
                        .IsRequired()
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("idareMahkemesiMuvekkilKonumuId");

                    b.ToTable("IdareMahkemesiMuvekkilKonumu");
                });

            modelBuilder.Entity("DntHukuk.Web.Models.Muvekkil", b =>
                {
                    b.Property<Guid>("muvekkilId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("muvekkilAciklama")
                        .HasColumnType("nvarchar(155)");

                    b.Property<string>("muvekkilAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("muvekkilAdres")
                        .HasColumnType("nvarchar(155)");

                    b.Property<string>("muvekkilEmaik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("muvekkilEvrakPath")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<Guid>("muvekkilSorumluAvukat")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("muvekkilSoyAdi")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("muvekkilTc")
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("muvekkilTelefon")
                        .HasColumnType("nvarchar(21)");

                    b.Property<int>("muvekkilTuruId")
                        .HasColumnType("int");

                    b.Property<DateTime>("muvekkilUyelikTarihi")
                        .HasColumnType("DateTime");

                    b.Property<string>("muvekkilVergiDairesi")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("muvekkilVergiNo")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("muvekkilYetkiliIsim")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("muvekkilId");

                    b.ToTable("Muvekkil");
                });

            modelBuilder.Entity("DntHukuk.Web.Models.MuvekkilTurleri", b =>
                {
                    b.Property<int>("muvekkilTuruId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("muvekkilTuruAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("muvekkilTuruId");

                    b.ToTable("muvekkilTuru");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DntHukuk.Web.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DntHukuk.Web.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DntHukuk.Web.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DntHukuk.Web.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
