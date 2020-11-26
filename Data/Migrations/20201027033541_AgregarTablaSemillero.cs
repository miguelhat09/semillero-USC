using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp1.Data.Migrations
{
    public partial class AgregarTablaSemillero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Semillero",
                columns: table => new
                {
                    idSemillero = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombreSemillero = table.Column<string>(nullable: false),
                    descripcionSemillero = table.Column<string>(nullable: false),
                    necesidadesSemillero = table.Column<string>(nullable: false),
                    interesadosSemillero = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semillero", x => x.idSemillero);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Semillero");
        }
    }
}
