﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.ModelsDb;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Models.Migrations
{
    [DbContext(typeof(EngineeringAndPrototypingCentersDbContext))]
    [Migration("20230314142406_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("EngineeringAndPrototypingCenters")
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Models.ModelsDb.Company", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<double?>("average_number_of_employees")
                        .HasColumnType("double precision")
                        .HasColumnName("average_number_of_employees");

                    b.Property<string>("company_type")
                        .HasColumnType("text")
                        .HasColumnName("company_type");

                    b.Property<int?>("descriptionid")
                        .HasColumnType("integer");

                    b.Property<int?>("foundation_year")
                        .HasColumnType("integer")
                        .HasColumnName("foundation_year");

                    b.Property<List<string>>("founders")
                        .HasColumnType("text[]")
                        .HasColumnName("founders");

                    b.Property<int?>("full_nameid")
                        .HasColumnType("integer");

                    b.Property<int?>("nameid")
                        .HasColumnType("integer");

                    b.Property<long?>("revenue")
                        .HasColumnType("bigint")
                        .HasColumnName("revenue");

                    b.Property<int?>("short_descriptionid")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("descriptionid");

                    b.HasIndex("full_nameid");

                    b.HasIndex("nameid");

                    b.HasIndex("short_descriptionid");

                    b.ToTable("Company", "EngineeringAndPrototypingCenters");
                });

            modelBuilder.Entity("Models.ModelsDb.Description", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("en")
                        .HasColumnType("text")
                        .HasColumnName("en");

                    b.Property<string>("ru")
                        .HasColumnType("text")
                        .HasColumnName("ru");

                    b.HasKey("id");

                    b.ToTable("Description", "EngineeringAndPrototypingCenters");
                });

            modelBuilder.Entity("Models.ModelsDb.FullName", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("en")
                        .HasColumnType("text")
                        .HasColumnName("en");

                    b.Property<string>("ru")
                        .HasColumnType("text")
                        .HasColumnName("ru");

                    b.HasKey("id");

                    b.ToTable("FullName", "EngineeringAndPrototypingCenters");
                });

            modelBuilder.Entity("Models.ModelsDb.Name", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("id"));

                    b.Property<string>("en")
                        .HasColumnType("text")
                        .HasColumnName("en");

                    b.Property<string>("ru")
                        .HasColumnType("text")
                        .HasColumnName("ru");

                    b.HasKey("id");

                    b.ToTable("Name", "EngineeringAndPrototypingCenters");
                });

            modelBuilder.Entity("Models.ModelsDb.Okved", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int?>("Companyid")
                        .HasColumnType("integer");

                    b.Property<string>("code")
                        .HasColumnType("text")
                        .HasColumnName("code");

                    b.Property<bool?>("is_main")
                        .HasColumnType("boolean")
                        .HasColumnName("is_main");

                    b.Property<string>("name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("type")
                        .HasColumnType("text")
                        .HasColumnName("type");

                    b.Property<string>("unidata_id")
                        .HasColumnType("text")
                        .HasColumnName("unidata_id");

                    b.HasKey("id");

                    b.HasIndex("Companyid");

                    b.ToTable("Okved", "EngineeringAndPrototypingCenters");
                });

            modelBuilder.Entity("Models.ModelsDb.Project", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("id"));

                    b.Property<int?>("Companyid")
                        .HasColumnType("integer");

                    b.Property<int?>("nameid")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("Companyid");

                    b.HasIndex("nameid");

                    b.ToTable("Project", "EngineeringAndPrototypingCenters");
                });

            modelBuilder.Entity("Models.ModelsDb.ShortDescription", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("en")
                        .HasColumnType("text")
                        .HasColumnName("en");

                    b.Property<string>("ru")
                        .HasColumnType("text")
                        .HasColumnName("ru");

                    b.HasKey("id");

                    b.ToTable("ShortDescription", "EngineeringAndPrototypingCenters");
                });

            modelBuilder.Entity("Models.ModelsDb.Company", b =>
                {
                    b.HasOne("Models.ModelsDb.Description", "description")
                        .WithMany()
                        .HasForeignKey("descriptionid");

                    b.HasOne("Models.ModelsDb.FullName", "full_name")
                        .WithMany()
                        .HasForeignKey("full_nameid");

                    b.HasOne("Models.ModelsDb.Name", "name")
                        .WithMany()
                        .HasForeignKey("nameid");

                    b.HasOne("Models.ModelsDb.ShortDescription", "short_description")
                        .WithMany()
                        .HasForeignKey("short_descriptionid");

                    b.Navigation("description");

                    b.Navigation("full_name");

                    b.Navigation("name");

                    b.Navigation("short_description");
                });

            modelBuilder.Entity("Models.ModelsDb.Okved", b =>
                {
                    b.HasOne("Models.ModelsDb.Company", null)
                        .WithMany("okveds")
                        .HasForeignKey("Companyid");
                });

            modelBuilder.Entity("Models.ModelsDb.Project", b =>
                {
                    b.HasOne("Models.ModelsDb.Company", null)
                        .WithMany("projects")
                        .HasForeignKey("Companyid");

                    b.HasOne("Models.ModelsDb.Name", "name")
                        .WithMany()
                        .HasForeignKey("nameid");

                    b.Navigation("name");
                });

            modelBuilder.Entity("Models.ModelsDb.Company", b =>
                {
                    b.Navigation("okveds");

                    b.Navigation("projects");
                });
#pragma warning restore 612, 618
        }
    }
}
