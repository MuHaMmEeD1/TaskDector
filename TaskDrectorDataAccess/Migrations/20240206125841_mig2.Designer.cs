﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskDrectorDataAccess.Contexts;

#nullable disable

namespace TaskDrectorDataAccess.Migrations
{
    [DbContext(typeof(DrectorDb))]
    [Migration("20240206125841_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TaskDrectorModel.Entitys.Debtor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("Debt")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Debtors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "3565 Eagles Nest Drive Woodland, CA 95695",
                            BirthDay = new DateTime(1932, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 2414,
                            Email = "ShirleyTQualls@teleworm.us",
                            FullName = "Shirley T. Qualls",
                            Phone = "530-662-7732"
                        },
                        new
                        {
                            Id = 2,
                            Address = "1973 Stoneybrook Road Maitland, FL 32751",
                            BirthDay = new DateTime(1953, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 3599,
                            Email = "DanielleWGrier@rhyta.com",
                            FullName = "Danielle W. Grier",
                            Phone = "321-473-4178"
                        },
                        new
                        {
                            Id = 3,
                            Address = "2432 Hannah Street Andrews, NC 28901",
                            BirthDay = new DateTime(1963, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 1219,
                            Email = "ConnieWLemire@rhyta.com",
                            FullName = "Connie W. Lemire",
                            Phone = "828-321-3751"
                        },
                        new
                        {
                            Id = 4,
                            Address = "2411 Blue Spruce Lane Baltimore, MD 21202",
                            BirthDay = new DateTime(1976, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 3784,
                            Email = "CoyKAdams@dayrep.com",
                            FullName = "Coy K. Adams",
                            Phone = "410-347-1307"
                        },
                        new
                        {
                            Id = 5,
                            Address = "4971 Austin Avenue Savannah, GA 31401",
                            BirthDay = new DateTime(1988, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 4060,
                            Email = "BerniceJMiles@armyspy.com",
                            FullName = "Bernice J. Miles",
                            Phone = "912-307-6797"
                        },
                        new
                        {
                            Id = 6,
                            Address = "2031 Limer Street Augusta, GA 30901",
                            BirthDay = new DateTime(1990, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 6628,
                            Email = "BobLZambrano@armyspy.com",
                            FullName = "Bob L. Zambrano",
                            Phone = "706-446-1649"
                        },
                        new
                        {
                            Id = 7,
                            Address = "2737 Rardin Drive San Jose, CA 95110",
                            BirthDay = new DateTime(1950, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 5412,
                            Email = "AdamDBartlett@rhyta.com",
                            FullName = "Adam D. Bartlett",
                            Phone = "650-693-1758"
                        },
                        new
                        {
                            Id = 8,
                            Address = "16 Fraggle Drive Hickory Hills, IL 60457",
                            BirthDay = new DateTime(1936, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 11097,
                            Email = "PabloMSkinner@armyspy.com",
                            FullName = "Pablo M. Skinner",
                            Phone = "630-391-2034"
                        },
                        new
                        {
                            Id = 9,
                            Address = "699 Harper Street Louisville, KY 40202",
                            BirthDay = new DateTime(1971, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 7956,
                            Email = "DorothyJBrown@rhyta.com",
                            FullName = "Dorothy J. Brown",
                            Phone = "270-456-3288"
                        },
                        new
                        {
                            Id = 10,
                            Address = "2940 Adams Avenue Columbia, MD 21044",
                            BirthDay = new DateTime(1998, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 7150,
                            Email = "LarryAMiracle@jourrapide.com",
                            FullName = "Larry A. Miracle",
                            Phone = "301-621-3318"
                        },
                        new
                        {
                            Id = 11,
                            Address = "4821 Elk Rd Little Tucson, AZ 85704",
                            BirthDay = new DateTime(1944, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 2910,
                            Email = "DonnaBMaynard@teleworm.us",
                            FullName = "Donna B. Maynard",
                            Phone = "520-297-0575"
                        },
                        new
                        {
                            Id = 12,
                            Address = "2527 Terra Street Custer, WA 98240",
                            BirthDay = new DateTime(1989, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 11805,
                            Email = "JessicaJStoops@dayrep.com",
                            FullName = "Jessica J. Stoops",
                            Phone = "360-366-8101"
                        },
                        new
                        {
                            Id = 13,
                            Address = "151 Christie Way Marlboro, MA 01752",
                            BirthDay = new DateTime(1937, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 1001,
                            Email = "AudryMStyles@jourrapide.com",
                            FullName = "Audry M. Styles",
                            Phone = "978-773-4802"
                        },
                        new
                        {
                            Id = 14,
                            Address = "1460 Walt Nuzum Farm Road Rochester, NY 14620",
                            BirthDay = new DateTime(1958, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 9128,
                            Email = "VioletRAnguiano@dayrep.com",
                            FullName = "Violet R. Anguiano",
                            Phone = "585-340-7888"
                        },
                        new
                        {
                            Id = 15,
                            Address = "1824 Roosevelt Street Fremont, CA 94539",
                            BirthDay = new DateTime(1970, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 5648,
                            Email = "CharlesPSegundo@dayrep.com",
                            FullName = "Charles P. Segundo",
                            Phone = "415-367-3341"
                        },
                        new
                        {
                            Id = 16,
                            Address = "759 Havanna Street Saxapahaw, NC 27340",
                            BirthDay = new DateTime(1944, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 10437,
                            Email = "PaulHSturtz@dayrep.com",
                            FullName = "Paul H. Sturtz",
                            Phone = "336-376-1732"
                        },
                        new
                        {
                            Id = 17,
                            Address = "3172 Bedford Street Birmingham, AL 35203",
                            BirthDay = new DateTime(1978, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 7230,
                            Email = "DorisBKing@rhyta.com",
                            FullName = "Doris B. King",
                            Phone = "205-231-8973"
                        },
                        new
                        {
                            Id = 18,
                            Address = "1972 Orchard Street Bloomington, MN 55437",
                            BirthDay = new DateTime(1983, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 515,
                            Email = "DeannaJDonofrio@rhyta.com",
                            FullName = "Deanna J. Donofrio",
                            Phone = "952-842-7576"
                        },
                        new
                        {
                            Id = 19,
                            Address = "3749 Capitol Avenue New Castle, IN 47362",
                            BirthDay = new DateTime(1992, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 1816,
                            Email = "MartinSMalinowski@dayrep.com",
                            FullName = "Martin S. Malinowski",
                            Phone = "765-599-3523"
                        },
                        new
                        {
                            Id = 20,
                            Address = "922 Hill Croft Farm Road Sacramento, CA 95814",
                            BirthDay = new DateTime(1974, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 5037,
                            Email = "MelissaRArner@armyspy.com",
                            FullName = "Melissa R. Arner",
                            Phone = "530-508-7328"
                        },
                        new
                        {
                            Id = 21,
                            Address = "4738 Chapmans Lane Grants, NM 87020",
                            BirthDay = new DateTime(1969, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 7755,
                            Email = "KellyGHoffman@armyspy.com",
                            FullName = "Kelly G. Hoffman",
                            Phone = "505-876-8935"
                        },
                        new
                        {
                            Id = 22,
                            Address = "124 Wood Street Saginaw, MI 48607",
                            BirthDay = new DateTime(1986, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 11657,
                            Email = "DoyleBShort@teleworm.us",
                            FullName = "Doyle B. Short",
                            Phone = "989-221-4363"
                        },
                        new
                        {
                            Id = 23,
                            Address = "74 Pine Street Pittsburgh, PA 15222",
                            BirthDay = new DateTime(1960, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 9693,
                            Email = "LorrieRGilmore@teleworm.us",
                            FullName = "Lorrie R. Gilmore",
                            Phone = "724-306-7138"
                        },
                        new
                        {
                            Id = 24,
                            Address = "29 Goldleaf Lane Red Bank, NJ 07701",
                            BirthDay = new DateTime(1972, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 2712,
                            Email = "LionelACook@jourrapide.com",
                            FullName = "Lionel A. Cook",
                            Phone = "201-627-5962"
                        },
                        new
                        {
                            Id = 25,
                            Address = "4686 Renwick Drive Philadelphia, PA 19108",
                            BirthDay = new DateTime(1990, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 4016,
                            Email = "CharleneCBurke@armyspy.com",
                            FullName = "Charlene C. Burke",
                            Phone = "484-334-9729"
                        },
                        new
                        {
                            Id = 26,
                            Address = "748 Rockford Road Westborough, MA 01581",
                            BirthDay = new DateTime(1981, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 349,
                            Email = "TommyMPatton@rhyta.com",
                            FullName = "Tommy M. Patton",
                            Phone = "774-571-6481"
                        },
                        new
                        {
                            Id = 27,
                            Address = "15 Hewes Avenue Towson, MD 21204",
                            BirthDay = new DateTime(1944, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 9824,
                            Email = "KristinSBloomer@dayrep.com",
                            FullName = "Kristin S. Bloomer",
                            Phone = "443-652-0734"
                        },
                        new
                        {
                            Id = 28,
                            Address = "3052 Walton Street Salt Lake City, UT 84104",
                            BirthDay = new DateTime(1997, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 8215,
                            Email = "DanielKJames@rhyta.com",
                            FullName = "Daniel K. James",
                            Phone = "801-407-4693"
                        },
                        new
                        {
                            Id = 29,
                            Address = "3575 Eagle Street Norris City, IL 62869",
                            BirthDay = new DateTime(1976, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 5766,
                            Email = "PaulaDHenry@rhyta.com",
                            FullName = "Paula D. Henry",
                            Phone = "618-378-5307"
                        },
                        new
                        {
                            Id = 30,
                            Address = "675 Jehovah Drive Martinsville, VA 24112",
                            BirthDay = new DateTime(1947, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Debt = 8363,
                            Email = "DonnaCSandoval@rhyta.com",
                            FullName = "Donna C. Sandoval",
                            Phone = "540-482-5463"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
