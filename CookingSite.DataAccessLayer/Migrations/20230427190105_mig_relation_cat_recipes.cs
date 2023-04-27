using Microsoft.EntityFrameworkCore.Migrations;

namespace CookingSite.DataAccessLayer.Migrations
{
    public partial class mig_relation_cat_recipes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Recipess",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Recipess_CategoryID",
                table: "Recipess",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipess_Categories_CategoryID",
                table: "Recipess",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipess_Categories_CategoryID",
                table: "Recipess");

            migrationBuilder.DropIndex(
                name: "IX_Recipess_CategoryID",
                table: "Recipess");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Recipess");
        }
    }
}
