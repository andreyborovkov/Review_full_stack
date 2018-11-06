using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reviews.Migrations
{
    public partial class tagsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReviewTag",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReviewId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewTag_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewTag_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Text" },
                values: new object[] { 1, "6 string" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Text" },
                values: new object[] { 2, "Ibanez" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Text" },
                values: new object[] { 3, "Yamaha" });

            migrationBuilder.InsertData(
                table: "ReviewTag",
                columns: new[] { "Id", "ReviewId", "TagId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 2, 2 },
                    { 6, 4, 2 },
                    { 7, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReviewTag_ReviewId",
                table: "ReviewTag",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewTag_TagId",
                table: "ReviewTag",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReviewTag");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
