using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StocPiese",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumePiesa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodPiesa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BucatiPiesa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pret = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StocPiese", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StocPiese");
        }
    }
}
