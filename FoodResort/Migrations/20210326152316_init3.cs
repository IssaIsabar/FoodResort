using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodResort.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: "1f95db7c-657e-42fb-9530-5a982b6ac28b");

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: "29962815-91d9-4d4a-8eba-a928d03bf31b");

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: "7f59fc2b-b59a-4d6f-93d2-b493f9b7d35e");

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: "3a375a33-43ef-4b99-aac2-8d707216b74c");

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: "3dfea4fd-6cd1-4c3e-89c7-105986959217");

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: "6050ee60-2297-49f8-ab94-5e57c2c7e7f4");

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: "9bff0cb5-e4cf-4e14-8ced-471ec79f5ae5");

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: "cd65028f-00cb-4235-a9fb-c90dbf270462");

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: "d9c82392-a75b-4f26-9b4d-23dd7a10270f");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "14ef867d-bee1-4a54-8d68-8aa2afa21418");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c69f7c52-cff6-4439-9e88-bbe40f5aaf0e");

            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "Id", "Body", "Created", "Title" },
                values: new object[,]
                {
                    { "7e73f5f4-c09a-4704-bc2e-9d96a20ee2ce", "Lorem ipsum", new DateTime(2021, 3, 26, 16, 23, 15, 863, DateTimeKind.Local).AddTicks(1244), "About" },
                    { "6d771b6e-cbd6-488b-9296-96b5f5a199ba", "Lorem ipsum", new DateTime(2021, 3, 26, 16, 23, 15, 866, DateTimeKind.Local).AddTicks(7544), "FAQ" },
                    { "3e2134a5-b940-4d0d-9932-8a2cf23a9eb1", "Lorem ipsum", new DateTime(2021, 3, 26, 16, 23, 15, 866, DateTimeKind.Local).AddTicks(7661), "Contact" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Created", "Description", "ImageUrl", "Name", "Rating", "Street", "ZipCode" },
                values: new object[,]
                {
                    { "740fd9d5-72a2-444a-86fc-e1becb25b2ea", "", new DateTime(2021, 3, 26, 16, 23, 15, 868, DateTimeKind.Local).AddTicks(3504), "McDonald's Corporation is an American fast food company, founded in 1940 as a restaurant operated by Richard and Maurice McDonald, in San Bernardino, California, United States.", "https://www.qsrmagazine.com/sites/default/files/styles/story_page/public/story/mcdonalds-getting-even-more-serious-about-tech.jpg", "McDonald's", 0.0, "", "" },
                    { "4d25ad8c-e95f-4d21-9acd-4b9a7afa891d", "", new DateTime(2021, 3, 26, 16, 23, 15, 869, DateTimeKind.Local).AddTicks(2520), "Burger King is an American multinational chain of hamburger fast food restaurants. Headquartered in Miami-Dade County, Florida, the company was founded in 1953 as Insta-Burger King, a Jacksonville, Florida–based restaurant chain.", "https://www.fastighetsvarlden.se/wp-content/uploads/2019/01/fv-burger-king.jpg", "Burger King", 0.0, "", "" },
                    { "fff9ffe7-a732-46b0-9e7a-b3312a9fdfdc", "", new DateTime(2021, 3, 26, 16, 23, 15, 869, DateTimeKind.Local).AddTicks(2613), "Max Burgers Aktiebolag, earlier Max Hamburgerrestauranger AB, is a fast food corporation from Sweden.", "https://www.max.se/contentassets/1b89f49ce6974a1a86271668c1406db4/restaurantstockholm-ulvsundavagen.png", "Max", 0.0, "", "" },
                    { "c8f41ec5-2464-4e28-a369-49044a22df61", "", new DateTime(2021, 3, 26, 16, 23, 15, 869, DateTimeKind.Local).AddTicks(2641), "Subway is an American fast food restaurant franchise that primarily sells submarine sandwiches, salads and beverages. It was founded by the 17 year old Fred DeLuca and financed by Peter Buck in 1965 as Pete's Super Submarines in Bridgeport, Connecticut", "https://insidefmcg.com.au/wp-content/uploads/2020/11/Subway7.jpg", "Subway", 0.0, "", "" },
                    { "627c5f8e-0c99-445d-8689-63646387d25b", "", new DateTime(2021, 3, 26, 16, 23, 15, 869, DateTimeKind.Local).AddTicks(2665), "Pizza Hut is an American restaurant chain and international franchise founded in 1958 in Wichita, Kansas by Dan and Frank Carney. It provides pizza and other Italian-American dishes, including pasta, side dishes and desserts.", "https://1.bp.blogspot.com/-fXQqW5OlBwY/Wzm4v7YZ2gI/AAAAAAABA0w/TaEGHb5vSqEld1xm2M9ia1QQuPj7-qzbgCKgBGAs/s1600/20180701_172010.jpg", "Pizza hut", 0.0, "", "" },
                    { "757d518b-a271-452d-91a0-8c047ee042c5", "", new DateTime(2021, 3, 26, 16, 23, 15, 869, DateTimeKind.Local).AddTicks(2696), "KFC is an American fast food restaurant chain headquartered in Louisville, Kentucky, that specializes in fried chicken. It is the world's second-largest restaurant chain after McDonald's, with 22,621 locations globally in 150 countries as of December 2019. The chain is a subsidiary of Yum!", "https://3kytnw3txc4d32157aq3xvd1-wpengine.netdna-ssl.com/wp-content/uploads/2018/01/kfc-snabbmatsrestaurang-foto-kfc-465x312.jpg", "KFC", 0.0, "", "" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a64e851c-dc86-4180-821c-4ddfa90d354c", "f5ea6d4d-b869-40a3-bf01-44a2458f2c13", "Admin", "ADMIN" },
                    { "d8d32131-d2cf-40a8-89a5-d295979ed041", "e511f388-c7d0-4f24-ac6d-69621c82581c", "User", "USER" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: "3e2134a5-b940-4d0d-9932-8a2cf23a9eb1");

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: "6d771b6e-cbd6-488b-9296-96b5f5a199ba");

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "Id",
                keyValue: "7e73f5f4-c09a-4704-bc2e-9d96a20ee2ce");

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: "4d25ad8c-e95f-4d21-9acd-4b9a7afa891d");

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: "627c5f8e-0c99-445d-8689-63646387d25b");

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: "740fd9d5-72a2-444a-86fc-e1becb25b2ea");

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: "757d518b-a271-452d-91a0-8c047ee042c5");

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: "c8f41ec5-2464-4e28-a369-49044a22df61");

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "Id",
                keyValue: "fff9ffe7-a732-46b0-9e7a-b3312a9fdfdc");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "a64e851c-dc86-4180-821c-4ddfa90d354c");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d8d32131-d2cf-40a8-89a5-d295979ed041");

            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "Id", "Body", "Created", "Title" },
                values: new object[,]
                {
                    { "7f59fc2b-b59a-4d6f-93d2-b493f9b7d35e", "Lorem ipsum", new DateTime(2021, 3, 26, 16, 3, 7, 689, DateTimeKind.Local).AddTicks(726), "About" },
                    { "1f95db7c-657e-42fb-9530-5a982b6ac28b", "Lorem ipsum", new DateTime(2021, 3, 26, 16, 3, 7, 692, DateTimeKind.Local).AddTicks(5734), "FAQ" },
                    { "29962815-91d9-4d4a-8eba-a928d03bf31b", "Lorem ipsum", new DateTime(2021, 3, 26, 16, 3, 7, 692, DateTimeKind.Local).AddTicks(5859), "Contact" }
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "Created", "Description", "ImageUrl", "Name", "Rating", "Street", "ZipCode" },
                values: new object[,]
                {
                    { "cd65028f-00cb-4235-a9fb-c90dbf270462", "", new DateTime(2021, 3, 26, 16, 3, 7, 692, DateTimeKind.Local).AddTicks(7720), "McDonald's Corporation is an American fast food company, founded in 1940 as a restaurant operated by Richard and Maurice McDonald, in San Bernardino, California, United States.", "https://www.qsrmagazine.com/sites/default/files/styles/story_page/public/story/mcdonalds-getting-even-more-serious-about-tech.jpg", "McDonald's", 0.0, "", "" },
                    { "6050ee60-2297-49f8-ab94-5e57c2c7e7f4", "", new DateTime(2021, 3, 26, 16, 3, 7, 693, DateTimeKind.Local).AddTicks(1948), "Burger King is an American multinational chain of hamburger fast food restaurants. Headquartered in Miami-Dade County, Florida, the company was founded in 1953 as Insta-Burger King, a Jacksonville, Florida–based restaurant chain.", "https://www.fastighetsvarlden.se/wp-content/uploads/2019/01/fv-burger-king.jpg", "Burger King", 0.0, "", "" },
                    { "9bff0cb5-e4cf-4e14-8ced-471ec79f5ae5", "", new DateTime(2021, 3, 26, 16, 3, 7, 693, DateTimeKind.Local).AddTicks(2001), "Max Burgers Aktiebolag, earlier Max Hamburgerrestauranger AB, is a fast food corporation from Sweden.", "https://www.max.se/contentassets/1b89f49ce6974a1a86271668c1406db4/restaurantstockholm-ulvsundavagen.png", "Max", 0.0, "", "" },
                    { "3a375a33-43ef-4b99-aac2-8d707216b74c", "", new DateTime(2021, 3, 26, 16, 3, 7, 693, DateTimeKind.Local).AddTicks(2027), "Subway is an American fast food restaurant franchise that primarily sells submarine sandwiches, salads and beverages. It was founded by the 17 year old Fred DeLuca and financed by Peter Buck in 1965 as Pete's Super Submarines in Bridgeport, Connecticut", "https://insidefmcg.com.au/wp-content/uploads/2020/11/Subway7.jpg", "Subway", 0.0, "", "" },
                    { "d9c82392-a75b-4f26-9b4d-23dd7a10270f", "", new DateTime(2021, 3, 26, 16, 3, 7, 693, DateTimeKind.Local).AddTicks(2069), "Pizza Hut is an American restaurant chain and international franchise founded in 1958 in Wichita, Kansas by Dan and Frank Carney. It provides pizza and other Italian-American dishes, including pasta, side dishes and desserts.", "https://1.bp.blogspot.com/-fXQqW5OlBwY/Wzm4v7YZ2gI/AAAAAAABA0w/TaEGHb5vSqEld1xm2M9ia1QQuPj7-qzbgCKgBGAs/s1600/20180701_172010.jpg", "Pizza hut", 0.0, "", "" },
                    { "3dfea4fd-6cd1-4c3e-89c7-105986959217", "", new DateTime(2021, 3, 26, 16, 3, 7, 693, DateTimeKind.Local).AddTicks(2098), "KFC is an American fast food restaurant chain headquartered in Louisville, Kentucky, that specializes in fried chicken. It is the world's second-largest restaurant chain after McDonald's, with 22,621 locations globally in 150 countries as of December 2019. The chain is a subsidiary of Yum!", "https://3kytnw3txc4d32157aq3xvd1-wpengine.netdna-ssl.com/wp-content/uploads/2018/01/kfc-snabbmatsrestaurang-foto-kfc-465x312.jpg", "KFC", 0.0, "", "" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c69f7c52-cff6-4439-9e88-bbe40f5aaf0e", "cdc96fab-38f2-4ee2-ad79-36af8ed5c66c", "Admin", "ADMIN" },
                    { "14ef867d-bee1-4a54-8d68-8aa2afa21418", "2a5e3acb-ec86-4ec8-9824-7d75c5046897", "Customer", "CUSTOMER" }
                });
        }
    }
}
