using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstMovie.Migrations
{
    /// <inheritdoc />
    public partial class AddNotaToFilme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Nota",
                table: "Filmes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nota",
                table: "Filmes");
        }
    }
}
