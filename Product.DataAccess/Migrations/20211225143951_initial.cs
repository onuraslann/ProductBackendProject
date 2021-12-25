using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Product.DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Decription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productts_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productts_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_OperationClaim_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "BrandName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifedDate", "ModifiedByName" },
                values: new object[] { 1, "Asus", "InitialCreate", new DateTime(2021, 12, 25, 17, 39, 51, 168, DateTimeKind.Local).AddTicks(926), true, false, new DateTime(2021, 12, 25, 17, 39, 51, 168, DateTimeKind.Local).AddTicks(1199), "InitialCreate" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreatedByName", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifedDate", "ModifiedByName" },
                values: new object[] { 1, "Teknolojik Aletler", "InitialCreate", new DateTime(2021, 12, 25, 17, 39, 51, 171, DateTimeKind.Local).AddTicks(6534), "Teknolojik Ürünler; teknoloji kullanılarak üretilen aletler, araç-gereçlerdir ", true, false, new DateTime(2021, 12, 25, 17, 39, 51, 171, DateTimeKind.Local).AddTicks(6543), "InitialCreate" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "ColorName", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifedDate", "ModifiedByName" },
                values: new object[] { 1, "Siyah", "InitialCreate", new DateTime(2021, 12, 25, 17, 39, 51, 172, DateTimeKind.Local).AddTicks(8825), true, false, new DateTime(2021, 12, 25, 17, 39, 51, 172, DateTimeKind.Local).AddTicks(8834), "InitialCreate" });

            migrationBuilder.InsertData(
                table: "OperationClaim",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Decription", "IsActive", "IsDeleted", "ModifedDate", "ModifiedByName", "Name" },
                values: new object[] { 1, "InitialCreate", new DateTime(2021, 12, 25, 17, 39, 51, 174, DateTimeKind.Local).AddTicks(2071), "Admin tüm yetkilere sahiptir", true, false, new DateTime(2021, 12, 25, 17, 39, 51, 174, DateTimeKind.Local).AddTicks(2075), "InitialCreate", "Admin" });

            migrationBuilder.InsertData(
                table: "Productts",
                columns: new[] { "Id", "BrandId", "CategoryId", "ColorId", "CreatedByName", "CreatedDate", "IsActive", "IsDeleted", "ModifedDate", "ModifiedByName", "Price", "ProductName", "Stock" },
                values: new object[] { 1, 1, 1, 1, "InitialCreate", new DateTime(2021, 12, 25, 17, 39, 51, 179, DateTimeKind.Local).AddTicks(2454), true, false, new DateTime(2021, 12, 25, 17, 39, 51, 179, DateTimeKind.Local).AddTicks(2463), "InitialCreate", 7500.0, "Bilgisayar", 20 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedByName", "CreatedDate", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifedDate", "ModifiedByName", "OperationClaimId", "PasswordHash" },
                values: new object[] { 1, "InitialCreate", new DateTime(2021, 12, 25, 17, 39, 51, 188, DateTimeKind.Local).AddTicks(2640), "theeaslann1@gmail.com", "Onur", true, false, "Aslan", new DateTime(2021, 12, 25, 17, 39, 51, 188, DateTimeKind.Local).AddTicks(2644), "InitialCreate", 1, new byte[] { 100, 51, 50, 52, 53, 98, 48, 48, 100, 97, 97, 51, 101, 54, 101, 102, 52, 97, 102, 97, 100, 52, 55, 98, 54, 57, 50, 49, 50, 99, 102, 50 } });

            migrationBuilder.CreateIndex(
                name: "IX_Productts_BrandId",
                table: "Productts",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Productts_CategoryId",
                table: "Productts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Productts_ColorId",
                table: "Productts",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_OperationClaimId",
                table: "Users",
                column: "OperationClaimId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "OperationClaim");
        }
    }
}
