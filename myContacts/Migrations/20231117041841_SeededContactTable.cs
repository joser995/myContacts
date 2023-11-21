using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace myContacts.Migrations
{
    /// <inheritdoc />
    public partial class SeededContactTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "Email", "Fax", "LastUpdateDate", "LastUpdateUsername", "Name", "Notes", "Phone" },
                values: new object[,]
                {
                    { 1, "jramosaviles.dev@gmail.com", null, null, null, "Jose Ramos", "This is a test contact", "7876745062" },
                    { 2, "peterparker@example.com", null, null, null, "Peter Parker", "This is another test contact", "7875145265" },
                    { 3, "johndoe@example.com", null, null, null, "John Doe", "This is another test contact", "1234567890" },
                    { 4, "janesmith@example.com", null, null, null, "Jane Smith", "Yet another test contact", "9876543210" },
                    { 5, "alicejohnson@example.com", null, null, null, "Alice Johnson", "One more test contact", "5555555555" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 5);
        }
    }
}
