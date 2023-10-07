using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstateSearch.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstateType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstateType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CityId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                    table.ForeignKey(
                        name: "FK_District_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Estate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Size = table.Column<int>(type: "INTEGER", nullable: false),
                    Rooms = table.Column<int>(type: "INTEGER", nullable: false),
                    Floor = table.Column<int>(type: "INTEGER", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    DistrictId = table.Column<Guid>(type: "TEXT", nullable: false),
                    EstateTypeId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estate_District_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "District",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estate_EstateType_EstateTypeId",
                        column: x => x.EstateTypeId,
                        principalTable: "EstateType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    EstateId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Estate_EstateId",
                        column: x => x.EstateId,
                        principalTable: "Estate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0d4538b1-0d72-492e-901d-bcc4ea1dc1cd"), "İstanbul" },
                    { new Guid("4a903eee-9463-44a5-92aa-8d351458b47a"), "Ankara" },
                    { new Guid("e97ed445-97c4-4c5d-aff3-8d09c9f60374"), "İzmir" }
                });

            migrationBuilder.InsertData(
                table: "EstateType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"), "Satılık" },
                    { new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"), "Kiralık" }
                });

            migrationBuilder.InsertData(
                table: "District",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[,]
                {
                    { new Guid("010229ba-f11e-4885-806f-8101d64f03c8"), new Guid("0d4538b1-0d72-492e-901d-bcc4ea1dc1cd"), "Beşiktaş" },
                    { new Guid("0185088d-51c3-495a-9b1d-648950633350"), new Guid("4a903eee-9463-44a5-92aa-8d351458b47a"), "Keçiören" },
                    { new Guid("17e93d84-abdb-4818-8f46-d018d018e6bf"), new Guid("e97ed445-97c4-4c5d-aff3-8d09c9f60374"), "Bornova" },
                    { new Guid("9df43b87-4e41-4776-aadf-bbeb10ef8039"), new Guid("e97ed445-97c4-4c5d-aff3-8d09c9f60374"), "Çiğli" },
                    { new Guid("ad5b20f1-6f4a-4540-a7f0-cbc81b7ef978"), new Guid("0d4538b1-0d72-492e-901d-bcc4ea1dc1cd"), "Kadıköy" },
                    { new Guid("e33bd417-10f0-4231-a278-b0adb5efc4cb"), new Guid("4a903eee-9463-44a5-92aa-8d351458b47a"), "Çankaya" }
                });

            migrationBuilder.InsertData(
                table: "Estate",
                columns: new[] { "Id", "Description", "DistrictId", "EstateTypeId", "Floor", "Price", "Rooms", "Size", "Title", "Year" },
                values: new object[,]
                {
                    { new Guid("0c6cb005-f53d-44a9-8cbc-210757f90fa7"), "Açıklama 20", new Guid("ad5b20f1-6f4a-4540-a7f0-cbc81b7ef978"), new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"), 20, 100020, 21, 120, "Emlak 20", 2030 },
                    { new Guid("0d18154e-8638-4412-a9b7-e5b6a7c0d176"), "Açıklama 23", new Guid("9df43b87-4e41-4776-aadf-bbeb10ef8039"), new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"), 23, 100023, 24, 123, "Emlak 23", 2033 },
                    { new Guid("0e196bc0-4da7-4d7b-ba01-4f5cf4bee89e"), "Açıklama 17", new Guid("010229ba-f11e-4885-806f-8101d64f03c8"), new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"), 17, 100017, 18, 117, "Emlak 17", 2027 },
                    { new Guid("17032fdc-372d-4b9e-9b7d-f9c5408ef1f0"), "Açıklama 8", new Guid("ad5b20f1-6f4a-4540-a7f0-cbc81b7ef978"), new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"), 8, 100008, 9, 108, "Emlak 8", 2018 },
                    { new Guid("1787bee8-40f6-43f8-a5bd-d9e022ed315c"), "Açıklama 12", new Guid("e33bd417-10f0-4231-a278-b0adb5efc4cb"), new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"), 12, 100012, 13, 112, "Emlak 12", 2022 },
                    { new Guid("250fed64-1d1a-4e42-a6b2-bc3b29cdeb74"), "Açıklama 1", new Guid("010229ba-f11e-4885-806f-8101d64f03c8"), new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"), 1, 100001, 2, 101, "Emlak 1", 2011 },
                    { new Guid("28b9f768-d1f9-47ba-bd09-569edf1273f4"), "Açıklama 11", new Guid("0185088d-51c3-495a-9b1d-648950633350"), new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"), 11, 100011, 12, 111, "Emlak 11", 2021 },
                    { new Guid("28d53a86-8871-4651-9f60-388116455f37"), "Açıklama 13", new Guid("010229ba-f11e-4885-806f-8101d64f03c8"), new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"), 13, 100013, 14, 113, "Emlak 13", 2023 },
                    { new Guid("386ce4c6-a810-4336-8143-df4094f2e6e3"), "Açıklama 21", new Guid("e33bd417-10f0-4231-a278-b0adb5efc4cb"), new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"), 21, 100021, 22, 121, "Emlak 21", 2031 },
                    { new Guid("3e86bdc7-c190-46e6-b43a-9af35c0a1197"), "Açıklama 22", new Guid("9df43b87-4e41-4776-aadf-bbeb10ef8039"), new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"), 22, 100022, 23, 122, "Emlak 22", 2032 },
                    { new Guid("5b2c0972-ae7e-4f81-943a-10e8f0c86ac1"), "Açıklama 6", new Guid("e33bd417-10f0-4231-a278-b0adb5efc4cb"), new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"), 6, 100006, 7, 106, "Emlak 6", 2016 },
                    { new Guid("6739cef9-a5b1-4ddd-89e8-0338faf7ddb1"), "Açıklama 7", new Guid("e33bd417-10f0-4231-a278-b0adb5efc4cb"), new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"), 7, 100007, 8, 107, "Emlak 7", 2017 },
                    { new Guid("67b8007d-5b62-4ceb-b833-5b3f70243e2a"), "Açıklama 0", new Guid("9df43b87-4e41-4776-aadf-bbeb10ef8039"), new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"), 0, 100000, 1, 100, "Emlak 0", 2010 },
                    { new Guid("68899b0b-a905-440c-902a-c2cfc91159c8"), "Açıklama 10", new Guid("17e93d84-abdb-4818-8f46-d018d018e6bf"), new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"), 10, 100010, 11, 110, "Emlak 10", 2020 },
                    { new Guid("73c63b43-047e-405a-9990-fac648900d7f"), "Açıklama 14", new Guid("17e93d84-abdb-4818-8f46-d018d018e6bf"), new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"), 14, 100014, 15, 114, "Emlak 14", 2024 },
                    { new Guid("757cde89-213d-4896-9de3-bad1b311efee"), "Açıklama 19", new Guid("010229ba-f11e-4885-806f-8101d64f03c8"), new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"), 19, 100019, 20, 119, "Emlak 19", 2029 },
                    { new Guid("7b3fb9f1-c80c-423e-9a05-4620000dab81"), "Açıklama 3", new Guid("17e93d84-abdb-4818-8f46-d018d018e6bf"), new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"), 3, 100003, 4, 103, "Emlak 3", 2013 },
                    { new Guid("80c5c29a-603f-47e9-ae37-c801591fb199"), "Açıklama 9", new Guid("9df43b87-4e41-4776-aadf-bbeb10ef8039"), new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"), 9, 100009, 10, 109, "Emlak 9", 2019 },
                    { new Guid("820af93f-1270-48f1-a9c9-ad16dd198a12"), "Açıklama 2", new Guid("0185088d-51c3-495a-9b1d-648950633350"), new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"), 2, 100002, 3, 102, "Emlak 2", 2012 },
                    { new Guid("84f560ef-847d-499f-a99e-2c45529943f3"), "Açıklama 4", new Guid("9df43b87-4e41-4776-aadf-bbeb10ef8039"), new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"), 4, 100004, 5, 104, "Emlak 4", 2014 },
                    { new Guid("ba9e026d-702d-47db-8057-d629d7ca7f5b"), "Açıklama 18", new Guid("0185088d-51c3-495a-9b1d-648950633350"), new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"), 18, 100018, 19, 118, "Emlak 18", 2028 },
                    { new Guid("e9b2e052-f426-45da-a9fe-d2ba400b08c9"), "Açıklama 15", new Guid("9df43b87-4e41-4776-aadf-bbeb10ef8039"), new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"), 15, 100015, 16, 115, "Emlak 15", 2025 },
                    { new Guid("fe9ac054-4c86-4174-a675-5e4786950349"), "Açıklama 5", new Guid("e33bd417-10f0-4231-a278-b0adb5efc4cb"), new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"), 5, 100005, 6, 105, "Emlak 5", 2015 },
                    { new Guid("ff3b8131-5e0a-4f5f-b3d3-a9ab4a05c783"), "Açıklama 16", new Guid("9df43b87-4e41-4776-aadf-bbeb10ef8039"), new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"), 16, 100016, 17, 116, "Emlak 16", 2026 }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "EstateId", "Url" },
                values: new object[,]
                {
                    { new Guid("04cbcab9-95a0-4bbb-8142-ee9b52809101"), new Guid("e9b2e052-f426-45da-a9fe-d2ba400b08c9"), "https://placehold.co/600x400" },
                    { new Guid("08209a02-a475-4b86-be9f-208ce5d39f0e"), new Guid("6739cef9-a5b1-4ddd-89e8-0338faf7ddb1"), "https://placehold.co/600x400" },
                    { new Guid("09590428-39c4-4d8c-b368-bb2342d96652"), new Guid("17032fdc-372d-4b9e-9b7d-f9c5408ef1f0"), "https://placehold.co/600x400" },
                    { new Guid("0a13c5e9-4a8b-4bb8-a989-86e171511d8f"), new Guid("68899b0b-a905-440c-902a-c2cfc91159c8"), "https://placehold.co/600x400" },
                    { new Guid("0ad42867-219b-4e41-b8ca-e1e14a0233cf"), new Guid("250fed64-1d1a-4e42-a6b2-bc3b29cdeb74"), "https://placehold.co/600x400" },
                    { new Guid("0bd1f531-663d-419b-a76b-692c8acc25e7"), new Guid("fe9ac054-4c86-4174-a675-5e4786950349"), "https://placehold.co/600x400" },
                    { new Guid("1130292c-2b8c-4f4e-ab89-91f59c4363c4"), new Guid("7b3fb9f1-c80c-423e-9a05-4620000dab81"), "https://placehold.co/600x400" },
                    { new Guid("13850764-3023-4feb-9292-00a30e598020"), new Guid("0c6cb005-f53d-44a9-8cbc-210757f90fa7"), "https://placehold.co/600x400" },
                    { new Guid("2492cb3c-dd9c-4757-a31e-40c331e45d43"), new Guid("0e196bc0-4da7-4d7b-ba01-4f5cf4bee89e"), "https://placehold.co/600x400" },
                    { new Guid("24fbadf6-cb6c-4ae3-a952-042559d19e20"), new Guid("ff3b8131-5e0a-4f5f-b3d3-a9ab4a05c783"), "https://placehold.co/600x400" },
                    { new Guid("37bc67a0-7646-479f-a576-5a6dd5aa80e8"), new Guid("fe9ac054-4c86-4174-a675-5e4786950349"), "https://placehold.co/300x200" },
                    { new Guid("392aa088-37d5-431d-b48e-f53784eef5f2"), new Guid("84f560ef-847d-499f-a99e-2c45529943f3"), "https://placehold.co/300x200" },
                    { new Guid("3c8aea1d-f621-4a2e-a650-8f83d0a6c5ff"), new Guid("ff3b8131-5e0a-4f5f-b3d3-a9ab4a05c783"), "https://placehold.co/300x200" },
                    { new Guid("3cf5ad01-3e9f-4652-949d-a96639c2d42e"), new Guid("757cde89-213d-4896-9de3-bad1b311efee"), "https://placehold.co/300x200" },
                    { new Guid("3ef0fbe6-6f7a-4580-8f05-0be6fc0a7f6c"), new Guid("e9b2e052-f426-45da-a9fe-d2ba400b08c9"), "https://placehold.co/300x200" },
                    { new Guid("45ff8efd-3c15-4b89-91bb-0b59801d1b7e"), new Guid("73c63b43-047e-405a-9990-fac648900d7f"), "https://placehold.co/300x200" },
                    { new Guid("4ccc0010-26f6-4669-95e8-cb0d4231a278"), new Guid("0e196bc0-4da7-4d7b-ba01-4f5cf4bee89e"), "https://placehold.co/300x200" },
                    { new Guid("5039be6a-e90c-4986-b7b4-a9cd4d49b7ba"), new Guid("1787bee8-40f6-43f8-a5bd-d9e022ed315c"), "https://placehold.co/300x200" },
                    { new Guid("5079f7b4-5d2d-4cf2-ab77-37a558d6d3e9"), new Guid("67b8007d-5b62-4ceb-b833-5b3f70243e2a"), "https://placehold.co/300x200" },
                    { new Guid("59321c66-7f33-42f0-ba2a-53c99dc76f4f"), new Guid("ba9e026d-702d-47db-8057-d629d7ca7f5b"), "https://placehold.co/600x400" },
                    { new Guid("5f86e845-6c76-4e5a-8e51-4b373b602424"), new Guid("386ce4c6-a810-4336-8143-df4094f2e6e3"), "https://placehold.co/300x200" },
                    { new Guid("60c25d2c-0ec2-4486-91dc-2b7e60332adb"), new Guid("0d18154e-8638-4412-a9b7-e5b6a7c0d176"), "https://placehold.co/300x200" },
                    { new Guid("646c2dd2-dd44-41ae-88cc-d5ad12315429"), new Guid("386ce4c6-a810-4336-8143-df4094f2e6e3"), "https://placehold.co/600x400" },
                    { new Guid("65fc1306-5aeb-466a-8cfa-7d1b7eabd350"), new Guid("84f560ef-847d-499f-a99e-2c45529943f3"), "https://placehold.co/600x400" },
                    { new Guid("7876ed3d-101e-4666-a1a7-7c7f9299bd3e"), new Guid("5b2c0972-ae7e-4f81-943a-10e8f0c86ac1"), "https://placehold.co/600x400" },
                    { new Guid("7f70cccd-aaa8-4398-89e0-65147cb4043f"), new Guid("73c63b43-047e-405a-9990-fac648900d7f"), "https://placehold.co/600x400" },
                    { new Guid("8578dc8b-2b17-4ba6-a06b-42d3149ee286"), new Guid("3e86bdc7-c190-46e6-b43a-9af35c0a1197"), "https://placehold.co/600x400" },
                    { new Guid("85caba17-8542-419d-b007-43315b573b3f"), new Guid("ba9e026d-702d-47db-8057-d629d7ca7f5b"), "https://placehold.co/300x200" },
                    { new Guid("86cce853-b79a-4806-875e-89049cf6d8ab"), new Guid("0d18154e-8638-4412-a9b7-e5b6a7c0d176"), "https://placehold.co/600x400" },
                    { new Guid("8be94df3-ce5d-4f2c-8e6b-ea5f876aa869"), new Guid("7b3fb9f1-c80c-423e-9a05-4620000dab81"), "https://placehold.co/300x200" },
                    { new Guid("955a7dc1-f0c5-4595-b33d-0b2c7c0c3a98"), new Guid("1787bee8-40f6-43f8-a5bd-d9e022ed315c"), "https://placehold.co/600x400" },
                    { new Guid("9842721d-7409-496a-b6e0-a49230711e67"), new Guid("80c5c29a-603f-47e9-ae37-c801591fb199"), "https://placehold.co/300x200" },
                    { new Guid("9a08bc83-229e-4ba7-9aae-a58dc7d113a0"), new Guid("68899b0b-a905-440c-902a-c2cfc91159c8"), "https://placehold.co/300x200" },
                    { new Guid("9c132cd4-2a02-4d96-bfbd-121f9bcf15a5"), new Guid("3e86bdc7-c190-46e6-b43a-9af35c0a1197"), "https://placehold.co/300x200" },
                    { new Guid("9ed4deff-a1e7-4aaf-b3be-46b8d5641a5c"), new Guid("757cde89-213d-4896-9de3-bad1b311efee"), "https://placehold.co/600x400" },
                    { new Guid("a8ae1c35-58ca-48b6-9706-c75a0b644a81"), new Guid("28d53a86-8871-4651-9f60-388116455f37"), "https://placehold.co/300x200" },
                    { new Guid("acd36693-dd91-4d24-a645-19737b32db1d"), new Guid("17032fdc-372d-4b9e-9b7d-f9c5408ef1f0"), "https://placehold.co/300x200" },
                    { new Guid("ce1c94bc-cdf1-4c63-a507-e2c68f581c34"), new Guid("0c6cb005-f53d-44a9-8cbc-210757f90fa7"), "https://placehold.co/300x200" },
                    { new Guid("d0f28af8-3ef3-45e1-a154-1946e621e133"), new Guid("820af93f-1270-48f1-a9c9-ad16dd198a12"), "https://placehold.co/600x400" },
                    { new Guid("d7efd08e-3cca-4749-b9e3-119a056f0d0b"), new Guid("67b8007d-5b62-4ceb-b833-5b3f70243e2a"), "https://placehold.co/600x400" },
                    { new Guid("dd2374ed-1eaa-4ce9-a925-227c09388d7a"), new Guid("820af93f-1270-48f1-a9c9-ad16dd198a12"), "https://placehold.co/300x200" },
                    { new Guid("debdd5fd-87e0-495a-96db-38da2cff8712"), new Guid("28d53a86-8871-4651-9f60-388116455f37"), "https://placehold.co/600x400" },
                    { new Guid("ea4f949b-7d43-40e3-b105-060db7712760"), new Guid("6739cef9-a5b1-4ddd-89e8-0338faf7ddb1"), "https://placehold.co/300x200" },
                    { new Guid("ea951cb5-f775-47fa-99fa-9accffaf30e7"), new Guid("80c5c29a-603f-47e9-ae37-c801591fb199"), "https://placehold.co/600x400" },
                    { new Guid("f46758db-9f42-47f0-8bd2-8c757cbadb31"), new Guid("5b2c0972-ae7e-4f81-943a-10e8f0c86ac1"), "https://placehold.co/300x200" },
                    { new Guid("fb13006e-5fbf-4987-9ee5-02205cf7dd35"), new Guid("28b9f768-d1f9-47ba-bd09-569edf1273f4"), "https://placehold.co/600x400" },
                    { new Guid("fde63543-4941-414d-8662-67fe66bdbc35"), new Guid("250fed64-1d1a-4e42-a6b2-bc3b29cdeb74"), "https://placehold.co/300x200" },
                    { new Guid("fe3ab537-e856-4427-bcf0-471b6730f65d"), new Guid("28b9f768-d1f9-47ba-bd09-569edf1273f4"), "https://placehold.co/300x200" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_District_CityId",
                table: "District",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Estate_DistrictId",
                table: "Estate",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Estate_EstateTypeId",
                table: "Estate",
                column: "EstateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_EstateId",
                table: "Image",
                column: "EstateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Estate");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "EstateType");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
