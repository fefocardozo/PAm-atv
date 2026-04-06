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
                    Capacidade = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
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
                    { 1, "78838", "Rio de Janeiro", "Maracaña" },
                    { 2, "49205", "São Paulo", "Neo Química Arena" },
                    { 3, "61842", "Belo Horizonte", "Mineirão" },
                    { 4, "50842", "Porto Alegre", "Beira Rio" },
                    { 5, "50000", "Salvador", "Arena Fonte Nova" },
                    { 6, "44000", "Manaus", "Arena da Amazônia" },
                    { 7, "72788", "Brasília", "Mané Garrincha" }
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
