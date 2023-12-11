using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtogarSeferTakip.Migrations
{
    public partial class mg3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TakoId",
                table: "Takos",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Takos",
                newName: "TakoId");
        }
    }
}
