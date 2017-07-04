using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Moto.Api.Migrations
{
    public partial class MotocykleInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motocykle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Chlodzenie = table.Column<string>(nullable: true),
                    Marka = table.Column<string>(maxLength: 50, nullable: false),
                    Masa = table.Column<double>(nullable: false),
                    Model = table.Column<string>(maxLength: 50, nullable: false),
                    PojemnoscSkokowa = table.Column<double>(nullable: false),
                    PojemnoscZbiornikaPaliwa = table.Column<double>(nullable: false),
                    PredkoscMaksymalna = table.Column<int>(nullable: false),
                    Typ = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motocykle", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motocykle");
        }
    }
}
