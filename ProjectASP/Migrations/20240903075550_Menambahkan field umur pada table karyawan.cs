using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectASP.Migrations
{
    public partial class Menambahkanfieldumurpadatablekaryawan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Umur",
                schema: "dbo",
                table: "mst_karyawan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Umur",
                schema: "dbo",
                table: "mst_karyawan");
        }
    }
}
