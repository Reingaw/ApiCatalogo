using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Categorias(Nome, ImagemUrl) VALUES ('Bebidas', 'bebida.jpg')");
            mb.Sql("INSERT INTO Categorias(Nome, ImagemUrl) VALUES ('Lanches', 'lanche.jpg')");
            mb.Sql("INSERT INTO Categorias(Nome, ImagemUrl) VALUES ('Sobremesas', 'sobremesas.jpg')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Categorias");
        }
    }
}
