using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DairyFirm.Data.Migrations
{
    /// <inheritdoc />
    public partial class models_12Oct25_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CowInfos",
                columns: table => new
                {
                    CowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CowInfos", x => x.CowId);
                });

            migrationBuilder.CreateTable(
                name: "FeedingInfos",
                columns: table => new
                {
                    FeedingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CowId = table.Column<int>(type: "int", nullable: false),
                    FoodType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeedingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FeedingQuantity = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedingInfos", x => x.FeedingId);
                });

            migrationBuilder.CreateTable(
                name: "MeatProducions",
                columns: table => new
                {
                    MeatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CowId = table.Column<int>(type: "int", nullable: false),
                    WeightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeatProducions", x => x.MeatId);
                });

            migrationBuilder.CreateTable(
                name: "MilkProductions",
                columns: table => new
                {
                    MilkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CowId = table.Column<int>(type: "int", nullable: false),
                    MilkDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MorningMilk = table.Column<double>(type: "float", nullable: false),
                    EveningMilk = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilkProductions", x => x.MilkId);
                });

            migrationBuilder.CreateTable(
                name: "VaccineApplies",
                columns: table => new
                {
                    VaccineApplyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaccineId = table.Column<int>(type: "int", nullable: false),
                    CowId = table.Column<int>(type: "int", nullable: false),
                    VaccineApplyAmmount = table.Column<double>(type: "float", nullable: false),
                    VaccineApplyMonth = table.Column<int>(type: "int", nullable: false),
                    VaccineApplyDay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineApplies", x => x.VaccineApplyId);
                });

            migrationBuilder.CreateTable(
                name: "VaccineInfos",
                columns: table => new
                {
                    VaccineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaccineName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VaccinePrice = table.Column<double>(type: "float", nullable: false),
                    TotalVaccine = table.Column<int>(type: "int", nullable: false),
                    VaccineMonth = table.Column<int>(type: "int", nullable: false),
                    VaccineDay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineInfos", x => x.VaccineId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CowInfos");

            migrationBuilder.DropTable(
                name: "FeedingInfos");

            migrationBuilder.DropTable(
                name: "MeatProducions");

            migrationBuilder.DropTable(
                name: "MilkProductions");

            migrationBuilder.DropTable(
                name: "VaccineApplies");

            migrationBuilder.DropTable(
                name: "VaccineInfos");
        }
    }
}
