using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Marauders_Oasis.Data.Migrations
{
	public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Projects related to building and construction work", "Construction" },
                    { 2, "Projects related to military and defense activities", "Military" },
                    { 3, "Small-scale projects for quick tasks and services", "Small Hustle" },
                    { 4, "Projects related to logistics and transportation services", "Transportation" },
                    { 5, "Projects related to IT, software development, and technology innovations", "Technology" },
                    { 6, "Projects related to healthcare services and medical research", "Healthcare" },
                    { 7, "Projects related to educational services, tutoring, and academic research", "Education" }
                });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "CategoryId", "ContractorId", "DatePosted", "Deadline", "Description", "ExecutorId", "ImageURLs", "Location", "Price", "Status", "Title" },
                values: new object[] { new Guid("494990d4-158c-422e-b367-d8483031fa7d"), 2, new Guid("b6d43b2d-875b-4f50-a204-491fa8c5d740"), new DateTime(2023, 6, 16, 15, 9, 29, 313, DateTimeKind.Local).AddTicks(9577), null, "Need a contractor for regular maintenance of military equipment.", new Guid("f54f0ad3-04d8-4006-5c3c-08db7d698196"), null, "Washington, DC", 50000m, "Active", "Military Equipment Maintenance" });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "CategoryId", "ContractorId", "DatePosted", "Deadline", "Description", "ExecutorId", "ImageURLs", "Location", "Price", "Status", "Title" },
                values: new object[] { new Guid("53e4f6c0-9237-487a-8465-a2f34bfa6d48"), 5, new Guid("b6d43b2d-875b-4f50-a204-491fa8c5d740"), new DateTime(2023, 6, 21, 15, 9, 29, 313, DateTimeKind.Local).AddTicks(9585), null, "Need a contractor to develop a new website for our business.", new Guid("f54f0ad3-04d8-4006-5c3c-08db7d698196"), null, "Remote", 5000m, "Active", "Website Development" });

            migrationBuilder.InsertData(
                table: "Contracts",
                columns: new[] { "Id", "CategoryId", "ContractorId", "DatePosted", "Deadline", "Description", "ExecutorId", "ImageURLs", "Location", "Price", "Status", "Title" },
                values: new object[] { new Guid("9ab12237-9a72-4548-8712-7d26c2b5d47f"), 1, new Guid("b6d43b2d-875b-4f50-a204-491fa8c5d740"), new DateTime(2023, 6, 26, 15, 9, 29, 313, DateTimeKind.Local).AddTicks(9483), null, "Looking for a contractor to build a 3-bedroom residential house.", new Guid("f54f0ad3-04d8-4006-5c3c-08db7d698196"), null, "New York, NY", 250000m, "Active", "Build a Residential House" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("494990d4-158c-422e-b367-d8483031fa7d"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("53e4f6c0-9237-487a-8465-a2f34bfa6d48"));

            migrationBuilder.DeleteData(
                table: "Contracts",
                keyColumn: "Id",
                keyValue: new Guid("9ab12237-9a72-4548-8712-7d26c2b5d47f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
