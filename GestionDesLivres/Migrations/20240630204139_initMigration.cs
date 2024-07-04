using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionDesLivres.Migrations
{
    /// <inheritdoc />
    public partial class initMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "livre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    author_key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    author_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    first_publish_year = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contributor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livre", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "livre");
        }
    }
}
