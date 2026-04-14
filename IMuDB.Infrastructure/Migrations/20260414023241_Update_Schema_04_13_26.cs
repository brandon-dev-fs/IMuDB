using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMuDB.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update_Schema_04_13_26 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusicianEntityInstrumentEntity");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Musicians");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Instruments",
                newName: "Instrument");

            migrationBuilder.AddColumn<string>(
                name: "GenreId",
                table: "Songs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEntityId",
                table: "Songs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserEntityId",
                table: "Albums",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Acts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserEntityId",
                table: "Acts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstrumentEntityMusicianEntity",
                columns: table => new
                {
                    InstrumentsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MusiciansId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrumentEntityMusicianEntity", x => new { x.InstrumentsId, x.MusiciansId });
                    table.ForeignKey(
                        name: "FK_InstrumentEntityMusicianEntity_Instruments_InstrumentsId",
                        column: x => x.InstrumentsId,
                        principalTable: "Instruments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstrumentEntityMusicianEntity_Musicians_MusiciansId",
                        column: x => x.MusiciansId,
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_GenreId",
                table: "Songs",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_UserEntityId",
                table: "Songs",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_UserEntityId",
                table: "Albums",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Acts_UserEntityId",
                table: "Acts",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_InstrumentEntityMusicianEntity_MusiciansId",
                table: "InstrumentEntityMusicianEntity",
                column: "MusiciansId");

            migrationBuilder.AddForeignKey(
                name: "FK_Acts_Users_UserEntityId",
                table: "Acts",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Users_UserEntityId",
                table: "Albums",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Genres_GenreId",
                table: "Songs",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Users_UserEntityId",
                table: "Songs",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acts_Users_UserEntityId",
                table: "Acts");

            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Users_UserEntityId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Genres_GenreId",
                table: "Songs");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Users_UserEntityId",
                table: "Songs");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "InstrumentEntityMusicianEntity");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Songs_GenreId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_UserEntityId",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Albums_UserEntityId",
                table: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Acts_UserEntityId",
                table: "Acts");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "UserEntityId",
                table: "Songs");

            migrationBuilder.DropColumn(
                name: "UserEntityId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Acts");

            migrationBuilder.DropColumn(
                name: "UserEntityId",
                table: "Acts");

            migrationBuilder.RenameColumn(
                name: "Instrument",
                table: "Instruments",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Songs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Musicians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MusicianEntityInstrumentEntity",
                columns: table => new
                {
                    MusiciansId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InstrumentsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicianEntityInstrumentEntity", x => new { x.MusiciansId, x.InstrumentsId });
                    table.ForeignKey(
                        name: "FK_MusicianEntityInstrumentEntity_Instruments_InstrumentsId",
                        column: x => x.InstrumentsId,
                        principalTable: "Instruments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MusicianEntityInstrumentEntity_Musicians_MusiciansId",
                        column: x => x.MusiciansId,
                        principalTable: "Musicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MusicianEntityInstrumentEntity_InstrumentsId",
                table: "MusicianEntityInstrumentEntity",
                column: "InstrumentsId");
        }
    }
}
