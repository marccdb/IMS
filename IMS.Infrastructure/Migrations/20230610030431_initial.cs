using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GlassesColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlassesColors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlassesLensTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LensType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlassesLensTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GlassesSizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlassesSizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Glasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LensTypeId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    Width = table.Column<float>(type: "real", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Is_Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Glasses_GlassesColors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "GlassesColors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Glasses_GlassesLensTypes_LensTypeId",
                        column: x => x.LensTypeId,
                        principalTable: "GlassesLensTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Glasses_GlassesSizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "GlassesSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Glasses_ColorId",
                table: "Glasses",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Glasses_LensTypeId",
                table: "Glasses",
                column: "LensTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Glasses_SizeId",
                table: "Glasses",
                column: "SizeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Glasses");

            migrationBuilder.DropTable(
                name: "GlassesColors");

            migrationBuilder.DropTable(
                name: "GlassesLensTypes");

            migrationBuilder.DropTable(
                name: "GlassesSizes");
        }
    }
}
