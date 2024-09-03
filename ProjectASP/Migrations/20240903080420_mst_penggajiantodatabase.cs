using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectASP.Migrations
{
    public partial class mst_penggajiantodatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mst_penggajian",
                schema: "dbo",
                columns: table => new
                {
                    GajiId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nominal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_penggajian", x => x.GajiId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mst_penggajian",
                schema: "dbo");
        }
    }
}
