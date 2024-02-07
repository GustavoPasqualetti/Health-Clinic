using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthClinic_cd.Migrations
{
    /// <inheritdoc />
    public partial class Bd5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DescricaoProntuario",
                table: "Prontuario",
                type: "VARCHAR(256)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR");

            migrationBuilder.AlterColumn<string>(
                name: "Comentarios",
                table: "Comentario",
                type: "VARCHAR(256)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DescricaoProntuario",
                table: "Prontuario",
                type: "VARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(256)");

            migrationBuilder.AlterColumn<string>(
                name: "Comentarios",
                table: "Comentario",
                type: "VARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(256)");
        }
    }
}
