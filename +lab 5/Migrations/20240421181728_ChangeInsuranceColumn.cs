using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppHospital.Migrations
{
    /// <inheritdoc />
    public partial class ChangeInsuranceColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Insurance",
                table: "Patients");

            migrationBuilder.AddColumn<bool>(
                name: "PremiumInsurance",
                table: "Patients",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PremiumInsurance",
                table: "Patients");

            migrationBuilder.AddColumn<string>(
                name: "Insurance",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
