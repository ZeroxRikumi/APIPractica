using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CartasService.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Poder_Carta_CartaId",
                table: "Poder");

            migrationBuilder.AlterColumn<int>(
                name: "CartaId",
                table: "Poder",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Poder_Carta_CartaId",
                table: "Poder",
                column: "CartaId",
                principalTable: "Carta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Poder_Carta_CartaId",
                table: "Poder");

            migrationBuilder.AlterColumn<int>(
                name: "CartaId",
                table: "Poder",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Poder_Carta_CartaId",
                table: "Poder",
                column: "CartaId",
                principalTable: "Carta",
                principalColumn: "Id");
        }
    }
}
