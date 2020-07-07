using Microsoft.EntityFrameworkCore.Migrations;

namespace EDAPI.Migrations
{
    public partial class AddedMoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "DeviceName", "Make" },
                values: new object[,]
                {
                    { 4, "IPhone_4", "Apple" },
                    { 75, "Macbook_75", "Apple" },
                    { 74, "Apple Watch_74", "Apple" },
                    { 73, "IPhone_73", "Apple" },
                    { 72, "Macbook_72", "Apple" },
                    { 71, "Apple Watch_71", "Apple" },
                    { 70, "IPhone_70", "Apple" },
                    { 69, "Macbook_69", "Apple" },
                    { 68, "Apple Watch_68", "Apple" },
                    { 67, "IPhone_67", "Apple" },
                    { 66, "Macbook_66", "Apple" },
                    { 65, "Apple Watch_65", "Apple" },
                    { 64, "IPhone_64", "Apple" },
                    { 63, "Macbook_63", "Apple" },
                    { 62, "Apple Watch_62", "Apple" },
                    { 61, "IPhone_61", "Apple" },
                    { 60, "Macbook_60", "Apple" },
                    { 59, "Apple Watch_59", "Apple" },
                    { 58, "IPhone_58", "Apple" },
                    { 57, "Macbook_57", "Apple" },
                    { 56, "Apple Watch_56", "Apple" },
                    { 55, "IPhone_55", "Apple" },
                    { 76, "IPhone_76", "Apple" },
                    { 54, "Macbook_54", "Apple" },
                    { 77, "Apple Watch_77", "Apple" },
                    { 79, "IPhone_79", "Apple" },
                    { 100, "IPhone_100", "Apple" },
                    { 99, "Macbook_99", "Apple" },
                    { 98, "Apple Watch_98", "Apple" },
                    { 97, "IPhone_97", "Apple" },
                    { 96, "Macbook_96", "Apple" },
                    { 95, "Apple Watch_95", "Apple" },
                    { 94, "IPhone_94", "Apple" },
                    { 93, "Macbook_93", "Apple" },
                    { 92, "Apple Watch_92", "Apple" },
                    { 91, "IPhone_91", "Apple" },
                    { 90, "Macbook_90", "Apple" },
                    { 89, "Apple Watch_89", "Apple" },
                    { 88, "IPhone_88", "Apple" },
                    { 87, "Macbook_87", "Apple" },
                    { 86, "Apple Watch_86", "Apple" },
                    { 85, "IPhone_85", "Apple" },
                    { 84, "Macbook_84", "Apple" },
                    { 83, "Apple Watch_83", "Apple" },
                    { 82, "IPhone_82", "Apple" },
                    { 81, "Macbook_81", "Apple" },
                    { 80, "Apple Watch_80", "Apple" },
                    { 78, "Macbook_78", "Apple" },
                    { 101, "Apple Watch_101", "Apple" },
                    { 53, "Apple Watch_53", "Apple" },
                    { 51, "Macbook_51", "Apple" },
                    { 25, "IPhone_25", "Apple" },
                    { 24, "Macbook_24", "Apple" },
                    { 23, "Apple Watch_23", "Apple" },
                    { 22, "IPhone_22", "Apple" },
                    { 21, "Macbook_21", "Apple" },
                    { 20, "Apple Watch_20", "Apple" },
                    { 19, "IPhone_19", "Apple" },
                    { 18, "Macbook_18", "Apple" },
                    { 17, "Apple Watch_17", "Apple" },
                    { 16, "IPhone_16", "Apple" },
                    { 15, "Macbook_15", "Apple" },
                    { 14, "Apple Watch_14", "Apple" },
                    { 13, "IPhone_13", "Apple" },
                    { 12, "Macbook_12", "Apple" },
                    { 11, "Apple Watch_11", "Apple" },
                    { 10, "IPhone_10", "Apple" },
                    { 9, "Macbook_9", "Apple" },
                    { 8, "Apple Watch_8", "Apple" },
                    { 7, "IPhone_7", "Apple" },
                    { 6, "Macbook_6", "Apple" },
                    { 5, "Apple Watch_5", "Apple" },
                    { 26, "Apple Watch_26", "Apple" },
                    { 52, "IPhone_52", "Apple" },
                    { 27, "Macbook_27", "Apple" },
                    { 29, "Apple Watch_29", "Apple" },
                    { 50, "Apple Watch_50", "Apple" },
                    { 49, "IPhone_49", "Apple" },
                    { 48, "Macbook_48", "Apple" },
                    { 47, "Apple Watch_47", "Apple" },
                    { 46, "IPhone_46", "Apple" },
                    { 45, "Macbook_45", "Apple" },
                    { 44, "Apple Watch_44", "Apple" },
                    { 43, "IPhone_43", "Apple" },
                    { 42, "Macbook_42", "Apple" },
                    { 41, "Apple Watch_41", "Apple" },
                    { 40, "IPhone_40", "Apple" },
                    { 39, "Macbook_39", "Apple" },
                    { 38, "Apple Watch_38", "Apple" },
                    { 37, "IPhone_37", "Apple" },
                    { 36, "Macbook_36", "Apple" },
                    { 35, "Apple Watch_35", "Apple" },
                    { 34, "IPhone_34", "Apple" },
                    { 33, "Macbook_33", "Apple" },
                    { 32, "Apple Watch_32", "Apple" },
                    { 31, "IPhone_31", "Apple" },
                    { 30, "Macbook_30", "Apple" },
                    { 28, "IPhone_28", "Apple" },
                    { 102, "Macbook_102", "Apple" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "DeviceName", "Make" },
                values: new object[] { 1, "IPhone", "Apple" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "DeviceName", "Make" },
                values: new object[] { 2, "Apple Watch", "Apple" });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "DeviceName", "Make" },
                values: new object[] { 3, "Macbook", "Apple" });
        }
    }
}
