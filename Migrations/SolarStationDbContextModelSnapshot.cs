﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SolarStationServer.DataAccess;

namespace SolarStationServer.Migrations
{
    [DbContext(typeof(SolarStationDbContext))]
    partial class SolarStationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SolarStationServer.DataAccess.Entities.ReportEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ArduinoVoltage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BatteryVoltage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("GsmErrors")
                        .HasColumnType("int");

                    b.Property<int>("GsmSignalLevel")
                        .HasColumnType("int");

                    b.Property<decimal>("GsmVoltage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Humidity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PowerMode")
                        .HasColumnType("int");

                    b.Property<int>("RaindropLevel")
                        .HasColumnType("int");

                    b.Property<long>("RestartsCount")
                        .HasColumnType("bigint");

                    b.Property<int?>("SimMoneyBalance")
                        .HasColumnType("int");

                    b.Property<int>("SoilMoistureLevel")
                        .HasColumnType("int");

                    b.Property<decimal>("SolarCurrent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SolarVoltage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Temperature")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("Timestamp")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("SolarStationServer.DataAccess.Entities.SettingEntity", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("Settings");
                });
#pragma warning restore 612, 618
        }
    }
}
