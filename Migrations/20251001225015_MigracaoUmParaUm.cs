using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 120, 31, 1, 83, 158, 45, 133, 61, 9, 34, 168, 112, 197, 225, 100, 20, 120, 93, 18, 140, 111, 170, 149, 203, 201, 246, 120, 5, 188, 11, 217, 174, 242, 132, 30, 64, 249, 190, 135, 51, 72, 181, 69, 184, 107, 208, 55, 172, 91, 73, 90, 198, 120, 180, 56, 243, 218, 149, 235, 67, 233, 183, 148, 163 }, new byte[] { 151, 202, 86, 42, 25, 157, 120, 67, 98, 191, 120, 217, 171, 181, 201, 139, 123, 41, 217, 189, 237, 31, 99, 200, 218, 201, 118, 11, 227, 96, 204, 9, 209, 101, 64, 70, 64, 55, 97, 15, 219, 237, 44, 16, 7, 173, 170, 84, 247, 74, 63, 128, 194, 19, 56, 130, 109, 152, 153, 107, 161, 183, 235, 114, 68, 31, 32, 164, 126, 19, 105, 116, 174, 193, 178, 109, 21, 113, 4, 229, 95, 196, 85, 32, 119, 119, 145, 14, 114, 54, 83, 89, 170, 118, 109, 198, 242, 245, 26, 201, 248, 4, 242, 201, 83, 26, 129, 53, 185, 59, 213, 168, 193, 2, 55, 23, 155, 249, 136, 106, 0, 51, 99, 247, 176, 171, 48, 8 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 149, 112, 196, 94, 236, 147, 111, 79, 221, 114, 197, 42, 5, 165, 85, 199, 247, 81, 12, 169, 76, 158, 86, 23, 204, 11, 189, 188, 226, 187, 28, 22, 15, 122, 3, 0, 28, 254, 162, 144, 211, 154, 192, 38, 163, 128, 195, 6, 91, 120, 122, 80, 67, 2, 201, 168, 24, 163, 118, 177, 139, 234, 166, 56 }, new byte[] { 3, 7, 175, 210, 21, 98, 178, 12, 83, 234, 60, 27, 29, 86, 38, 31, 236, 164, 25, 152, 222, 150, 175, 196, 115, 106, 153, 235, 209, 161, 150, 47, 127, 163, 39, 177, 250, 49, 218, 61, 115, 186, 18, 109, 109, 153, 48, 52, 88, 49, 84, 92, 252, 189, 69, 226, 52, 81, 115, 247, 219, 69, 176, 156, 24, 223, 92, 43, 226, 12, 93, 229, 210, 203, 151, 157, 60, 218, 127, 34, 176, 39, 228, 197, 189, 94, 40, 154, 102, 97, 0, 207, 173, 174, 232, 110, 145, 137, 185, 235, 5, 26, 60, 56, 101, 3, 92, 104, 142, 156, 44, 177, 125, 25, 211, 209, 126, 79, 227, 210, 201, 108, 46, 28, 229, 160, 18, 168 } });
        }
    }
}
