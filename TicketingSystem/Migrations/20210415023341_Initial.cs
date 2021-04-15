using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketingSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sprints",
                columns: table => new
                {
                    SprintId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprints", x => x.SprintId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    PointValue = table.Column<string>(nullable: false),
                    SprintId = table.Column<string>(nullable: false),
                    StatusId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Sprints_SprintId",
                        column: x => x.SprintId,
                        principalTable: "Sprints",
                        principalColumn: "SprintId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sprints",
                columns: new[] { "SprintId", "Name" },
                values: new object[,]
                {
                    { "janone", "JanOne" },
                    { "dectwo", "DecTwo" },
                    { "decone", "DecOne" },
                    { "novtwo", "NovTwo" },
                    { "novone", "NovOne" },
                    { "octtwo", "OctTwo" },
                    { "octone", "OctOne" },
                    { "septwo", "SepTwo" },
                    { "sepone", "SepOne" },
                    { "augtwo", "AugTwo" },
                    { "augone", "AugOne" },
                    { "julone", "JulOne" },
                    { "jultwo", "JulTwo" },
                    { "junone", "JunOne" },
                    { "maytwo", "MayTwo" },
                    { "mayone", "MayOne" },
                    { "aprtwo", "AprTwo" },
                    { "aprone", "AprOne" },
                    { "martwo", "MarTwo" },
                    { "marone", "MarOne" },
                    { "febtwo", "FebTwo" },
                    { "febone", "FebOne" },
                    { "jantwo", "JanTwo" },
                    { "juntwo", "JunTwo" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "Name" },
                values: new object[,]
                {
                    { "qualityassurance", "Quality Assurance" },
                    { "todo", "To Do" },
                    { "inprogress", "In Progress" },
                    { "done", "Done" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SprintId",
                table: "Tickets",
                column: "SprintId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StatusId",
                table: "Tickets",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Sprints");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
