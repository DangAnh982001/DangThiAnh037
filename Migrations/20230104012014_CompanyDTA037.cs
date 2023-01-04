using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DangThiAnh037.Migrations
{
    /// <inheritdoc />
    public partial class CompanyDTA037 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyDTA037",
                columns: table => new
                {
                    CompanyId = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyDTA037", x => x.CompanyId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyDTA037");
        }
    }
}
