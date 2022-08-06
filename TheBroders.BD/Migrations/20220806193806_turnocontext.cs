using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBroders.BD.Migrations
{
    public partial class turnocontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turnos_Turnos_TurnoID",
                table: "Turnos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Turnos",
                table: "Turnos");

            migrationBuilder.RenameTable(
                name: "Turnos",
                newName: "Turno");

            migrationBuilder.RenameIndex(
                name: "IX_Turnos_TurnoID",
                table: "Turno",
                newName: "IX_Turno_TurnoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Turno",
                table: "Turno",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Turno_Turno_TurnoID",
                table: "Turno",
                column: "TurnoID",
                principalTable: "Turno",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turno_Turno_TurnoID",
                table: "Turno");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Turno",
                table: "Turno");

            migrationBuilder.RenameTable(
                name: "Turno",
                newName: "Turnos");

            migrationBuilder.RenameIndex(
                name: "IX_Turno_TurnoID",
                table: "Turnos",
                newName: "IX_Turnos_TurnoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Turnos",
                table: "Turnos",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Turnos_Turnos_TurnoID",
                table: "Turnos",
                column: "TurnoID",
                principalTable: "Turnos",
                principalColumn: "ID");
        }
    }
}
