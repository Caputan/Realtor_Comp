using Microsoft.EntityFrameworkCore.Migrations;

namespace RieltorComp.Migrations
{
    public partial class SmallChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Rents");

            migrationBuilder.DropTable(
                name: "Sells");

            migrationBuilder.AlterColumn<int>(
                name: "Client_Passport",
                table: "Contracts",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Service_Date",
                table: "Contracts",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Service_Period",
                table: "Contracts",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Service_Date",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "Service_Period",
                table: "Contracts");

            migrationBuilder.AlterColumn<string>(
                name: "Client_Passport",
                table: "Contracts",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Loan_Adress = table.Column<string>(type: "TEXT", nullable: false),
                    Loan_Date = table.Column<string>(type: "TEXT", nullable: false),
                    Loan_Period = table.Column<string>(type: "TEXT", nullable: false),
                    Loan_Price = table.Column<double>(type: "REAL", nullable: false),
                    PropertiesAdress = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Loans_Properties_PropertiesAdress",
                        column: x => x.PropertiesAdress,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PropertiesAdress = table.Column<int>(type: "INTEGER", nullable: true),
                    Rent_Adress = table.Column<string>(type: "TEXT", nullable: false),
                    Rent_Payment = table.Column<int>(type: "INTEGER", nullable: false),
                    Rent_Period = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rents_Properties_PropertiesAdress",
                        column: x => x.PropertiesAdress,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PropertiesAdress = table.Column<int>(type: "INTEGER", nullable: true),
                    Sell_Adress = table.Column<string>(type: "TEXT", nullable: false),
                    Sell_Date = table.Column<string>(type: "TEXT", nullable: false),
                    Sell_Price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sells_Properties_PropertiesAdress",
                        column: x => x.PropertiesAdress,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loans_PropertiesAdress",
                table: "Loans",
                column: "PropertiesAdress");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_PropertiesAdress",
                table: "Rents",
                column: "PropertiesAdress");

            migrationBuilder.CreateIndex(
                name: "IX_Sells_PropertiesAdress",
                table: "Sells",
                column: "PropertiesAdress");
        }
    }
}
