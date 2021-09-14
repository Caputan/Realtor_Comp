using Microsoft.EntityFrameworkCore.Migrations;

namespace RieltorComp.Migrations
{
    public partial class DBRestructure2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ClientsId",
                table: "Contracts",
                column: "ClientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Clients_ClientsId",
                table: "Contracts",
                column: "ClientsId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Clients_ClientsId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ClientsId",
                table: "Contracts");
        }
    }
}
