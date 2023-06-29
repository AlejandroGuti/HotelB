using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelB.Migrations
{
    /// <inheritdoc />
    public partial class RoomBed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mark",
                table: "Beds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "RoomBed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BedId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Quatity = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomBed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomBed_Beds_BedId",
                        column: x => x.BedId,
                        principalTable: "Beds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomBed_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoomBed_BedId",
                table: "RoomBed",
                column: "BedId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomBed_RoomId",
                table: "RoomBed",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomBed");

            migrationBuilder.DropColumn(
                name: "Mark",
                table: "Beds");
        }
    }
}
