using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class new_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsLetters",
                table: "NewsLetters");

            migrationBuilder.RenameTable(
                name: "NewsLetters",
                newName: "Newsletters");

            migrationBuilder.RenameColumn(
                name: "NewsLetterID",
                table: "Newsletters",
                newName: "NewsletterID");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Features",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Feature2s",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Image2",
                table: "Abouts",
                newName: "Title2");

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "Guides",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuideListImage",
                table: "Guides",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Destinations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GuideID",
                table: "Destinations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppUserID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Newsletters",
                table: "Newsletters",
                column: "NewsletterID");

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountID);
                });

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    AnnouncementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.AnnouncementID);
                });

            migrationBuilder.CreateTable(
                name: "ContactUses",
                columns: table => new
                {
                    ContactUsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUses", x => x.ContactUsID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_GuideID",
                table: "Destinations",
                column: "GuideID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AppUserID",
                table: "Comments",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_AppUserID",
                table: "Comments",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Destinations_Guides_GuideID",
                table: "Destinations",
                column: "GuideID",
                principalTable: "Guides",
                principalColumn: "GuideID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_AppUserID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Destinations_Guides_GuideID",
                table: "Destinations");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "ContactUses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Newsletters",
                table: "Newsletters");

            migrationBuilder.DropIndex(
                name: "IX_Destinations_GuideID",
                table: "Destinations");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AppUserID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "Guides");

            migrationBuilder.DropColumn(
                name: "GuideListImage",
                table: "Guides");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "GuideID",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "AppUserID",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Newsletters",
                newName: "NewsLetters");

            migrationBuilder.RenameColumn(
                name: "NewsletterID",
                table: "NewsLetters",
                newName: "NewsLetterID");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Features",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Feature2s",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Title2",
                table: "Abouts",
                newName: "Image2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsLetters",
                table: "NewsLetters",
                column: "NewsLetterID");
        }
    }
}
