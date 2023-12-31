﻿// <auto-generated />
using EFCoreOwnedEntitiesError;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreOwnedEntitiesError.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20230823133953_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreOwnedEntitiesError.Entities.Foo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Foos");
                });

            modelBuilder.Entity("EFCoreOwnedEntitiesError.Entities.Foo", b =>
                {
                    b.OwnsOne("EFCoreOwnedEntitiesError.Entities.Statistics", "BarStatistics", b1 =>
                        {
                            b1.Property<int>("FooId")
                                .HasColumnType("int");

                            b1.Property<double>("Median")
                                .HasColumnType("float");

                            b1.HasKey("FooId");

                            b1.ToTable("Foos");

                            b1.WithOwner()
                                .HasForeignKey("FooId");

                            b1.OwnsOne("EFCoreOwnedEntitiesError.Entities.PercentileRange", "Percentile10En90", b2 =>
                                {
                                    b2.Property<int>("StatisticsFooId")
                                        .HasColumnType("int");

                                    b2.Property<double>("High")
                                        .HasColumnType("float");

                                    b2.Property<double>("Low")
                                        .HasColumnType("float");

                                    b2.HasKey("StatisticsFooId");

                                    b2.ToTable("Foos");

                                    b2.WithOwner()
                                        .HasForeignKey("StatisticsFooId");
                                });

                            b1.OwnsOne("EFCoreOwnedEntitiesError.Entities.PercentileRange", "Percentile25En75", b2 =>
                                {
                                    b2.Property<int>("StatisticsFooId")
                                        .HasColumnType("int");

                                    b2.Property<double>("High")
                                        .HasColumnType("float");

                                    b2.Property<double>("Low")
                                        .HasColumnType("float");

                                    b2.HasKey("StatisticsFooId");

                                    b2.ToTable("Foos");

                                    b2.WithOwner()
                                        .HasForeignKey("StatisticsFooId");
                                });

                            b1.Navigation("Percentile10En90")
                                .IsRequired();

                            b1.Navigation("Percentile25En75")
                                .IsRequired();
                        });

                    b.OwnsOne("EFCoreOwnedEntitiesError.Entities.Statistics", "FooStatistics", b1 =>
                        {
                            b1.Property<int>("FooId")
                                .HasColumnType("int");

                            b1.Property<double>("Median")
                                .HasColumnType("float");

                            b1.HasKey("FooId");

                            b1.ToTable("Foos");

                            b1.WithOwner()
                                .HasForeignKey("FooId");

                            b1.OwnsOne("EFCoreOwnedEntitiesError.Entities.PercentileRange", "Percentile10En90", b2 =>
                                {
                                    b2.Property<int>("StatisticsFooId")
                                        .HasColumnType("int");

                                    b2.Property<double>("High")
                                        .HasColumnType("float");

                                    b2.Property<double>("Low")
                                        .HasColumnType("float");

                                    b2.HasKey("StatisticsFooId");

                                    b2.ToTable("Foos");

                                    b2.WithOwner()
                                        .HasForeignKey("StatisticsFooId");
                                });

                            b1.OwnsOne("EFCoreOwnedEntitiesError.Entities.PercentileRange", "Percentile25En75", b2 =>
                                {
                                    b2.Property<int>("StatisticsFooId")
                                        .HasColumnType("int");

                                    b2.Property<double>("High")
                                        .HasColumnType("float");

                                    b2.Property<double>("Low")
                                        .HasColumnType("float");

                                    b2.HasKey("StatisticsFooId");

                                    b2.ToTable("Foos");

                                    b2.WithOwner()
                                        .HasForeignKey("StatisticsFooId");
                                });

                            b1.Navigation("Percentile10En90")
                                .IsRequired();

                            b1.Navigation("Percentile25En75")
                                .IsRequired();
                        });

                    b.Navigation("BarStatistics")
                        .IsRequired();

                    b.Navigation("FooStatistics")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
