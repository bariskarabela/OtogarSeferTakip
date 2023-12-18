using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtogarSeferTakip.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Takos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TakoName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sicil = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    District = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Locked = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProfileImageFileName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
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
                    BusModelName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
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
                        principalColumn: "Id",
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
                name: "Users");

            migrationBuilder.DropTable(
                name: "Takos");
        }
    }
}
