using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPageApp.Migrations
{
    /// <inheritdoc />
    public partial class Usernames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "User",
                newName: "UserName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "User",
                newName: "Role");
        }
    }
}
