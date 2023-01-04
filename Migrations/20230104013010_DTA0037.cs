using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DangThiAnh037.Migrations
{
    /// <inheritdoc />
    public partial class DTA0037 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DTA0037",
                columns: table => new
                {
                    DTAId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    DTAName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    DTAGender = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DTA0037", x => x.DTAId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DTA0037");
        }
    }
}
