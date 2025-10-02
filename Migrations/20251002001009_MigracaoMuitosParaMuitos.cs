using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Passo das Sombras" },
                    { 2, 43, "Furia da Natureza" },
                    { 3, 37, "Tempestade Vulcânica" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 249, 49, 149, 1, 6, 162, 234, 21, 2, 39, 8, 62, 40, 205, 144, 88, 61, 22, 85, 160, 80, 98, 175, 229, 134, 145, 71, 176, 33, 97, 55, 103, 155, 210, 93, 136, 232, 195, 52, 180, 5, 88, 40, 61, 153, 74, 141, 136, 15, 239, 33, 71, 187, 81, 79, 233, 154, 251, 62, 191, 170, 54, 90, 177 }, new byte[] { 218, 72, 7, 177, 114, 67, 41, 167, 228, 218, 179, 118, 170, 122, 20, 205, 122, 157, 57, 193, 71, 119, 160, 230, 52, 117, 27, 40, 32, 60, 13, 156, 1, 207, 101, 138, 5, 220, 97, 93, 237, 57, 133, 15, 214, 83, 52, 234, 174, 193, 245, 56, 225, 159, 187, 105, 6, 182, 54, 7, 212, 3, 27, 198, 80, 218, 193, 156, 67, 23, 160, 66, 181, 74, 189, 221, 134, 193, 124, 117, 124, 66, 61, 44, 235, 102, 196, 8, 144, 15, 36, 122, 15, 188, 163, 158, 61, 129, 220, 146, 204, 212, 189, 28, 190, 50, 232, 60, 153, 211, 80, 144, 154, 33, 103, 102, 187, 183, 213, 95, 59, 70, 58, 216, 138, 125, 101, 103 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 120, 31, 1, 83, 158, 45, 133, 61, 9, 34, 168, 112, 197, 225, 100, 20, 120, 93, 18, 140, 111, 170, 149, 203, 201, 246, 120, 5, 188, 11, 217, 174, 242, 132, 30, 64, 249, 190, 135, 51, 72, 181, 69, 184, 107, 208, 55, 172, 91, 73, 90, 198, 120, 180, 56, 243, 218, 149, 235, 67, 233, 183, 148, 163 }, new byte[] { 151, 202, 86, 42, 25, 157, 120, 67, 98, 191, 120, 217, 171, 181, 201, 139, 123, 41, 217, 189, 237, 31, 99, 200, 218, 201, 118, 11, 227, 96, 204, 9, 209, 101, 64, 70, 64, 55, 97, 15, 219, 237, 44, 16, 7, 173, 170, 84, 247, 74, 63, 128, 194, 19, 56, 130, 109, 152, 153, 107, 161, 183, 235, 114, 68, 31, 32, 164, 126, 19, 105, 116, 174, 193, 178, 109, 21, 113, 4, 229, 95, 196, 85, 32, 119, 119, 145, 14, 114, 54, 83, 89, 170, 118, 109, 198, 242, 245, 26, 201, 248, 4, 242, 201, 83, 26, 129, 53, 185, 59, 213, 168, 193, 2, 55, 23, 155, 249, 136, 106, 0, 51, 99, 247, 176, 171, 48, 8 } });
        }
    }
}
