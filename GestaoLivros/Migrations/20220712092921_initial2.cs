using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoLivros.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Livros",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Isbn = table.Column<int>(type: "int", nullable: false),
                   Autor = table.Column<string>(type: "nvarchar(max)", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Livros", x => x.Id);
               });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "Livros");
        }
    }
}
