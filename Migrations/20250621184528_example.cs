using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace david.Migrations
{
    /// <inheritdoc />
    public partial class example : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    Pkciudad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.Pkciudad);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Pkpersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false),
                    Apellido = table.Column<string>(type: "longtext", nullable: false),
                    Correo = table.Column<string>(type: "longtext", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Fkciudad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Pkpersona);
                    table.ForeignKey(
                        name: "FK_Persona_Ciudades_Fkciudad",
                        column: x => x.Fkciudad,
                        principalTable: "Ciudades",
                        principalColumn: "Pkciudad",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_Fkciudad",
                table: "Persona",
                column: "Fkciudad");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Ciudades");
        }
    }
}
