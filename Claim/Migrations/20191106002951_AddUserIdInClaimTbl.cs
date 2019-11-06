using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Claim.Migrations
{
    public partial class AddUserIdInClaimTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClaimDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ClaimId = table.Column<Guid>(nullable: false),
                    SerialNo = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    DateTransaction = table.Column<DateTime>(type: "datetime", nullable: false),
                    CostCentreCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    GLCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    Currency = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TaxRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Claims",
                columns: table => new
                {
                    ClaimId = table.Column<Guid>(nullable: false),
                    ClaimNo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Name = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    BranchCode = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    DateApply = table.Column<DateTime>(type: "datetime", nullable: false),
                    BankCode = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    BankAccount = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    AccountHolderName = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 20, nullable: false, defaultValueSql: "('NEW')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.ClaimId);
                });

            migrationBuilder.CreateTable(
                name: "CostCentre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CostCentreCode = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CostCentreName = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    CostCentreDescription = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostCentre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralLedgers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    GLCode = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    GLName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    GLDescription = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    UpdatedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralLedgers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Taxes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    TaxName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    TaxCode = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    TaxRate = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    FirstName = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    LastName = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    BranchCode = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    BankAccountNo = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    BankCode = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    BankAccountName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address1 = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Address2 = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    PostCode = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    State = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    Country = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CostCentre",
                table: "CostCentre",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClaimDetails");

            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "CostCentre");

            migrationBuilder.DropTable(
                name: "GeneralLedgers");

            migrationBuilder.DropTable(
                name: "Taxes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
