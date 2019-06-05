using Microsoft.EntityFrameworkCore.Migrations;

namespace Dating.API.Migrations
{
    public partial class Fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Massages_Users_RecipientId",
                table: "Massages");

            migrationBuilder.DropForeignKey(
                name: "FK_Massages_Users_SenderId",
                table: "Massages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Massages",
                table: "Massages");

            migrationBuilder.RenameTable(
                name: "Massages",
                newName: "Messages");

            migrationBuilder.RenameIndex(
                name: "IX_Massages_SenderId",
                table: "Messages",
                newName: "IX_Messages_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Massages_RecipientId",
                table: "Messages",
                newName: "IX_Messages_RecipientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_RecipientId",
                table: "Messages",
                column: "RecipientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_SenderId",
                table: "Messages",
                column: "SenderId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_RecipientId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_SenderId",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "Massages");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_SenderId",
                table: "Massages",
                newName: "IX_Massages_SenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_RecipientId",
                table: "Massages",
                newName: "IX_Massages_RecipientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Massages",
                table: "Massages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Massages_Users_RecipientId",
                table: "Massages",
                column: "RecipientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Massages_Users_SenderId",
                table: "Massages",
                column: "SenderId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
