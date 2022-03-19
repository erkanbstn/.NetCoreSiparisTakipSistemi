using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SiparisTakipSistemiCore.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminParola = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Musteris",
                columns: table => new
                {
                    MusteriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriParola = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MusteriTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteris", x => x.MusteriID);
                });

            migrationBuilder.CreateTable(
                name: "Sipariss",
                columns: table => new
                {
                    SiparisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EPosta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Urun = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MusteriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sipariss", x => x.SiparisID);
                    table.ForeignKey(
                        name: "FK_Sipariss_Musteris_MusteriID",
                        column: x => x.MusteriID,
                        principalTable: "Musteris",
                        principalColumn: "MusteriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sipariss_MusteriID",
                table: "Sipariss",
                column: "MusteriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Sipariss");

            migrationBuilder.DropTable(
                name: "Musteris");
        }
    }
}
