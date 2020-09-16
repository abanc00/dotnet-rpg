using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_rpg.Migrations
{
    public partial class FinalSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new byte[] { 216, 147, 252, 195, 13, 184, 39, 12, 216, 200, 33, 19, 63, 191, 220, 25, 179, 220, 119, 57, 102, 144, 174, 188, 153, 98, 48, 226, 51, 7, 163, 241, 18, 134, 89, 35, 219, 223, 248, 146, 225, 60, 143, 209, 233, 178, 204, 216, 94, 68, 77, 68, 194, 231, 74, 86, 225, 71, 114, 244, 174, 66, 248, 7 }, new byte[] { 5, 216, 65, 225, 198, 145, 218, 226, 217, 88, 179, 169, 29, 91, 107, 59, 76, 141, 171, 80, 186, 17, 76, 115, 44, 15, 79, 91, 54, 31, 46, 34, 94, 213, 62, 141, 202, 81, 166, 48, 99, 65, 205, 137, 5, 244, 77, 118, 7, 97, 23, 191, 39, 73, 191, 247, 135, 177, 4, 228, 181, 12, 234, 192, 83, 60, 7, 226, 146, 161, 241, 21, 212, 46, 80, 230, 173, 245, 14, 64, 250, 246, 226, 214, 136, 14, 168, 134, 10, 54, 116, 146, 157, 1, 96, 102, 110, 167, 37, 237, 63, 205, 178, 222, 69, 149, 163, 189, 213, 8, 191, 177, 63, 246, 25, 105, 246, 191, 243, 176, 59, 59, 50, 134, 116, 33, 243, 168 }, "User1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, new byte[] { 216, 147, 252, 195, 13, 184, 39, 12, 216, 200, 33, 19, 63, 191, 220, 25, 179, 220, 119, 57, 102, 144, 174, 188, 153, 98, 48, 226, 51, 7, 163, 241, 18, 134, 89, 35, 219, 223, 248, 146, 225, 60, 143, 209, 233, 178, 204, 216, 94, 68, 77, 68, 194, 231, 74, 86, 225, 71, 114, 244, 174, 66, 248, 7 }, new byte[] { 5, 216, 65, 225, 198, 145, 218, 226, 217, 88, 179, 169, 29, 91, 107, 59, 76, 141, 171, 80, 186, 17, 76, 115, 44, 15, 79, 91, 54, 31, 46, 34, 94, 213, 62, 141, 202, 81, 166, 48, 99, 65, 205, 137, 5, 244, 77, 118, 7, 97, 23, 191, 39, 73, 191, 247, 135, 177, 4, 228, 181, 12, 234, 192, 83, 60, 7, 226, 146, 161, 241, 21, 212, 46, 80, 230, 173, 245, 14, 64, 250, 246, 226, 214, 136, 14, 168, 134, 10, 54, 116, 146, 157, 1, 96, 102, 110, 167, 37, 237, 63, 205, 178, 222, 69, 149, 163, 189, 213, 8, 191, 177, 63, 246, 25, 105, 246, 191, 243, 176, 59, 59, 50, 134, 116, 33, 243, 168 }, "User2" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 1, 1, 0, 10, 0, 100, 10, "Frodo", 15, 1, 0 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 2, 2, 0, 5, 0, 100, 20, "Raistlin", 5, 2, 0 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 1, 1, 20, "The Master Sword" });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 2, 2, 5, "Crystal Wand" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
