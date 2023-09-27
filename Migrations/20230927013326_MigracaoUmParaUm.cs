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
                name: "PersonagemId",
                table: "TB_ARMA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 75, 6, 70, 38, 94, 54, 185, 20, 5, 27, 56, 17, 150, 115, 97, 24, 93, 156, 55, 147, 60, 169, 170, 183, 203, 73, 175, 92, 84, 27, 233, 38, 56, 253, 120, 111, 93, 234, 122, 236, 242, 132, 158, 190, 211, 41, 175, 131, 26, 157, 221, 192, 201, 116, 132, 234, 78, 105, 45, 61, 200, 132, 217, 17 }, new byte[] { 20, 59, 191, 100, 180, 9, 68, 215, 249, 211, 245, 254, 198, 98, 158, 197, 87, 146, 132, 215, 228, 229, 225, 112, 220, 217, 102, 85, 222, 174, 235, 132, 235, 133, 126, 87, 37, 42, 241, 44, 56, 133, 106, 254, 99, 34, 152, 249, 62, 151, 236, 31, 60, 200, 177, 203, 235, 60, 46, 182, 33, 26, 197, 42, 165, 50, 90, 91, 213, 113, 160, 103, 44, 84, 54, 70, 161, 113, 214, 255, 173, 82, 241, 19, 27, 17, 80, 156, 10, 54, 235, 215, 177, 16, 190, 115, 18, 142, 153, 203, 107, 245, 226, 26, 101, 88, 206, 32, 15, 6, 28, 203, 126, 110, 114, 126, 143, 192, 166, 37, 163, 160, 202, 223, 158, 30, 36, 155 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMA_PersonagemId",
                table: "TB_ARMA",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMA_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMA",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMA_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMA_PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 113, 25, 171, 232, 59, 145, 6, 52, 115, 9, 129, 109, 117, 227, 113, 114, 209, 13, 147, 201, 246, 233, 45, 8, 198, 76, 211, 60, 47, 31, 70, 237, 166, 201, 87, 174, 164, 83, 251, 83, 17, 119, 111, 131, 55, 102, 126, 46, 113, 50, 67, 11, 136, 207, 69, 150, 163, 30, 107, 140, 134, 132, 107, 199 }, new byte[] { 237, 82, 124, 160, 67, 241, 41, 7, 55, 255, 90, 78, 230, 227, 159, 127, 72, 200, 40, 208, 56, 9, 136, 23, 118, 139, 147, 87, 243, 41, 147, 53, 142, 237, 168, 205, 80, 90, 151, 223, 59, 239, 100, 40, 255, 240, 108, 34, 216, 206, 236, 195, 30, 12, 107, 243, 87, 93, 169, 66, 179, 218, 57, 89, 56, 210, 218, 234, 21, 7, 12, 244, 65, 111, 187, 50, 230, 180, 108, 130, 148, 238, 199, 104, 229, 243, 134, 239, 130, 225, 99, 169, 118, 150, 41, 72, 55, 68, 133, 242, 189, 99, 209, 158, 159, 244, 97, 0, 42, 179, 96, 20, 181, 60, 209, 156, 235, 54, 207, 229, 78, 250, 82, 121, 172, 129, 98, 162 } });
        }
    }
}
