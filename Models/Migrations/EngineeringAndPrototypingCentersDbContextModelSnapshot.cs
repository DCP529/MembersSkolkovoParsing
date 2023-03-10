﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.ModelsDb;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Models.Migrations
{
    [DbContext(typeof(EngineeringAndPrototypingCentersDbContext))]
    partial class EngineeringAndPrototypingCentersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("EngineeringAndPrototypingCenters")
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Models.ModelsDb.Company", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<bool?>("accredited_it")
                        .HasColumnType("boolean")
                        .HasColumnName("accredited_it");

                    b.Property<string>("approved_patents_count")
                        .HasColumnType("text")
                        .HasColumnName("approved_patents_count");

                    b.Property<double?>("authorized_capital")
                        .HasColumnType("double precision")
                        .HasColumnName("authorized_capital");

                    b.Property<double?>("average_number_of_employees")
                        .HasColumnType("double precision")
                        .HasColumnName("average_number_of_employees");

                    b.Property<string>("business_model")
                        .HasColumnType("text")
                        .HasColumnName("business_model");

                    b.Property<bool?>("can_sign_nda")
                        .HasColumnType("boolean")
                        .HasColumnName("can_sign_nda");

                    b.Property<int?>("cluster")
                        .HasColumnType("integer")
                        .HasColumnName("cluster");

                    b.Property<bool?>("company_has_competition_win")
                        .HasColumnType("boolean")
                        .HasColumnName("company_has_competition_win");

                    b.Property<bool?>("company_has_patents")
                        .HasColumnType("boolean")
                        .HasColumnName("company_has_patents");

                    b.Property<string>("company_type")
                        .HasColumnType("text")
                        .HasColumnName("company_type");

                    b.Property<int?>("descriptionid")
                        .HasColumnType("integer");

                    b.Property<bool?>("domestic_software")
                        .HasColumnType("boolean")
                        .HasColumnName("domestic_software");

                    b.Property<double?>("external_financing_value")
                        .HasColumnType("double precision")
                        .HasColumnName("external_financing_value");

                    b.Property<int?>("foundation_year")
                        .HasColumnType("integer")
                        .HasColumnName("foundation_year");

                    b.Property<List<string>>("founders")
                        .HasColumnType("text[]")
                        .HasColumnName("founders");

                    b.Property<int?>("full_nameid")
                        .HasColumnType("integer");

                    b.Property<bool?>("has_ip")
                        .HasColumnType("boolean")
                        .HasColumnName("has_ip");

                    b.Property<bool?>("has_knowhow")
                        .HasColumnType("boolean")
                        .HasColumnName("has_knowhow");

                    b.Property<bool?>("has_large_contracts")
                        .HasColumnType("boolean")
                        .HasColumnName("has_large_contracts");

                    b.Property<bool?>("has_plan")
                        .HasColumnType("boolean")
                        .HasColumnName("has_plan");

                    b.Property<string>("inn")
                        .HasColumnType("text")
                        .HasColumnName("inn");

                    b.Property<string>("interests")
                        .HasColumnType("text")
                        .HasColumnName("interests");

                    b.Property<bool?>("international_markets")
                        .HasColumnType("boolean")
                        .HasColumnName("international_markets");

                    b.Property<string>("international_revenue")
                        .HasColumnType("text")
                        .HasColumnName("international_revenue");

                    b.Property<string>("investment_round")
                        .HasColumnType("text")
                        .HasColumnName("investment_round");

                    b.Property<string>("investment_size")
                        .HasColumnType("text")
                        .HasColumnName("investment_size");

                    b.Property<bool?>("is_fast_growing")
                        .HasColumnType("boolean")
                        .HasColumnName("is_fast_growing");

                    b.Property<bool?>("is_validated")
                        .HasColumnType("boolean")
                        .HasColumnName("is_validated");

                    b.Property<string>("know_how_counts")
                        .HasColumnType("text")
                        .HasColumnName("know_how_counts");

                    b.Property<string>("kpp")
                        .HasColumnType("text")
                        .HasColumnName("kpp");

                    b.Property<string>("logo")
                        .HasColumnType("text")
                        .HasColumnName("logo");

                    b.Property<string>("msp_type")
                        .HasColumnType("text")
                        .HasColumnName("msp_type");

                    b.Property<int?>("nameid")
                        .HasColumnType("integer");

                    b.Property<bool?>("need_investment")
                        .HasColumnType("boolean")
                        .HasColumnName("need_investment");

                    b.Property<bool?>("need_services")
                        .HasColumnType("boolean")
                        .HasColumnName("need_services");

                    b.Property<string>("ogrn")
                        .HasColumnType("text")
                        .HasColumnName("ogrn");

                    b.Property<string>("organisation_status")
                        .HasColumnType("text")
                        .HasColumnName("organisation_status");

                    b.Property<int?>("orn")
                        .HasColumnType("integer")
                        .HasColumnName("orn");

                    b.Property<string>("rank")
                        .HasColumnType("text")
                        .HasColumnName("rank");

                    b.Property<long?>("revenue")
                        .HasColumnType("bigint")
                        .HasColumnName("revenue");

                    b.Property<int?>("short_descriptionid")
                        .HasColumnType("integer");

                    b.Property<List<string>>("similar_companies")
                        .HasColumnType("text[]")
                        .HasColumnName("similar_companies");

                    b.Property<bool?>("sk_member")
                        .HasColumnType("boolean")
                        .HasColumnName("sk_member");

                    b.Property<bool?>("sk_tech_member")
                        .HasColumnType("boolean")
                        .HasColumnName("sk_tech_member");

                    b.Property<bool?>("sk_tp_member")
                        .HasColumnType("boolean")
                        .HasColumnName("sk_tp_member");

                    b.Property<string>("staff_number")
                        .HasColumnType("text")
                        .HasColumnName("staff_number");

                    b.Property<string>("staff_number_val")
                        .HasColumnType("text")
                        .HasColumnName("staff_number_val");

                    b.Property<string>("stage")
                        .HasColumnType("text")
                        .HasColumnName("stage");

                    b.Property<string>("status")
                        .HasColumnType("text")
                        .HasColumnName("status");

                    b.Property<DateTime?>("status_add_date")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("status_add_date");

                    b.Property<string>("status_del_date")
                        .HasColumnType("text")
                        .HasColumnName("status_del_date");

                    b.Property<List<string>>("tags")
                        .HasColumnType("text[]")
                        .HasColumnName("tags");

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

            modelBuilder.Entity("Models.ModelsDb.GrantsValuesAmountPerFund", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<Guid?>("Companyid")
                        .HasColumnType("uuid");

                    b.Property<string>("amount")
                        .HasColumnType("text")
                        .HasColumnName("amount");

                    b.Property<int?>("fund_nameid")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Companyid");

                    b.HasIndex("fund_nameid");

                    b.ToTable("grants_values_amount_per_fund", "EngineeringAndPrototypingCenters");
                });

            modelBuilder.Entity("Models.ModelsDb.InvestmentFund", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("id"));

                    b.Property<Guid?>("Companyid")
                        .HasColumnType("uuid");

                    b.Property<string>("ended_at")
                        .HasColumnType("text")
                        .HasColumnName("ended_at");

                    b.Property<string>("entity_status")
                        .HasColumnType("text")
                        .HasColumnName("entity_status");

                    b.Property<DateTime?>("started_at")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("started_at");

                    b.HasKey("id");

                    b.HasIndex("Companyid");

                    b.ToTable("InvestmentFund", "EngineeringAndPrototypingCenters");
                });

            modelBuilder.Entity("Models.ModelsDb.KeyIndicator", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<Guid?>("Companyid")
                        .HasColumnType("uuid");

                    b.Property<string>("code")
                        .HasColumnType("text")
                        .HasColumnName("code");

                    b.Property<bool?>("is_validated")
                        .HasColumnType("boolean")
                        .HasColumnName("is_validated");

                    b.Property<string>("value")
                        .HasColumnType("text")
                        .HasColumnName("value");

                    b.Property<int?>("year")
                        .HasColumnType("integer")
                        .HasColumnName("year");

                    b.HasKey("id");

                    b.HasIndex("Companyid");

                    b.ToTable("KeyIndicator", "EngineeringAndPrototypingCenters");
                });

            modelBuilder.Entity("Models.ModelsDb.Name", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("id"));

                    b.Property<Guid?>("Companyid")
                        .HasColumnType("uuid");

                    b.Property<string>("en")
                        .HasColumnType("text")
                        .HasColumnName("en");

                    b.Property<string>("ru")
                        .HasColumnType("text")
                        .HasColumnName("ru");

                    b.HasKey("id");

                    b.HasIndex("Companyid");

                    b.ToTable("Name", "EngineeringAndPrototypingCenters");
                });

            modelBuilder.Entity("Models.ModelsDb.Okved", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<Guid?>("Companyid")
                        .HasColumnType("uuid");

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

                    b.Property<Guid?>("Companyid")
                        .HasColumnType("uuid");

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

            modelBuilder.Entity("Models.ModelsDb.TechPark", b =>
                {
                    b.Property<int?>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("id"));

                    b.Property<Guid?>("Companyid")
                        .HasColumnType("uuid");

                    b.Property<string>("ended_at")
                        .HasColumnType("text")
                        .HasColumnName("ended_at");

                    b.Property<string>("entity_status")
                        .HasColumnType("text")
                        .HasColumnName("entity_status");

                    b.Property<string>("started_at")
                        .HasColumnType("text")
                        .HasColumnName("started_at");

                    b.HasKey("id");

                    b.HasIndex("Companyid");

                    b.ToTable("TechPark", "EngineeringAndPrototypingCenters");
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

            modelBuilder.Entity("Models.ModelsDb.GrantsValuesAmountPerFund", b =>
                {
                    b.HasOne("Models.ModelsDb.Company", null)
                        .WithMany("grants_values_amount_per_fund")
                        .HasForeignKey("Companyid");

                    b.HasOne("Models.ModelsDb.Name", "fund_name")
                        .WithMany()
                        .HasForeignKey("fund_nameid");

                    b.Navigation("fund_name");
                });

            modelBuilder.Entity("Models.ModelsDb.InvestmentFund", b =>
                {
                    b.HasOne("Models.ModelsDb.Company", null)
                        .WithMany("investment_funds")
                        .HasForeignKey("Companyid");
                });

            modelBuilder.Entity("Models.ModelsDb.KeyIndicator", b =>
                {
                    b.HasOne("Models.ModelsDb.Company", null)
                        .WithMany("key_indicators")
                        .HasForeignKey("Companyid");
                });

            modelBuilder.Entity("Models.ModelsDb.Name", b =>
                {
                    b.HasOne("Models.ModelsDb.Company", null)
                        .WithMany("cities_of_presence")
                        .HasForeignKey("Companyid");
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

            modelBuilder.Entity("Models.ModelsDb.TechPark", b =>
                {
                    b.HasOne("Models.ModelsDb.Company", null)
                        .WithMany("tech_parks")
                        .HasForeignKey("Companyid");
                });

            modelBuilder.Entity("Models.ModelsDb.Company", b =>
                {
                    b.Navigation("cities_of_presence");

                    b.Navigation("grants_values_amount_per_fund");

                    b.Navigation("investment_funds");

                    b.Navigation("key_indicators");

                    b.Navigation("okveds");

                    b.Navigation("projects");

                    b.Navigation("tech_parks");
                });
#pragma warning restore 612, 618
        }
    }
}
