﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealEstateSearch.Models;

#nullable disable

namespace RealEstateSearch.Migrations
{
    [DbContext(typeof(EstateContext))]
    [Migration("20231007150600_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("RealEstateSearch.Models.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0d4538b1-0d72-492e-901d-bcc4ea1dc1cd"),
                            Name = "İstanbul"
                        },
                        new
                        {
                            Id = new Guid("4a903eee-9463-44a5-92aa-8d351458b47a"),
                            Name = "Ankara"
                        },
                        new
                        {
                            Id = new Guid("e97ed445-97c4-4c5d-aff3-8d09c9f60374"),
                            Name = "İzmir"
                        });
                });

            modelBuilder.Entity("RealEstateSearch.Models.District", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CityId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("District");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ad5b20f1-6f4a-4540-a7f0-cbc81b7ef978"),
                            CityId = new Guid("0d4538b1-0d72-492e-901d-bcc4ea1dc1cd"),
                            Name = "Kadıköy"
                        },
                        new
                        {
                            Id = new Guid("010229ba-f11e-4885-806f-8101d64f03c8"),
                            CityId = new Guid("0d4538b1-0d72-492e-901d-bcc4ea1dc1cd"),
                            Name = "Beşiktaş"
                        },
                        new
                        {
                            Id = new Guid("e33bd417-10f0-4231-a278-b0adb5efc4cb"),
                            CityId = new Guid("4a903eee-9463-44a5-92aa-8d351458b47a"),
                            Name = "Çankaya"
                        },
                        new
                        {
                            Id = new Guid("0185088d-51c3-495a-9b1d-648950633350"),
                            CityId = new Guid("4a903eee-9463-44a5-92aa-8d351458b47a"),
                            Name = "Keçiören"
                        },
                        new
                        {
                            Id = new Guid("17e93d84-abdb-4818-8f46-d018d018e6bf"),
                            CityId = new Guid("e97ed445-97c4-4c5d-aff3-8d09c9f60374"),
                            Name = "Bornova"
                        },
                        new
                        {
                            Id = new Guid("9df43b87-4e41-4776-aadf-bbeb10ef8039"),
                            CityId = new Guid("e97ed445-97c4-4c5d-aff3-8d09c9f60374"),
                            Name = "Çiğli"
                        });
                });

            modelBuilder.Entity("RealEstateSearch.Models.Estate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DistrictId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EstateTypeId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Floor")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rooms")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.HasIndex("EstateTypeId");

                    b.ToTable("Estate");

                    b.HasData(
                        new
                        {
                            Id = new Guid("67b8007d-5b62-4ceb-b833-5b3f70243e2a"),
                            Description = "Açıklama 0",
                            DistrictId = new Guid("9df43b87-4e41-4776-aadf-bbeb10ef8039"),
                            EstateTypeId = new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"),
                            Floor = 0,
                            Price = 100000,
                            Rooms = 1,
                            Size = 100,
                            Title = "Emlak 0",
                            Year = 2010
                        },
                        new
                        {
                            Id = new Guid("250fed64-1d1a-4e42-a6b2-bc3b29cdeb74"),
                            Description = "Açıklama 1",
                            DistrictId = new Guid("010229ba-f11e-4885-806f-8101d64f03c8"),
                            EstateTypeId = new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"),
                            Floor = 1,
                            Price = 100001,
                            Rooms = 2,
                            Size = 101,
                            Title = "Emlak 1",
                            Year = 2011
                        },
                        new
                        {
                            Id = new Guid("820af93f-1270-48f1-a9c9-ad16dd198a12"),
                            Description = "Açıklama 2",
                            DistrictId = new Guid("0185088d-51c3-495a-9b1d-648950633350"),
                            EstateTypeId = new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"),
                            Floor = 2,
                            Price = 100002,
                            Rooms = 3,
                            Size = 102,
                            Title = "Emlak 2",
                            Year = 2012
                        },
                        new
                        {
                            Id = new Guid("7b3fb9f1-c80c-423e-9a05-4620000dab81"),
                            Description = "Açıklama 3",
                            DistrictId = new Guid("17e93d84-abdb-4818-8f46-d018d018e6bf"),
                            EstateTypeId = new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"),
                            Floor = 3,
                            Price = 100003,
                            Rooms = 4,
                            Size = 103,
                            Title = "Emlak 3",
                            Year = 2013
                        },
                        new
                        {
                            Id = new Guid("84f560ef-847d-499f-a99e-2c45529943f3"),
                            Description = "Açıklama 4",
                            DistrictId = new Guid("9df43b87-4e41-4776-aadf-bbeb10ef8039"),
                            EstateTypeId = new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"),
                            Floor = 4,
                            Price = 100004,
                            Rooms = 5,
                            Size = 104,
                            Title = "Emlak 4",
                            Year = 2014
                        },
                        new
                        {
                            Id = new Guid("fe9ac054-4c86-4174-a675-5e4786950349"),
                            Description = "Açıklama 5",
                            DistrictId = new Guid("e33bd417-10f0-4231-a278-b0adb5efc4cb"),
                            EstateTypeId = new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"),
                            Floor = 5,
                            Price = 100005,
                            Rooms = 6,
                            Size = 105,
                            Title = "Emlak 5",
                            Year = 2015
                        },
                        new
                        {
                            Id = new Guid("5b2c0972-ae7e-4f81-943a-10e8f0c86ac1"),
                            Description = "Açıklama 6",
                            DistrictId = new Guid("e33bd417-10f0-4231-a278-b0adb5efc4cb"),
                            EstateTypeId = new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"),
                            Floor = 6,
                            Price = 100006,
                            Rooms = 7,
                            Size = 106,
                            Title = "Emlak 6",
                            Year = 2016
                        },
                        new
                        {
                            Id = new Guid("6739cef9-a5b1-4ddd-89e8-0338faf7ddb1"),
                            Description = "Açıklama 7",
                            DistrictId = new Guid("e33bd417-10f0-4231-a278-b0adb5efc4cb"),
                            EstateTypeId = new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"),
                            Floor = 7,
                            Price = 100007,
                            Rooms = 8,
                            Size = 107,
                            Title = "Emlak 7",
                            Year = 2017
                        },
                        new
                        {
                            Id = new Guid("17032fdc-372d-4b9e-9b7d-f9c5408ef1f0"),
                            Description = "Açıklama 8",
                            DistrictId = new Guid("ad5b20f1-6f4a-4540-a7f0-cbc81b7ef978"),
                            EstateTypeId = new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"),
                            Floor = 8,
                            Price = 100008,
                            Rooms = 9,
                            Size = 108,
                            Title = "Emlak 8",
                            Year = 2018
                        },
                        new
                        {
                            Id = new Guid("80c5c29a-603f-47e9-ae37-c801591fb199"),
                            Description = "Açıklama 9",
                            DistrictId = new Guid("9df43b87-4e41-4776-aadf-bbeb10ef8039"),
                            EstateTypeId = new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"),
                            Floor = 9,
                            Price = 100009,
                            Rooms = 10,
                            Size = 109,
                            Title = "Emlak 9",
                            Year = 2019
                        },
                        new
                        {
                            Id = new Guid("68899b0b-a905-440c-902a-c2cfc91159c8"),
                            Description = "Açıklama 10",
                            DistrictId = new Guid("17e93d84-abdb-4818-8f46-d018d018e6bf"),
                            EstateTypeId = new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"),
                            Floor = 10,
                            Price = 100010,
                            Rooms = 11,
                            Size = 110,
                            Title = "Emlak 10",
                            Year = 2020
                        },
                        new
                        {
                            Id = new Guid("28b9f768-d1f9-47ba-bd09-569edf1273f4"),
                            Description = "Açıklama 11",
                            DistrictId = new Guid("0185088d-51c3-495a-9b1d-648950633350"),
                            EstateTypeId = new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"),
                            Floor = 11,
                            Price = 100011,
                            Rooms = 12,
                            Size = 111,
                            Title = "Emlak 11",
                            Year = 2021
                        },
                        new
                        {
                            Id = new Guid("1787bee8-40f6-43f8-a5bd-d9e022ed315c"),
                            Description = "Açıklama 12",
                            DistrictId = new Guid("e33bd417-10f0-4231-a278-b0adb5efc4cb"),
                            EstateTypeId = new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"),
                            Floor = 12,
                            Price = 100012,
                            Rooms = 13,
                            Size = 112,
                            Title = "Emlak 12",
                            Year = 2022
                        },
                        new
                        {
                            Id = new Guid("28d53a86-8871-4651-9f60-388116455f37"),
                            Description = "Açıklama 13",
                            DistrictId = new Guid("010229ba-f11e-4885-806f-8101d64f03c8"),
                            EstateTypeId = new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"),
                            Floor = 13,
                            Price = 100013,
                            Rooms = 14,
                            Size = 113,
                            Title = "Emlak 13",
                            Year = 2023
                        },
                        new
                        {
                            Id = new Guid("73c63b43-047e-405a-9990-fac648900d7f"),
                            Description = "Açıklama 14",
                            DistrictId = new Guid("17e93d84-abdb-4818-8f46-d018d018e6bf"),
                            EstateTypeId = new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"),
                            Floor = 14,
                            Price = 100014,
                            Rooms = 15,
                            Size = 114,
                            Title = "Emlak 14",
                            Year = 2024
                        },
                        new
                        {
                            Id = new Guid("e9b2e052-f426-45da-a9fe-d2ba400b08c9"),
                            Description = "Açıklama 15",
                            DistrictId = new Guid("9df43b87-4e41-4776-aadf-bbeb10ef8039"),
                            EstateTypeId = new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"),
                            Floor = 15,
                            Price = 100015,
                            Rooms = 16,
                            Size = 115,
                            Title = "Emlak 15",
                            Year = 2025
                        },
                        new
                        {
                            Id = new Guid("ff3b8131-5e0a-4f5f-b3d3-a9ab4a05c783"),
                            Description = "Açıklama 16",
                            DistrictId = new Guid("9df43b87-4e41-4776-aadf-bbeb10ef8039"),
                            EstateTypeId = new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"),
                            Floor = 16,
                            Price = 100016,
                            Rooms = 17,
                            Size = 116,
                            Title = "Emlak 16",
                            Year = 2026
                        },
                        new
                        {
                            Id = new Guid("0e196bc0-4da7-4d7b-ba01-4f5cf4bee89e"),
                            Description = "Açıklama 17",
                            DistrictId = new Guid("010229ba-f11e-4885-806f-8101d64f03c8"),
                            EstateTypeId = new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"),
                            Floor = 17,
                            Price = 100017,
                            Rooms = 18,
                            Size = 117,
                            Title = "Emlak 17",
                            Year = 2027
                        },
                        new
                        {
                            Id = new Guid("ba9e026d-702d-47db-8057-d629d7ca7f5b"),
                            Description = "Açıklama 18",
                            DistrictId = new Guid("0185088d-51c3-495a-9b1d-648950633350"),
                            EstateTypeId = new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"),
                            Floor = 18,
                            Price = 100018,
                            Rooms = 19,
                            Size = 118,
                            Title = "Emlak 18",
                            Year = 2028
                        },
                        new
                        {
                            Id = new Guid("757cde89-213d-4896-9de3-bad1b311efee"),
                            Description = "Açıklama 19",
                            DistrictId = new Guid("010229ba-f11e-4885-806f-8101d64f03c8"),
                            EstateTypeId = new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"),
                            Floor = 19,
                            Price = 100019,
                            Rooms = 20,
                            Size = 119,
                            Title = "Emlak 19",
                            Year = 2029
                        },
                        new
                        {
                            Id = new Guid("0c6cb005-f53d-44a9-8cbc-210757f90fa7"),
                            Description = "Açıklama 20",
                            DistrictId = new Guid("ad5b20f1-6f4a-4540-a7f0-cbc81b7ef978"),
                            EstateTypeId = new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"),
                            Floor = 20,
                            Price = 100020,
                            Rooms = 21,
                            Size = 120,
                            Title = "Emlak 20",
                            Year = 2030
                        },
                        new
                        {
                            Id = new Guid("386ce4c6-a810-4336-8143-df4094f2e6e3"),
                            Description = "Açıklama 21",
                            DistrictId = new Guid("e33bd417-10f0-4231-a278-b0adb5efc4cb"),
                            EstateTypeId = new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"),
                            Floor = 21,
                            Price = 100021,
                            Rooms = 22,
                            Size = 121,
                            Title = "Emlak 21",
                            Year = 2031
                        },
                        new
                        {
                            Id = new Guid("3e86bdc7-c190-46e6-b43a-9af35c0a1197"),
                            Description = "Açıklama 22",
                            DistrictId = new Guid("9df43b87-4e41-4776-aadf-bbeb10ef8039"),
                            EstateTypeId = new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"),
                            Floor = 22,
                            Price = 100022,
                            Rooms = 23,
                            Size = 122,
                            Title = "Emlak 22",
                            Year = 2032
                        },
                        new
                        {
                            Id = new Guid("0d18154e-8638-4412-a9b7-e5b6a7c0d176"),
                            Description = "Açıklama 23",
                            DistrictId = new Guid("9df43b87-4e41-4776-aadf-bbeb10ef8039"),
                            EstateTypeId = new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"),
                            Floor = 23,
                            Price = 100023,
                            Rooms = 24,
                            Size = 123,
                            Title = "Emlak 23",
                            Year = 2033
                        });
                });

            modelBuilder.Entity("RealEstateSearch.Models.EstateType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EstateType");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00350bd7-6dac-4fb3-b47d-73ad27999565"),
                            Name = "Satılık"
                        },
                        new
                        {
                            Id = new Guid("b3e8f5bd-d1ad-438b-a076-a14ab3904e17"),
                            Name = "Kiralık"
                        });
                });

            modelBuilder.Entity("RealEstateSearch.Models.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EstateId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EstateId");

                    b.ToTable("Image");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5079f7b4-5d2d-4cf2-ab77-37a558d6d3e9"),
                            EstateId = new Guid("67b8007d-5b62-4ceb-b833-5b3f70243e2a"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("d7efd08e-3cca-4749-b9e3-119a056f0d0b"),
                            EstateId = new Guid("67b8007d-5b62-4ceb-b833-5b3f70243e2a"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("fde63543-4941-414d-8662-67fe66bdbc35"),
                            EstateId = new Guid("250fed64-1d1a-4e42-a6b2-bc3b29cdeb74"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("0ad42867-219b-4e41-b8ca-e1e14a0233cf"),
                            EstateId = new Guid("250fed64-1d1a-4e42-a6b2-bc3b29cdeb74"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("dd2374ed-1eaa-4ce9-a925-227c09388d7a"),
                            EstateId = new Guid("820af93f-1270-48f1-a9c9-ad16dd198a12"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("d0f28af8-3ef3-45e1-a154-1946e621e133"),
                            EstateId = new Guid("820af93f-1270-48f1-a9c9-ad16dd198a12"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("8be94df3-ce5d-4f2c-8e6b-ea5f876aa869"),
                            EstateId = new Guid("7b3fb9f1-c80c-423e-9a05-4620000dab81"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("1130292c-2b8c-4f4e-ab89-91f59c4363c4"),
                            EstateId = new Guid("7b3fb9f1-c80c-423e-9a05-4620000dab81"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("392aa088-37d5-431d-b48e-f53784eef5f2"),
                            EstateId = new Guid("84f560ef-847d-499f-a99e-2c45529943f3"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("65fc1306-5aeb-466a-8cfa-7d1b7eabd350"),
                            EstateId = new Guid("84f560ef-847d-499f-a99e-2c45529943f3"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("37bc67a0-7646-479f-a576-5a6dd5aa80e8"),
                            EstateId = new Guid("fe9ac054-4c86-4174-a675-5e4786950349"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("0bd1f531-663d-419b-a76b-692c8acc25e7"),
                            EstateId = new Guid("fe9ac054-4c86-4174-a675-5e4786950349"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("f46758db-9f42-47f0-8bd2-8c757cbadb31"),
                            EstateId = new Guid("5b2c0972-ae7e-4f81-943a-10e8f0c86ac1"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("7876ed3d-101e-4666-a1a7-7c7f9299bd3e"),
                            EstateId = new Guid("5b2c0972-ae7e-4f81-943a-10e8f0c86ac1"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("ea4f949b-7d43-40e3-b105-060db7712760"),
                            EstateId = new Guid("6739cef9-a5b1-4ddd-89e8-0338faf7ddb1"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("08209a02-a475-4b86-be9f-208ce5d39f0e"),
                            EstateId = new Guid("6739cef9-a5b1-4ddd-89e8-0338faf7ddb1"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("acd36693-dd91-4d24-a645-19737b32db1d"),
                            EstateId = new Guid("17032fdc-372d-4b9e-9b7d-f9c5408ef1f0"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("09590428-39c4-4d8c-b368-bb2342d96652"),
                            EstateId = new Guid("17032fdc-372d-4b9e-9b7d-f9c5408ef1f0"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("9842721d-7409-496a-b6e0-a49230711e67"),
                            EstateId = new Guid("80c5c29a-603f-47e9-ae37-c801591fb199"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("ea951cb5-f775-47fa-99fa-9accffaf30e7"),
                            EstateId = new Guid("80c5c29a-603f-47e9-ae37-c801591fb199"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("9a08bc83-229e-4ba7-9aae-a58dc7d113a0"),
                            EstateId = new Guid("68899b0b-a905-440c-902a-c2cfc91159c8"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("0a13c5e9-4a8b-4bb8-a989-86e171511d8f"),
                            EstateId = new Guid("68899b0b-a905-440c-902a-c2cfc91159c8"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("fe3ab537-e856-4427-bcf0-471b6730f65d"),
                            EstateId = new Guid("28b9f768-d1f9-47ba-bd09-569edf1273f4"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("fb13006e-5fbf-4987-9ee5-02205cf7dd35"),
                            EstateId = new Guid("28b9f768-d1f9-47ba-bd09-569edf1273f4"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("5039be6a-e90c-4986-b7b4-a9cd4d49b7ba"),
                            EstateId = new Guid("1787bee8-40f6-43f8-a5bd-d9e022ed315c"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("955a7dc1-f0c5-4595-b33d-0b2c7c0c3a98"),
                            EstateId = new Guid("1787bee8-40f6-43f8-a5bd-d9e022ed315c"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("a8ae1c35-58ca-48b6-9706-c75a0b644a81"),
                            EstateId = new Guid("28d53a86-8871-4651-9f60-388116455f37"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("debdd5fd-87e0-495a-96db-38da2cff8712"),
                            EstateId = new Guid("28d53a86-8871-4651-9f60-388116455f37"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("45ff8efd-3c15-4b89-91bb-0b59801d1b7e"),
                            EstateId = new Guid("73c63b43-047e-405a-9990-fac648900d7f"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("7f70cccd-aaa8-4398-89e0-65147cb4043f"),
                            EstateId = new Guid("73c63b43-047e-405a-9990-fac648900d7f"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("3ef0fbe6-6f7a-4580-8f05-0be6fc0a7f6c"),
                            EstateId = new Guid("e9b2e052-f426-45da-a9fe-d2ba400b08c9"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("04cbcab9-95a0-4bbb-8142-ee9b52809101"),
                            EstateId = new Guid("e9b2e052-f426-45da-a9fe-d2ba400b08c9"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("3c8aea1d-f621-4a2e-a650-8f83d0a6c5ff"),
                            EstateId = new Guid("ff3b8131-5e0a-4f5f-b3d3-a9ab4a05c783"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("24fbadf6-cb6c-4ae3-a952-042559d19e20"),
                            EstateId = new Guid("ff3b8131-5e0a-4f5f-b3d3-a9ab4a05c783"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("4ccc0010-26f6-4669-95e8-cb0d4231a278"),
                            EstateId = new Guid("0e196bc0-4da7-4d7b-ba01-4f5cf4bee89e"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("2492cb3c-dd9c-4757-a31e-40c331e45d43"),
                            EstateId = new Guid("0e196bc0-4da7-4d7b-ba01-4f5cf4bee89e"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("85caba17-8542-419d-b007-43315b573b3f"),
                            EstateId = new Guid("ba9e026d-702d-47db-8057-d629d7ca7f5b"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("59321c66-7f33-42f0-ba2a-53c99dc76f4f"),
                            EstateId = new Guid("ba9e026d-702d-47db-8057-d629d7ca7f5b"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("3cf5ad01-3e9f-4652-949d-a96639c2d42e"),
                            EstateId = new Guid("757cde89-213d-4896-9de3-bad1b311efee"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("9ed4deff-a1e7-4aaf-b3be-46b8d5641a5c"),
                            EstateId = new Guid("757cde89-213d-4896-9de3-bad1b311efee"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("ce1c94bc-cdf1-4c63-a507-e2c68f581c34"),
                            EstateId = new Guid("0c6cb005-f53d-44a9-8cbc-210757f90fa7"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("13850764-3023-4feb-9292-00a30e598020"),
                            EstateId = new Guid("0c6cb005-f53d-44a9-8cbc-210757f90fa7"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("5f86e845-6c76-4e5a-8e51-4b373b602424"),
                            EstateId = new Guid("386ce4c6-a810-4336-8143-df4094f2e6e3"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("646c2dd2-dd44-41ae-88cc-d5ad12315429"),
                            EstateId = new Guid("386ce4c6-a810-4336-8143-df4094f2e6e3"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("9c132cd4-2a02-4d96-bfbd-121f9bcf15a5"),
                            EstateId = new Guid("3e86bdc7-c190-46e6-b43a-9af35c0a1197"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("8578dc8b-2b17-4ba6-a06b-42d3149ee286"),
                            EstateId = new Guid("3e86bdc7-c190-46e6-b43a-9af35c0a1197"),
                            Url = "https://placehold.co/600x400"
                        },
                        new
                        {
                            Id = new Guid("60c25d2c-0ec2-4486-91dc-2b7e60332adb"),
                            EstateId = new Guid("0d18154e-8638-4412-a9b7-e5b6a7c0d176"),
                            Url = "https://placehold.co/300x200"
                        },
                        new
                        {
                            Id = new Guid("86cce853-b79a-4806-875e-89049cf6d8ab"),
                            EstateId = new Guid("0d18154e-8638-4412-a9b7-e5b6a7c0d176"),
                            Url = "https://placehold.co/600x400"
                        });
                });

            modelBuilder.Entity("RealEstateSearch.Models.District", b =>
                {
                    b.HasOne("RealEstateSearch.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("RealEstateSearch.Models.Estate", b =>
                {
                    b.HasOne("RealEstateSearch.Models.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RealEstateSearch.Models.EstateType", "EstateType")
                        .WithMany()
                        .HasForeignKey("EstateTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");

                    b.Navigation("EstateType");
                });

            modelBuilder.Entity("RealEstateSearch.Models.Image", b =>
                {
                    b.HasOne("RealEstateSearch.Models.Estate", "Estate")
                        .WithMany("Images")
                        .HasForeignKey("EstateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estate");
                });

            modelBuilder.Entity("RealEstateSearch.Models.Estate", b =>
                {
                    b.Navigation("Images");
                });
#pragma warning restore 612, 618
        }
    }
}
