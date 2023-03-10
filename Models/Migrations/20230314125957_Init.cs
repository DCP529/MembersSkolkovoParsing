using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "EngineeringAndPrototypingCenters");

            migrationBuilder.CreateTable(
                name: "Description",
                schema: "EngineeringAndPrototypingCenters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ru = table.Column<string>(type: "text", nullable: true),
                    en = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FullName",
                schema: "EngineeringAndPrototypingCenters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ru = table.Column<string>(type: "text", nullable: true),
                    en = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullName", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ShortDescription",
                schema: "EngineeringAndPrototypingCenters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ru = table.Column<string>(type: "text", nullable: true),
                    en = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShortDescription", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                schema: "EngineeringAndPrototypingCenters",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    orn = table.Column<int>(type: "integer", nullable: true),
                    inn = table.Column<string>(type: "text", nullable: true),
                    kpp = table.Column<string>(type: "text", nullable: true),
                    ogrn = table.Column<string>(type: "text", nullable: true),
                    nameid = table.Column<int>(type: "integer", nullable: true),
                    full_nameid = table.Column<int>(type: "integer", nullable: true),
                    descriptionid = table.Column<int>(type: "integer", nullable: true),
                    short_descriptionid = table.Column<int>(type: "integer", nullable: true),
                    foundation_year = table.Column<int>(type: "integer", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true),
                    status_add_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    status_del_date = table.Column<string>(type: "text", nullable: true),
                    sk_member = table.Column<bool>(type: "boolean", nullable: true),
                    sk_tp_member = table.Column<bool>(type: "boolean", nullable: true),
                    sk_tech_member = table.Column<bool>(type: "boolean", nullable: true),
                    can_sign_nda = table.Column<bool>(type: "boolean", nullable: true),
                    is_validated = table.Column<bool>(type: "boolean", nullable: true),
                    need_investment = table.Column<bool>(type: "boolean", nullable: true),
                    need_services = table.Column<bool>(type: "boolean", nullable: true),
                    stage = table.Column<string>(type: "text", nullable: true),
                    business_model = table.Column<string>(type: "text", nullable: true),
                    investment_size = table.Column<string>(type: "text", nullable: true),
                    staff_number = table.Column<string>(type: "text", nullable: true),
                    staff_number_val = table.Column<string>(type: "text", nullable: true),
                    interests = table.Column<string>(type: "text", nullable: true),
                    external_financing_value = table.Column<double>(type: "double precision", nullable: true),
                    international_revenue = table.Column<string>(type: "text", nullable: true),
                    revenue = table.Column<long>(type: "bigint", nullable: true),
                    average_number_of_employees = table.Column<double>(type: "double precision", nullable: true),
                    investment_round = table.Column<string>(type: "text", nullable: true),
                    approved_patents_count = table.Column<string>(type: "text", nullable: true),
                    has_plan = table.Column<bool>(type: "boolean", nullable: true),
                    cluster = table.Column<int>(type: "integer", nullable: true),
                    company_type = table.Column<string>(type: "text", nullable: true),
                    logo = table.Column<string>(type: "text", nullable: true),
                    authorized_capital = table.Column<double>(type: "double precision", nullable: true),
                    organisation_status = table.Column<string>(type: "text", nullable: true),
                    founders = table.Column<List<string>>(type: "text[]", nullable: true),
                    has_large_contracts = table.Column<bool>(type: "boolean", nullable: true),
                    international_markets = table.Column<bool>(type: "boolean", nullable: true),
                    msp_type = table.Column<string>(type: "text", nullable: true),
                    similar_companies = table.Column<List<string>>(type: "text[]", nullable: true),
                    is_fast_growing = table.Column<bool>(type: "boolean", nullable: true),
                    accredited_it = table.Column<bool>(type: "boolean", nullable: true),
                    domestic_software = table.Column<bool>(type: "boolean", nullable: true),
                    know_how_counts = table.Column<string>(type: "text", nullable: true),
                    has_knowhow = table.Column<bool>(type: "boolean", nullable: true),
                    has_ip = table.Column<bool>(type: "boolean", nullable: true),
                    tags = table.Column<List<string>>(type: "text[]", nullable: true),
                    rank = table.Column<string>(type: "text", nullable: true),
                    company_has_patents = table.Column<bool>(type: "boolean", nullable: true),
                    company_has_competition_win = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.id);
                    table.ForeignKey(
                        name: "FK_Company_Description_descriptionid",
                        column: x => x.descriptionid,
                        principalSchema: "EngineeringAndPrototypingCenters",
                        principalTable: "Description",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Company_FullName_full_nameid",
                        column: x => x.full_nameid,
                        principalSchema: "EngineeringAndPrototypingCenters",
                        principalTable: "FullName",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Company_ShortDescription_short_descriptionid",
                        column: x => x.short_descriptionid,
                        principalSchema: "EngineeringAndPrototypingCenters",
                        principalTable: "ShortDescription",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "InvestmentFund",
                schema: "EngineeringAndPrototypingCenters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    started_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ended_at = table.Column<string>(type: "text", nullable: true),
                    entity_status = table.Column<string>(type: "text", nullable: true),
                    Companyid = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestmentFund", x => x.id);
                    table.ForeignKey(
                        name: "FK_InvestmentFund_Company_Companyid",
                        column: x => x.Companyid,
                        principalSchema: "EngineeringAndPrototypingCenters",
                        principalTable: "Company",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "KeyIndicator",
                schema: "EngineeringAndPrototypingCenters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    code = table.Column<string>(type: "text", nullable: true),
                    value = table.Column<string>(type: "text", nullable: true),
                    year = table.Column<int>(type: "integer", nullable: true),
                    is_validated = table.Column<bool>(type: "boolean", nullable: true),
                    Companyid = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyIndicator", x => x.id);
                    table.ForeignKey(
                        name: "FK_KeyIndicator_Company_Companyid",
                        column: x => x.Companyid,
                        principalSchema: "EngineeringAndPrototypingCenters",
                        principalTable: "Company",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Name",
                schema: "EngineeringAndPrototypingCenters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ru = table.Column<string>(type: "text", nullable: true),
                    en = table.Column<string>(type: "text", nullable: true),
                    Companyid = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Name", x => x.id);
                    table.ForeignKey(
                        name: "FK_Name_Company_Companyid",
                        column: x => x.Companyid,
                        principalSchema: "EngineeringAndPrototypingCenters",
                        principalTable: "Company",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Okved",
                schema: "EngineeringAndPrototypingCenters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    unidata_id = table.Column<string>(type: "text", nullable: true),
                    is_main = table.Column<bool>(type: "boolean", nullable: true),
                    type = table.Column<string>(type: "text", nullable: true),
                    code = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    Companyid = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Okved", x => x.id);
                    table.ForeignKey(
                        name: "FK_Okved_Company_Companyid",
                        column: x => x.Companyid,
                        principalSchema: "EngineeringAndPrototypingCenters",
                        principalTable: "Company",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "TechPark",
                schema: "EngineeringAndPrototypingCenters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    started_at = table.Column<string>(type: "text", nullable: true),
                    ended_at = table.Column<string>(type: "text", nullable: true),
                    entity_status = table.Column<string>(type: "text", nullable: true),
                    Companyid = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechPark", x => x.id);
                    table.ForeignKey(
                        name: "FK_TechPark_Company_Companyid",
                        column: x => x.Companyid,
                        principalSchema: "EngineeringAndPrototypingCenters",
                        principalTable: "Company",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "grants_values_amount_per_fund",
                schema: "EngineeringAndPrototypingCenters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fund_nameid = table.Column<int>(type: "integer", nullable: true),
                    amount = table.Column<string>(type: "text", nullable: true),
                    Companyid = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grants_values_amount_per_fund", x => x.id);
                    table.ForeignKey(
                        name: "FK_grants_values_amount_per_fund_Company_Companyid",
                        column: x => x.Companyid,
                        principalSchema: "EngineeringAndPrototypingCenters",
                        principalTable: "Company",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_grants_values_amount_per_fund_Name_fund_nameid",
                        column: x => x.fund_nameid,
                        principalSchema: "EngineeringAndPrototypingCenters",
                        principalTable: "Name",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Project",
                schema: "EngineeringAndPrototypingCenters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameid = table.Column<int>(type: "integer", nullable: true),
                    Companyid = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.id);
                    table.ForeignKey(
                        name: "FK_Project_Company_Companyid",
                        column: x => x.Companyid,
                        principalSchema: "EngineeringAndPrototypingCenters",
                        principalTable: "Company",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Project_Name_nameid",
                        column: x => x.nameid,
                        principalSchema: "EngineeringAndPrototypingCenters",
                        principalTable: "Name",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_descriptionid",
                schema: "EngineeringAndPrototypingCenters",
                table: "Company",
                column: "descriptionid");

            migrationBuilder.CreateIndex(
                name: "IX_Company_full_nameid",
                schema: "EngineeringAndPrototypingCenters",
                table: "Company",
                column: "full_nameid");

            migrationBuilder.CreateIndex(
                name: "IX_Company_nameid",
                schema: "EngineeringAndPrototypingCenters",
                table: "Company",
                column: "nameid");

            migrationBuilder.CreateIndex(
                name: "IX_Company_short_descriptionid",
                schema: "EngineeringAndPrototypingCenters",
                table: "Company",
                column: "short_descriptionid");

            migrationBuilder.CreateIndex(
                name: "IX_grants_values_amount_per_fund_Companyid",
                schema: "EngineeringAndPrototypingCenters",
                table: "grants_values_amount_per_fund",
                column: "Companyid");

            migrationBuilder.CreateIndex(
                name: "IX_grants_values_amount_per_fund_fund_nameid",
                schema: "EngineeringAndPrototypingCenters",
                table: "grants_values_amount_per_fund",
                column: "fund_nameid");

            migrationBuilder.CreateIndex(
                name: "IX_InvestmentFund_Companyid",
                schema: "EngineeringAndPrototypingCenters",
                table: "InvestmentFund",
                column: "Companyid");

            migrationBuilder.CreateIndex(
                name: "IX_KeyIndicator_Companyid",
                schema: "EngineeringAndPrototypingCenters",
                table: "KeyIndicator",
                column: "Companyid");

            migrationBuilder.CreateIndex(
                name: "IX_Name_Companyid",
                schema: "EngineeringAndPrototypingCenters",
                table: "Name",
                column: "Companyid");

            migrationBuilder.CreateIndex(
                name: "IX_Okved_Companyid",
                schema: "EngineeringAndPrototypingCenters",
                table: "Okved",
                column: "Companyid");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Companyid",
                schema: "EngineeringAndPrototypingCenters",
                table: "Project",
                column: "Companyid");

            migrationBuilder.CreateIndex(
                name: "IX_Project_nameid",
                schema: "EngineeringAndPrototypingCenters",
                table: "Project",
                column: "nameid");

            migrationBuilder.CreateIndex(
                name: "IX_TechPark_Companyid",
                schema: "EngineeringAndPrototypingCenters",
                table: "TechPark",
                column: "Companyid");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Name_nameid",
                schema: "EngineeringAndPrototypingCenters",
                table: "Company",
                column: "nameid",
                principalSchema: "EngineeringAndPrototypingCenters",
                principalTable: "Name",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Description_descriptionid",
                schema: "EngineeringAndPrototypingCenters",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_FullName_full_nameid",
                schema: "EngineeringAndPrototypingCenters",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Name_nameid",
                schema: "EngineeringAndPrototypingCenters",
                table: "Company");

            migrationBuilder.DropTable(
                name: "grants_values_amount_per_fund",
                schema: "EngineeringAndPrototypingCenters");

            migrationBuilder.DropTable(
                name: "InvestmentFund",
                schema: "EngineeringAndPrototypingCenters");

            migrationBuilder.DropTable(
                name: "KeyIndicator",
                schema: "EngineeringAndPrototypingCenters");

            migrationBuilder.DropTable(
                name: "Okved",
                schema: "EngineeringAndPrototypingCenters");

            migrationBuilder.DropTable(
                name: "Project",
                schema: "EngineeringAndPrototypingCenters");

            migrationBuilder.DropTable(
                name: "TechPark",
                schema: "EngineeringAndPrototypingCenters");

            migrationBuilder.DropTable(
                name: "Description",
                schema: "EngineeringAndPrototypingCenters");

            migrationBuilder.DropTable(
                name: "FullName",
                schema: "EngineeringAndPrototypingCenters");

            migrationBuilder.DropTable(
                name: "Name",
                schema: "EngineeringAndPrototypingCenters");

            migrationBuilder.DropTable(
                name: "Company",
                schema: "EngineeringAndPrototypingCenters");

            migrationBuilder.DropTable(
                name: "ShortDescription",
                schema: "EngineeringAndPrototypingCenters");
        }
    }
}
