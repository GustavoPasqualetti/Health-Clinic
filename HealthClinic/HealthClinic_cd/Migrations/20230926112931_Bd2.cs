using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthClinic_cd.Migrations
{
    /// <inheritdoc />
    public partial class Bd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Email",
                table: "Usuario",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_Cpf",
                table: "Paciente",
                column: "Cpf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medico_Crm",
                table: "Medico",
                column: "Crm",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clinica_CNPJ",
                table: "Clinica",
                column: "CNPJ",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Usuario_Email",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_Cpf",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Medico_Crm",
                table: "Medico");

            migrationBuilder.DropIndex(
                name: "IX_Clinica_CNPJ",
                table: "Clinica");
        }
    }
}
