using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp1.Data.Migrations
{
    public partial class Estudiantes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    idEstudiante = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombreEstudiante = table.Column<string>(maxLength: 75, nullable: false),
                    carreraEstudiante = table.Column<string>(maxLength: 250, nullable: false),
                    semestreEstudiante = table.Column<int>(maxLength: 25, nullable: false),
                    numeroEstudiante = table.Column<int>(maxLength: 25, nullable: false),
                    cedulaEstudiante = table.Column<int>(maxLength: 25, nullable: false),
                    correoEstudiante = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.idEstudiante);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiante");
        }
    }
}
