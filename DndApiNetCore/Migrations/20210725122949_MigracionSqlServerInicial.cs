using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DndApiNetCore.Migrations
{
    public partial class MigracionSqlServerInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    IdJob = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTittle = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValueSql: "getDate()"),
                    LastUpdateDate = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValueSql: "getDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.IdJob);
                });

            migrationBuilder.CreateTable(
                name: "RelationShipType",
                columns: table => new
                {
                    IdRelationType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelationName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValueSql: "getDate()"),
                    LastUpdateDate = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValueSql: "getDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationShipType", x => x.IdRelationType);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    IdCharacter = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterType = table.Column<byte>(type: "TinyInt", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UrlImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdJob = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValueSql: "getDate()"),
                    LastUpdateDate = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValueSql: "getDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.IdCharacter);
                    table.ForeignKey(
                        name: "FK_Characters_Job_IdJob",
                        column: x => x.IdJob,
                        principalTable: "Job",
                        principalColumn: "IdJob",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RelationShip",
                columns: table => new
                {
                    IdRelation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCharacter = table.Column<int>(type: "int", nullable: false),
                    IdCharacter1 = table.Column<int>(type: "int", nullable: false),
                    IdRelationType = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValueSql: "getDate()"),
                    LastUpdateDate = table.Column<DateTime>(type: "DateTime", nullable: false, defaultValueSql: "getDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationShip", x => x.IdRelation);
                    table.ForeignKey(
                        name: "FK_RelationShip_Characters_IdCharacter",
                        column: x => x.IdCharacter,
                        principalTable: "Characters",
                        principalColumn: "IdCharacter",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelationShip_Characters_IdCharacter1",
                        column: x => x.IdCharacter1,
                        principalTable: "Characters",
                        principalColumn: "IdCharacter");
                    table.ForeignKey(
                        name: "FK_RelationShip_RelationShipType_IdRelationType",
                        column: x => x.IdRelationType,
                        principalTable: "RelationShipType",
                        principalColumn: "IdRelationType",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_IdJob",
                table: "Characters",
                column: "IdJob");

            migrationBuilder.CreateIndex(
                name: "IX_RelationShip_IdCharacter",
                table: "RelationShip",
                column: "IdCharacter");

            migrationBuilder.CreateIndex(
                name: "IX_RelationShip_IdCharacter1",
                table: "RelationShip",
                column: "IdCharacter1");

            migrationBuilder.CreateIndex(
                name: "IX_RelationShip_IdRelationType",
                table: "RelationShip",
                column: "IdRelationType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelationShip");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "RelationShipType");

            migrationBuilder.DropTable(
                name: "Job");
        }
    }
}
