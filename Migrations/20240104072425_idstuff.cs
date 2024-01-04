using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace doctor.Migrations
{
    public partial class idstuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Doctors_DoctorId",
                table: "Visits");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_Pacients_PacientId",
                table: "Visits");

            migrationBuilder.DropIndex(
                name: "IX_Visits_DoctorId",
                table: "Visits");

            migrationBuilder.DropIndex(
                name: "IX_Visits_PacientId",
                table: "Visits");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Visits_DoctorId",
                table: "Visits",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_PacientId",
                table: "Visits",
                column: "PacientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Doctors_DoctorId",
                table: "Visits",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_Pacients_PacientId",
                table: "Visits",
                column: "PacientId",
                principalTable: "Pacients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
