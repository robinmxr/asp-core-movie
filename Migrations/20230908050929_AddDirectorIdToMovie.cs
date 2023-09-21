using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    /// <inheritdoc />
    public partial class AddDirectorIdToMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DirectorId",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_DirectorId",
                table: "Movie",
                column: "DirectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Director_DirectorId",
                table: "Movie",
                column: "DirectorId",
                principalTable: "Director",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Director_DirectorId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_DirectorId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "DirectorId",
                table: "Movie");
        }
    }
}
