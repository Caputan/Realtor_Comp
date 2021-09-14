using Microsoft.EntityFrameworkCore.Migrations;

namespace RieltorComp.Migrations
{
    public partial class DBRestructure3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner_FIO",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Owner_Passport",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Property_Adress",
                table: "Contracts");

            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "Contracts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_PropertyId",
                table: "Contracts",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Properties_PropertyId",
                table: "Contracts",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Properties_PropertyId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_PropertyId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "Contracts");

            migrationBuilder.AddColumn<string>(
                name: "Owner_FIO",
                table: "Contracts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Owner_Passport",
                table: "Contracts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Property_Adress",
                table: "Contracts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
