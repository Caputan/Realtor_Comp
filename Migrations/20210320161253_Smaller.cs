using Microsoft.EntityFrameworkCore.Migrations;

namespace RieltorComp.Migrations
{
    public partial class Smaller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Services_ServicesService_Name",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ServicesService_Name",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "ServicesService_Name",
                table: "Contracts");

            migrationBuilder.AddColumn<string>(
                name: "Property_Adress",
                table: "Contracts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Property_Adress",
                table: "Contracts");

            migrationBuilder.AddColumn<int>(
                name: "ServicesService_Name",
                table: "Contracts",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ServicesService_Name",
                table: "Contracts",
                column: "ServicesService_Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Services_ServicesService_Name",
                table: "Contracts",
                column: "ServicesService_Name",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
