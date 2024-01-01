using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ggmeet.Migrations
{
    /// <inheritdoc />
    public partial class New_DataAnnotations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SaltPassword",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaltPassword",
                table: "User");
        }
    }
}
