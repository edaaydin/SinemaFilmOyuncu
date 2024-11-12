using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeyazPerde.Migrations
{
    /// <inheritdoc />
    public partial class One : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oyuncus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyuncus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yonetmens",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yonetmens", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    YayinlanmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YonetmenID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Films_Yonetmens_YonetmenID",
                        column: x => x.YonetmenID,
                        principalTable: "Yonetmens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OyuncuFilms",
                columns: table => new
                {
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    OyuncuID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OyuncuFilms", x => new { x.OyuncuID, x.FilmID });
                    table.ForeignKey(
                        name: "FK_OyuncuFilms_Films_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OyuncuFilms_Oyuncus_OyuncuID",
                        column: x => x.OyuncuID,
                        principalTable: "Oyuncus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_YonetmenID",
                table: "Films",
                column: "YonetmenID");

            migrationBuilder.CreateIndex(
                name: "IX_OyuncuFilms_FilmID",
                table: "OyuncuFilms",
                column: "FilmID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OyuncuFilms");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Oyuncus");

            migrationBuilder.DropTable(
                name: "Yonetmens");
        }
    }
}
