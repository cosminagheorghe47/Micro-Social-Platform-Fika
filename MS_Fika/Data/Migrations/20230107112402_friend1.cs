using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MS_Fika.Data.Migrations
{
    public partial class friend1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_User1Id",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_User2Id",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "Friend1Id",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "Friend2Id",
                table: "Friends");

            migrationBuilder.RenameColumn(
                name: "User2Id",
                table: "Friends",
                newName: "User2_Id");

            migrationBuilder.RenameColumn(
                name: "User1Id",
                table: "Friends",
                newName: "User1_Id");

            migrationBuilder.RenameColumn(
                name: "FriendAccepted",
                table: "Friends",
                newName: "Accepted");

            migrationBuilder.RenameIndex(
                name: "IX_Friends_User2Id",
                table: "Friends",
                newName: "IX_Friends_User2_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Friends_User1Id",
                table: "Friends",
                newName: "IX_Friends_User1_Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "RequestTime",
                table: "Friends",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_User1_Id",
                table: "Friends",
                column: "User1_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_User2_Id",
                table: "Friends",
                column: "User2_Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_User1_Id",
                table: "Friends");

            migrationBuilder.DropForeignKey(
                name: "FK_Friends_AspNetUsers_User2_Id",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "RequestTime",
                table: "Friends");

            migrationBuilder.RenameColumn(
                name: "User2_Id",
                table: "Friends",
                newName: "User2Id");

            migrationBuilder.RenameColumn(
                name: "User1_Id",
                table: "Friends",
                newName: "User1Id");

            migrationBuilder.RenameColumn(
                name: "Accepted",
                table: "Friends",
                newName: "FriendAccepted");

            migrationBuilder.RenameIndex(
                name: "IX_Friends_User2_Id",
                table: "Friends",
                newName: "IX_Friends_User2Id");

            migrationBuilder.RenameIndex(
                name: "IX_Friends_User1_Id",
                table: "Friends",
                newName: "IX_Friends_User1Id");

            migrationBuilder.AddColumn<string>(
                name: "Friend1Id",
                table: "Friends",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Friend2Id",
                table: "Friends",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_User1Id",
                table: "Friends",
                column: "User1Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Friends_AspNetUsers_User2Id",
                table: "Friends",
                column: "User2Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
