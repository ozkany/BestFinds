using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BestFindsApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    WebSite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    SellerId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Men's" },
                    { 2, "Women's" },
                    { 3, "Electronics" },
                    { 4, "Outdoors" }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "Name", "WebSite" },
                values: new object[,]
                {
                    { 1, "Hepsiburada", "www.hepsiburada.com" },
                    { 2, "Trendyol", "www.trendyol.com" },
                    { 3, "Morhipo", "www.morhipo.com" },
                    { 4, "ModaCruz", "www.modacruz.com" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Description", "Name", "Price", "SellerId", "URL" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Koton Erkek Slim Pantolon", "Koton Erkek Slim Pantolon", 70.39m, 1, "https://www.hepsiburada.com/koton-erkek-slim-pantolon-p-HBV00000DI558" },
                    { 2, 1, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lc Waikiki Erkek Polo Yaka Tshirt", "Lc Waikiki Erkek Polo Yaka Tshirt", 29.99m, 1, "https://www.hepsiburada.com/lc-waikiki-erkek-polo-yaka-tshirt-p-HBV00000GR2VA" },
                    { 7, 3, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung 40J5270 40\" 102 Ekran Uydu Alıcılı Full HD Smart LED TV", "Samsung 40J5270 40\" 102 Ekran Uydu Alıcılı Full HD Smart LED TV", 2191.50m, 1, "https://www.hepsiburada.com/samsung-40j5270-40-102-ekran-uydu-alicili-full-hd-smart-led-tv-p-EVTVSAM40J5270" },
                    { 9, 3, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei Mate 10 Lite (Huawei Türkiye Garantili)", "Huawei Mate 10 Lite", 1799.90m, 1, "https://www.hepsiburada.com/huawei-mate-10-lite-huawei-turkiye-garantili-p-HBV0000093BZC" },
                    { 10, 3, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Huawei Watch GT Classic Akıllı Saat - Kahverengi", "Huawei Watch GT Classic Akıllı Saat - Kahverengi", 1299m, 1, "https://www.hepsiburada.com/huawei-watch-gt-classic-akilli-saat-kahverengi-p-HBV00000FSSWW" },
                    { 11, 4, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salcano Ng 650 27.5 Jant Hd Bisiklet 18 inç Kadro, Siyah - Kırmızı", "Salcano Ng 650 27.5 Jant Hd Bisiklet 18 inç Kadro", 1840m, 1, "https://www.hepsiburada.com/salcano-ng-650-27-5-jant-hd-bisiklet-18-inc-kadro-siyah-kirmizi-p-HBV00000BH262" },
                    { 12, 4, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The North Face - Mountain 25 - 2 kişilik Çadır Sarı", "The North Face - Mountain 25 - 2 kişilik Çadır Sarı", 3801.85m, 1, "https://www.hepsiburada.com/the-north-face-mountain-25-2-kisilik-cadir-sari-p-HBV0000021PGK?magaza=NORADRENAL%C4%B0N" },
                    { 3, 2, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kadın Siyah Pantolon IW6180003108 IW6180003108", "Kadın Siyah Pantolon", 164.50m, 2, "https://www.trendyol.com/ipekyol/kadin-siyah-pantolon-iw6180003108-p-3603675?boutiqueId=309730&merchantId=968" },
                    { 4, 2, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kadın Bej Etek (18805)", "Kadın Bej Etek", 420.00m, 2, "https://www.trendyol.com/burberry/kadin-bej-etek-18805-p-3224783?boutiqueId=307783&merchantId=4421" },
                    { 5, 2, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jean Pantolon | Sophie - Skinny", "Jean Pantolon", 149.90m, 3, "https://www.morhipo.com/kampanya/detay/15359570/80621/tommy-hilfiger-jean-pantolon-sophie-skinny" },
                    { 6, 2, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ceket", "Ceket", 904.90m, 3, "https://www.morhipo.com/kampanya/detay/20712902/80613/emporio-armani-ss1600001979-ceket" },
                    { 8, 2, new DateTime(2019, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nine West Çanta", "Nine West Çanta", 459m, 3, "https://www.morhipo.com/nine-west-canta/22312953/detay" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SellerId",
                table: "Products",
                column: "SellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Sellers");
        }
    }
}
