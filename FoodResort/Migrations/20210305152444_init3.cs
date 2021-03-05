using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodResort.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "Id", "Body", "Created", "Title" },
                values: new object[] { new Guid("ed8ab516-6b92-4d6d-85c8-6eed376f6334"), "Lorem ipsum", new DateTime(2021, 3, 5, 16, 24, 43, 824, DateTimeKind.Local).AddTicks(7895), "About" });

            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "Id", "Body", "Created", "Title" },
                values: new object[] { new Guid("be836d12-7657-435e-8f3e-f1f891f97549"), "Lorem ipsum", new DateTime(2021, 3, 5, 16, 24, 43, 830, DateTimeKind.Local).AddTicks(7502), "FAQ" });

            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "Id", "Body", "Created", "Title" },
                values: new object[] { new Guid("5a48fea0-ea31-4f4a-81ce-a0176a24b99d"), "Lorem ipsum", new DateTime(2021, 3, 5, 16, 24, 43, 830, DateTimeKind.Local).AddTicks(7752), "Contact" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: new Guid("5a48fea0-ea31-4f4a-81ce-a0176a24b99d"));

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: new Guid("be836d12-7657-435e-8f3e-f1f891f97549"));

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: new Guid("ed8ab516-6b92-4d6d-85c8-6eed376f6334"));
        }
    }
}
