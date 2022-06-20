﻿// <auto-generated />
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(Izpit3Context))]
    [Migration("20220609185341_Mig")]
    partial class Mig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BusinessLayer.Company", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEOID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CEOID");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("BusinessLayer.App", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ReleaseDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ReleasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.ToTable("Apps");
                });

            modelBuilder.Entity("BusinessLayer.Person", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("People");
                });

            modelBuilder.Entity("BusinessLayer.Company", b =>
                {
                    b.HasOne("BusinessLayer.Person", "CEO")
                        .WithMany()
                        .HasForeignKey("CEOID");

                    b.Navigation("CEO");
                });

            modelBuilder.Entity("BusinessLayer.App", b =>
                {
                    b.HasOne("BusinessLayer.Person", null)
                        .WithMany("FavouriteApps")
                        .HasForeignKey("PersonID");
                });

            modelBuilder.Entity("BusinessLayer.Person", b =>
                {
                    b.Navigation("FavouriteApps");
                });
#pragma warning restore 612, 618
        }
    }
}
