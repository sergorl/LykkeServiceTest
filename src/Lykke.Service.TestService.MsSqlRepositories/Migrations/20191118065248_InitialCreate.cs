using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lykke.Service.TestService.MsSqlRepositories.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "foo");

            migrationBuilder.CreateTable(
                name: "AgentRegister",
                schema: "foo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentRegister", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgentRegister_Id",
                schema: "foo",
                table: "AgentRegister",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgentRegister",
                schema: "foo");
        }
    }
}
