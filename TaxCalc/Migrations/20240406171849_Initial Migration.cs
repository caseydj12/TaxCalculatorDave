using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaxCalc.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaxIds",
                columns: table => new
                {
                    TaxId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GrossAnnualSalary = table.Column<double>(type: "float", nullable: false),
                    GrossMonthlySalary = table.Column<double>(type: "float", nullable: false),
                    NetAnnualSalary = table.Column<double>(type: "float", nullable: false),
                    NetMonthlySalary = table.Column<double>(type: "float", nullable: false),
                    AnnualTaxPaid = table.Column<double>(type: "float", nullable: false),
                    MonthlyTaxPaid = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxIds", x => x.TaxId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaxIds");
        }
    }
}
