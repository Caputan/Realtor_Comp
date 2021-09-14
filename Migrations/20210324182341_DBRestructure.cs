using Microsoft.EntityFrameworkCore.Migrations;

namespace RieltorComp.Migrations
{
    public partial class DBRestructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isNew",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "isNew",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Client_FIO",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Client_Passport",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "isNew",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "ClientsId",
                table: "Contracts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientsId",
                table: "Contracts");

            migrationBuilder.AddColumn<bool>(
                name: "isNew",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isNew",
                table: "Properties",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Client_FIO",
                table: "Contracts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Client_Passport",
                table: "Contracts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isNew",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
