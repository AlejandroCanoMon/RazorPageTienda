using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPageTienda.Migrations
{
    public partial class New_DataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
           name: "Name",
           table: "Movie",
           maxLength: 60,
           nullable: false,
           oldClrType: typeof(string),
           oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Movie",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
