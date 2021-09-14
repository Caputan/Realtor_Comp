using Microsoft.EntityFrameworkCore.Migrations;

namespace RieltorComp.Migrations
{
    public partial class ContrctsRieltorFIOAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rieltor_FIO",
                table: "Contracts",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rieltor_FIO",
                table: "Contracts");
        }
    }
}
