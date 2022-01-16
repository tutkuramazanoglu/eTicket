using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eTicket.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProfilePictureURL = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Bip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorID);
                });

            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    CinemaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LogoURL = table.Column<string>(nullable: true),
                    CinemaName = table.Column<string>(nullable: true),
                    CinemaDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.CinemaID);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    ProducerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProducerProfilePictureURL = table.Column<string>(nullable: true),
                    ProducerFullName = table.Column<string>(nullable: true),
                    ProducerBio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.ProducerID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MovieName = table.Column<string>(nullable: true),
                    MovieDesc = table.Column<string>(nullable: true),
                    MovieURL = table.Column<string>(nullable: true),
                    MoviePrice = table.Column<double>(nullable: false),
                    MoiveStartDate = table.Column<DateTime>(nullable: false),
                    MovieEndDate = table.Column<DateTime>(nullable: false),
                    MovieCategory = table.Column<int>(nullable: false),
                    CinemaID = table.Column<int>(nullable: false),
                    ProducerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_Movies_Cinemas_CinemaID",
                        column: x => x.CinemaID,
                        principalTable: "Cinemas",
                        principalColumn: "CinemaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Producers_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "Producers",
                        principalColumn: "ProducerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actors_Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false),
                    ActorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors_Movies", x => new { x.ActorID, x.MovieID });
                    table.ForeignKey(
                        name: "FK_Actors_Movies_Actors_ActorID",
                        column: x => x.ActorID,
                        principalTable: "Actors",
                        principalColumn: "ActorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Actors_Movies_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actors_Movies_MovieID",
                table: "Actors_Movies",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaID",
                table: "Movies",
                column: "CinemaID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerID",
                table: "Movies",
                column: "ProducerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actors_Movies");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Cinemas");

            migrationBuilder.DropTable(
                name: "Producers");
        }
    }
}
