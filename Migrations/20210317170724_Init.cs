using Microsoft.EntityFrameworkCore.Migrations;

namespace RieltorComp.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FIO = table.Column<string>(type: "TEXT", nullable: false),
                    Passport = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Service_Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rielter_FIO = table.Column<string>(type: "TEXT", nullable: false),
                    Client_FIO = table.Column<string>(type: "TEXT", nullable: false),
                    Client_Passport = table.Column<string>(type: "TEXT", nullable: false),
                    Service_Done = table.Column<string>(type: "TEXT", nullable: false),
                    ServicesService_Name = table.Column<int>(type: "INTEGER", nullable: true),
                    Service_Price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_Services_ServicesService_Name",
                        column: x => x.ServicesService_Name,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Owner_FIO = table.Column<string>(type: "TEXT", nullable: false),
                    Owner_Passport = table.Column<int>(type: "INTEGER", nullable: false),
                    Adress = table.Column<string>(type: "TEXT", nullable: false),
                    Living_Area = table.Column<string>(type: "TEXT", nullable: false),
                    Number_Of_Rooms = table.Column<int>(type: "INTEGER", nullable: false),
                    ServiceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Loan_Adress = table.Column<string>(type: "TEXT", nullable: false),
                    PropertiesAdress = table.Column<int>(type: "INTEGER", nullable: true),
                    Loan_Date = table.Column<string>(type: "TEXT", nullable: false),
                    Loan_Price = table.Column<double>(type: "REAL", nullable: false),
                    Loan_Period = table.Column<string>(type: "TEXT", nullable: false)
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
                    Rent_Adress = table.Column<string>(type: "TEXT", nullable: false),
                    PropertiesAdress = table.Column<int>(type: "INTEGER", nullable: true),
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
                    Sell_Adress = table.Column<string>(type: "TEXT", nullable: false),
                    PropertiesAdress = table.Column<int>(type: "INTEGER", nullable: true),
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
                name: "IX_Contracts_ServicesService_Name",
                table: "Contracts",
                column: "ServicesService_Name");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_PropertiesAdress",
                table: "Loans",
                column: "PropertiesAdress");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_ServiceId",
                table: "Properties",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Rents_PropertiesAdress",
                table: "Rents",
                column: "PropertiesAdress");

            migrationBuilder.CreateIndex(
                name: "IX_Sells_PropertiesAdress",
                table: "Sells",
                column: "PropertiesAdress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Rents");

            migrationBuilder.DropTable(
                name: "Sells");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
