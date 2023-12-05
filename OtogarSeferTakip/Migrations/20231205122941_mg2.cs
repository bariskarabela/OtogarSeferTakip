using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtogarSeferTakip.Migrations
{
    public partial class mg2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Takos",
                columns: table => new
                {
                    TakoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakoName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takos", x => x.TakoId);
                });

            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusPlate = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BusType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BusBrand = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BusModel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BusEngineNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TakoId = table.Column<int>(type: "int", nullable: false),
                    TakoNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buses_Takos_TakoId",
                        column: x => x.TakoId,
                        principalTable: "Takos",
                        principalColumn: "TakoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buses_TakoId",
                table: "Buses",
                column: "TakoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buses");

            migrationBuilder.DropTable(
                name: "Takos");
        }
    }
}
