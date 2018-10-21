using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reviews.Migrations
{
    public partial class categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    ReviewCategory = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Representation" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Animal Description" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImageURL", "ReviewCategory", "Title" },
                values: new object[] { 1, 1, "Wolf is a symbol of guardianship, ritual, loyalty, and spirit. Wolf has the ability to make quick and firm emotional attachments, and often need to trust their own instincts. Thus they teach us to do the same, to trust our hearts and minds, and have control over our own lives.", "https://i.pinimg.com/originals/dd/7c/33/dd7c33afca6b9ab815b944fbc5fbfc33.jpg", "Representation", "Wolf" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImageURL", "ReviewCategory", "Title" },
                values: new object[] { 2, 1, "Owls live within the darkness, which includes magic, mystery, and ancient knowledge. Related to the night is the moon, which owls are also connected to. It becomes a symbol of the feminine and fertility, with the moon's cycles of renewal. Even the mythology relates owl to this wisdom and femininity.", "https://i1.sndcdn.com/avatars-000313148980-h2uglx-t500x500.jpg", "Representation", "Owl" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImageURL", "ReviewCategory", "Title" },
                values: new object[] { 3, 1, "It is usually believed that the crow is a symbol of bad luck and death, but it is not always the case. A crow may be a symbol of life magic and mysteries. It also symbolizes intelligence, flexibility and destiny.", "https://a0.35photo.ru/photos_col/r2/97/487882_500r.jpg", "Representation", "Crow" });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CategoryId",
                table: "Reviews",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
