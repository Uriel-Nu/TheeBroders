using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBroders.BD.Migrations
{
    public partial class turnosvarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TurnoID",
                table: "Turnos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Turnos_TurnoID",
                table: "Turnos",
                column: "TurnoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Turnos_Turnos_TurnoID",
                table: "Turnos",
                column: "TurnoID",
                principalTable: "Turnos",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turnos_Turnos_TurnoID",
                table: "Turnos");

            migrationBuilder.DropIndex(
                name: "IX_Turnos_TurnoID",
                table: "Turnos");

            migrationBuilder.DropColumn(
                name: "TurnoID",
                table: "Turnos");
        }
    }
}
