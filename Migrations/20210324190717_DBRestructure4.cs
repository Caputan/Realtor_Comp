using Microsoft.EntityFrameworkCore.Migrations;

namespace RieltorComp.Migrations
{
    public partial class DBRestructure4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rieltor_FIO",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Service_Done",
                table: "Contracts");

            migrationBuilder.AddColumn<int>(
                name: "ServicesId",
                table: "Contracts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Contracts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ServicesId",
                table: "Contracts",
                column: "ServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_UsersId",
                table: "Contracts",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Services_ServicesId",
                table: "Contracts",
                column: "ServicesId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Users_UsersId",
                table: "Contracts",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Services_ServicesId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Users_UsersId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ServicesId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_UsersId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "ServicesId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Contracts");

            migrationBuilder.AddColumn<string>(
                name: "Rieltor_FIO",
                table: "Contracts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Service_Done",
                table: "Contracts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
