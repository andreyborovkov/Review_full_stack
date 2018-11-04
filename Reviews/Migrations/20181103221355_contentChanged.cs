using Microsoft.EntityFrameworkCore.Migrations;

namespace Reviews.Migrations
{
    public partial class contentChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Acoustic-Electric");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Electric");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "ImageURL", "Title" },
                values: new object[] { "Fender's FA-125 is a visually stunning entry-level guitar with a budget-friendly price. It has a quality laminate spruce and basswood construction with a modern Fender 3+3 headstock and stylish Viking bridge which combine to create an easy-playing instrument that sounds great. Beginners and developing players will appreciate this guitar, which includes a mahogany neck to gives the guitar lively tone and a smooth playing feel.", "https://media.guitarcenter.com/is/image/MMGS7/FA-125-Dreadnought-Acoustic-Guitar-Natural/L18556000001000-00-500x500.jpg", "Fender FA-125" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "ImageURL", "Title" },
                values: new object[] { "Acoustic electric guitar with select spruce top and mahogany back and sides. Mahogany neck. The V70CE is equipped with a soft cutaway for higher access. It is a very responsive instrument with capacity for great dynamic range both acoustically and through the output.", "https://media.guitarcenter.com/is/image/MMGS7/V70CE-Acoustic-Electric-Guitar-Transparent-Blue/519468000012000-00-500x500.jpg", "Ibanez V70CE" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "ImageURL", "Title" },
                values: new object[] { "Yamaha's F335 gives you that classic dreadnought shape and sound at a price point that won't break your bank. The F335's tonewood combination includes a laminate spruce top, rosewood fingerboard and bridge, and meranti back and sides. Gold die-cast tuners provide smooth and accurate tuning while a tortoiseshell pickguard gives a bit more style. Case sold separately.", "https://media.guitarcenter.com/is/image/MMGS7/F335-Acoustic-Guitar-Black/512940000001000-00-500x500.jpg", "Yamaha F335" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CategoryId", "Content", "ImageURL", "ReviewCategory", "Title" },
                values: new object[] { 4, 2, "The JIVA10 is based on the Ibanez S series and features Nita’s own personal touches, such as her signature 'Pandemonium' pickups by DiMarzio in a versatile HSH configuration. Triggered by a 5-way selector switch, these pickups deliver an amazing array of tones while a well-placed master volume control lets you make rapid adjustments with ease. For the best performance in a tremolo, Nita choose the Ibanez Edge Zero II bridge. With its sleek and comfortable, low-profile design and stud lock function for superior tuning stability you'll be able to express every aspect of your musical personality. It all adds up to a pro-level playing experience for anyone with the courage to go all the way. ", "https://media.guitarcenter.com/is/image/MMGS7/Nita-Strauss-JIVA10-Signature-Electric-Guitar-Deep-Space-Blonde/L19851000001000-00-500x500.jpg", null, "Ibanez Nita Strauss JIVA10" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Representation");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Animal Description");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "ImageURL", "Title" },
                values: new object[] { "Wolf is a symbol of guardianship, ritual, loyalty, and spirit. Wolf has the ability to make quick and firm emotional attachments, and often need to trust their own instincts. Thus they teach us to do the same, to trust our hearts and minds, and have control over our own lives.", "https://i.pinimg.com/originals/dd/7c/33/dd7c33afca6b9ab815b944fbc5fbfc33.jpg", "Wolf" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "ImageURL", "Title" },
                values: new object[] { "Owls live within the darkness, which includes magic, mystery, and ancient knowledge. Related to the night is the moon, which owls are also connected to. It becomes a symbol of the feminine and fertility, with the moon's cycles of renewal. Even the mythology relates owl to this wisdom and femininity.", "https://i1.sndcdn.com/avatars-000313148980-h2uglx-t500x500.jpg", "Owl" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "ImageURL", "Title" },
                values: new object[] { "It is usually believed that the crow is a symbol of bad luck and death, but it is not always the case. A crow may be a symbol of life magic and mysteries. It also symbolizes intelligence, flexibility and destiny.", "https://a0.35photo.ru/photos_col/r2/97/487882_500r.jpg", "Crow" });
        }
    }
}
