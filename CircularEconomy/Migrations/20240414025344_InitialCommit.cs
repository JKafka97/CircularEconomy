using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CircularEconomy.Migrations
{
    /// <inheritdoc />
    public partial class InitialCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Place",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PlaceActivity = table.Column<int>(type: "INTEGER", nullable: true),
                    ActivityOption = table.Column<int>(type: "INTEGER", nullable: true),
                    Contact = table.Column<string>(type: "TEXT", nullable: true),
                    Vyvoz = table.Column<string>(type: "TEXT", nullable: true),
                    Vlastnik = table.Column<string>(type: "TEXT", nullable: true),
                    ICO = table.Column<string>(type: "TEXT", nullable: true),
                    Popis = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    TypeTag = table.Column<int>(type: "INTEGER", nullable: true),
                    Ulice = table.Column<string>(type: "TEXT", nullable: true),
                    CisloPopisne = table.Column<string>(type: "TEXT", nullable: true),
                    PSC = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Place", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Place");
        }
    }
}
