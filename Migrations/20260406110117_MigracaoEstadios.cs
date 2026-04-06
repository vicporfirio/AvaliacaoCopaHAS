using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CopaHAS.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoEstadios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ESTADIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Capacidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ESTADIOS", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_ESTADIOS",
                columns: new[] { "Id", "Capacidade", "Cidade", "Nome" },
                values: new object[,]
                {
                    { 1, 600000, "São Paulo 1", "Neo Quimica 1" },
                    { 2, 600000, "São Paulo 2", "Neo Quimica 2" },
                    { 3, 600000, "São Paulo 3", "Neo Quimica 3" },
                    { 4, 600000, "São Paulo 4", "Neo Quimica 4" },
                    { 5, 600000, "São Paulo 5", "Neo Quimica 5" },
                    { 6, 600000, "São Paulo 6", "Neo Quimica 6" },
                    { 7, 600000, "São Paulo 7", "Neo Quimica 7" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ESTADIOS");
        }
    }
}
