using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace doctor.Migrations
{
    public partial class idstuff1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacients_Doctors_DoctorId",
                table: "Pacients");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Pacients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacients_Doctors_DoctorId",
                table: "Pacients",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacients_Doctors_DoctorId",
                table: "Pacients");

            migrationBuilder.AlterColumn<int>(
                name: "DoctorId",
                table: "Pacients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacients_Doctors_DoctorId",
                table: "Pacients",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id");
        }
    }
}
