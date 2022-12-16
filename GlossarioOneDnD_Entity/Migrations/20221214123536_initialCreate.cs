using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GlossarioOneDnDEntity.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classe",
                columns: table => new
                {
                    ClasseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClasseNome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classe", x => x.ClasseID);
                });

            migrationBuilder.CreateTable(
                name: "Glossario",
                columns: table => new
                {
                    GlossarioRegrasId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Versao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glossario", x => x.GlossarioRegrasId);
                });

            migrationBuilder.CreateTable(
                name: "Niveis",
                columns: table => new
                {
                    NiveisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nivel = table.Column<int>(type: "int", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VersoesAnteriores = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClasseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Niveis", x => x.NiveisID);
                    table.ForeignKey(
                        name: "FK_Niveis_Classe_ClasseID",
                        column: x => x.ClasseID,
                        principalTable: "Classe",
                        principalColumn: "ClasseID");
                });

            migrationBuilder.CreateTable(
                name: "Regras",
                columns: table => new
                {
                    RegraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VersoesAnteriores = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GlossarioRegrasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regras", x => x.RegraId);
                    table.ForeignKey(
                        name: "FK_Regras_Glossario_GlossarioRegrasId",
                        column: x => x.GlossarioRegrasId,
                        principalTable: "Glossario",
                        principalColumn: "GlossarioRegrasId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Niveis_ClasseID",
                table: "Niveis",
                column: "ClasseID");

            migrationBuilder.CreateIndex(
                name: "IX_Regras_GlossarioRegrasId",
                table: "Regras",
                column: "GlossarioRegrasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Niveis");

            migrationBuilder.DropTable(
                name: "Regras");

            migrationBuilder.DropTable(
                name: "Classe");

            migrationBuilder.DropTable(
                name: "Glossario");
        }
    }
}
