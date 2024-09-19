using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StructureEFSimple.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReferentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personne_Personne_ReferentId",
                        column: x => x.ReferentId,
                        principalTable: "Personne",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Personne",
                columns: new[] { "Id", "Nom", "ReferentId" },
                values: new object[,]
                {
                    { 1, "Thierry", null },
                    { 2, "Marc", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personne_ReferentId",
                table: "Personne",
                column: "ReferentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personne");
        }
    }
}
