using Microsoft.EntityFrameworkCore.Migrations;

namespace eTicket.Migrations
{
    public partial class ActorBioFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Bip",
                table: "Actors",
                newName: "Bio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Bio",
                table: "Actors",
                newName: "Bip");
        }
    }
}
