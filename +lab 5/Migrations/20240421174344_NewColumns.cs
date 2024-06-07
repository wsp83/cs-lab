using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppHospital.Migrations
{
    /// <inheritdoc />
    public partial class NewColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CheckedIn",
                table: "Patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Insurance",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckedIn",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Insurance",
                table: "Patients");
        }
    }
}
