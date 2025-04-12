using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorsAppointment.Migrations
{
    /// <inheritdoc />
    public partial class ModifyAppointmentDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Appointments",
                newName: "PatientDofB");

            migrationBuilder.RenameColumn(
                name: "PationtName",
                table: "Appointments",
                newName: "PatientPhone");

            migrationBuilder.RenameColumn(
                name: "Disease",
                table: "Appointments",
                newName: "PatientName");

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Appointments",
                newName: "PatientEmail");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Appointments",
                newName: "AppoTime");

            migrationBuilder.AddColumn<DateOnly>(
                name: "AppoDate",
                table: "Appointments",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppoDate",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "PatientPhone",
                table: "Appointments",
                newName: "PationtName");

            migrationBuilder.RenameColumn(
                name: "PatientName",
                table: "Appointments",
                newName: "Disease");

            migrationBuilder.RenameColumn(
                name: "PatientEmail",
                table: "Appointments",
                newName: "Department");

            migrationBuilder.RenameColumn(
                name: "PatientDofB",
                table: "Appointments",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "AppoTime",
                table: "Appointments",
                newName: "CreatedDate");
        }
    }
}
