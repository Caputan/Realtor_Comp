using Microsoft.EntityFrameworkCore.Migrations;

namespace RieltorComp.Migrations
{
    public partial class PropertyChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Services_ServiceId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_ServiceId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Owner_FIO",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Owner_Passport",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Properties");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Owner_FIO",
                table: "Properties",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Owner_Passport",
                table: "Properties",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Properties",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_ServiceId",
                table: "Properties",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Services_ServiceId",
                table: "Properties",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
