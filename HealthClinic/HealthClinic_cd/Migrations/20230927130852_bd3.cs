using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthClinic_cd.Migrations
{
    /// <inheritdoc />
    public partial class bd3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "HorarioConsulta",
                table: "Consulta",
                type: "TIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "HoraFuncionamento",
                table: "Clinica",
                type: "TIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "HoraFechamento",
                table: "Clinica",
                type: "TIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "HorarioConsulta",
                table: "Consulta",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "TIME");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HoraFuncionamento",
                table: "Clinica",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "TIME");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HoraFechamento",
                table: "Clinica",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "TIME");
        }
    }
}
