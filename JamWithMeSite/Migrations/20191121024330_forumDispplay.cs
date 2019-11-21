using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JamWithMeSite.Migrations
{
    public partial class forumDispplay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ForumNameId",
                table: "Posts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ForumListingModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumListingModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_ForumNameId",
                table: "Posts",
                column: "ForumNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_ForumListingModel_ForumNameId",
                table: "Posts",
                column: "ForumNameId",
                principalTable: "ForumListingModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_ForumListingModel_ForumNameId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "ForumListingModel");

            migrationBuilder.DropIndex(
                name: "IX_Posts_ForumNameId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ForumNameId",
                table: "Posts");
        }
    }
}
