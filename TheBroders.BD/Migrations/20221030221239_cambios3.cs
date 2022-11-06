using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheBroders.BD.Migrations
{
    public partial class cambios3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turnos_Clientes_ClienteID",
                table: "Turnos");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteID",
                table: "Turnos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Turnos_Clientes_ClienteID",
                table: "Turnos",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turnos_Clientes_ClienteID",
                table: "Turnos");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteID",
                table: "Turnos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Turnos_Clientes_ClienteID",
                table: "Turnos",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
