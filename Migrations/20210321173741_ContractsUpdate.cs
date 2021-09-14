using Microsoft.EntityFrameworkCore.Migrations;

namespace RieltorComp.Migrations
{
    public partial class ContractsUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rielter_FIO",
                table: "Contracts",
                newName: "Owner_Passport");

            migrationBuilder.AddColumn<string>(
                name: "Owner_FIO",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Owner_Passport",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Owner_FIO",
                table: "Contracts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Service_Persent",
                table: "Contracts",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner_FIO",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Owner_Passport",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Owner_FIO",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Service_Persent",
                table: "Contracts");

            migrationBuilder.RenameColumn(
                name: "Owner_Passport",
                table: "Contracts",
                newName: "Rielter_FIO");
        }
    }
}
