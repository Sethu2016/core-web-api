﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyApi.Data;

namespace MyApi.Data.Migrations
{
    [DbContext(typeof(Campcontext))]
    [Migration("20191128144424_InitialModel")]
    partial class InitialModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1");

            modelBuilder.Entity("MyApi.Core.Entities.Camp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Length")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Moniker")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Camps");
                });

            modelBuilder.Entity("MyApi.Core.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address3")
                        .HasColumnType("TEXT");

                    b.Property<string>("CityTown")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<int>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("StateProvince")
                        .HasColumnType("TEXT");

                    b.Property<string>("VenueName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("MyApi.Core.Entities.Speaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlogUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Company")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("GitHub")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Twitter")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("MyApi.Core.Entities.Talk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Abstract")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CampId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SpeakerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CampId");

                    b.HasIndex("SpeakerId");

                    b.ToTable("Talks");
                });

            modelBuilder.Entity("MyApi.Core.Entities.Camp", b =>
                {
                    b.HasOne("MyApi.Core.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("MyApi.Core.Entities.Talk", b =>
                {
                    b.HasOne("MyApi.Core.Entities.Camp", "Camp")
                        .WithMany("Talks")
                        .HasForeignKey("CampId");

                    b.HasOne("MyApi.Core.Entities.Speaker", "Speaker")
                        .WithMany()
                        .HasForeignKey("SpeakerId");
                });
#pragma warning restore 612, 618
        }
    }
}
