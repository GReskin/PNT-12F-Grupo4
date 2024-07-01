using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    idCurso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreCurso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.idCurso);
                });

            migrationBuilder.CreateTable(
                name: "Clase",
                columns: table => new
                {
                    idClase = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreClase = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numeroClase = table.Column<int>(type: "int", nullable: false),
                    linkVideo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idCurso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clase", x => x.idClase);
                    table.ForeignKey(
                        name: "FK_Clase_Cursos_idCurso",
                        column: x => x.idCurso,
                        principalTable: "Cursos",
                        principalColumn: "idCurso");
                }) ;

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    edadUsuario = table.Column<int>(type: "int", nullable: false),
                    idCurso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.idUsuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Cursos_idCurso",
                        column: x => x.idCurso,
                        principalTable: "Cursos",
                        principalColumn: "idCurso",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clase_idCurso",
                table: "Clase",
                column: "idCurso");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_idCurso",
                table: "Usuarios",
                column: "idCurso");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clase");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
