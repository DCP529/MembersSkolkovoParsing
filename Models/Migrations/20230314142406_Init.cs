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
                name: "Name",
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
                    table.PrimaryKey("PK_Name", x => x.id);
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
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameid = table.Column<int>(type: "integer", nullable: true),
                    full_nameid = table.Column<int>(type: "integer", nullable: true),
                    descriptionid = table.Column<int>(type: "integer", nullable: true),
                    short_descriptionid = table.Column<int>(type: "integer", nullable: true),
                    foundation_year = table.Column<int>(type: "integer", nullable: true),
                    revenue = table.Column<long>(type: "bigint", nullable: true),
                    average_number_of_employees = table.Column<double>(type: "double precision", nullable: true),
                    company_type = table.Column<string>(type: "text", nullable: true),
                    founders = table.Column<List<string>>(type: "text[]", nullable: true)
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
                        name: "FK_Company_Name_nameid",
                        column: x => x.nameid,
                        principalSchema: "EngineeringAndPrototypingCenters",
                        principalTable: "Name",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Company_ShortDescription_short_descriptionid",
                        column: x => x.short_descriptionid,
                        principalSchema: "EngineeringAndPrototypingCenters",
                        principalTable: "ShortDescription",
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
                    Companyid = table.Column<int>(type: "integer", nullable: true)
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
                name: "Project",
                schema: "EngineeringAndPrototypingCenters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nameid = table.Column<int>(type: "integer", nullable: true),
                    Companyid = table.Column<int>(type: "integer", nullable: true)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Okved",
                schema: "EngineeringAndPrototypingCenters");

            migrationBuilder.DropTable(
                name: "Project",
                schema: "EngineeringAndPrototypingCenters");

            migrationBuilder.DropTable(
                name: "Company",
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
                name: "ShortDescription",
                schema: "EngineeringAndPrototypingCenters");
        }
    }
}
