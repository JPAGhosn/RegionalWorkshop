using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BackendWorkshop.Migrations
{
    /// <inheritdoc />
    public partial class AddingRegion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RegionId",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "Users");
        }
    }
}
