using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dominio_Fermentación.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutomationDevices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Estado = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutomationDevices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Batch",
                columns: table => new
                {
                    Initial_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Final_Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Namelote = table.Column<string>(type: "text", nullable: false),
                    producto = table.Column<int>(type: "integer", nullable: false),
                    Etapa_Proceso = table.Column<int>(type: "integer", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batch", x => new { x.Initial_Date, x.Final_Date });
                });

            migrationBuilder.CreateTable(
                name: "StateChangeRecords",
                columns: table => new
                {
                    EquipmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    OccurringTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    NewState = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateChangeRecords", x => new { x.EquipmentId, x.OccurringTime });
                });

            migrationBuilder.CreateTable(
                name: "Programmable_Logic_Controller",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programmable_Logic_Controller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Programmable_Logic_Controller_AutomationDevices_Id",
                        column: x => x.Id,
                        principalTable: "AutomationDevices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutomationDeviceUnidad",
                columns: table => new
                {
                    AutomationDevicesId = table.Column<Guid>(type: "uuid", nullable: false),
                    UnidadesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutomationDeviceUnidad", x => new { x.AutomationDevicesId, x.UnidadesId });
                    table.ForeignKey(
                        name: "FK_AutomationDeviceUnidad_AutomationDevices_AutomationDevicesId",
                        column: x => x.AutomationDevicesId,
                        principalTable: "AutomationDevices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Operations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UnitId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unitdades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Estado = table.Column<int>(type: "integer", nullable: false),
                    ActiveOperationId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unitdades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unitdades_Operations_ActiveOperationId",
                        column: x => x.ActiveOperationId,
                        principalTable: "Operations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Variables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UnitId = table.Column<Guid>(type: "uuid", nullable: false),
                    Medicion = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variables_Unitdades_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Unitdades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutomationDeviceUnidad_UnidadesId",
                table: "AutomationDeviceUnidad",
                column: "UnidadesId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_UnitId",
                table: "Operations",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Unitdades_ActiveOperationId",
                table: "Unitdades",
                column: "ActiveOperationId");

            migrationBuilder.CreateIndex(
                name: "IX_Variables_UnitId",
                table: "Variables",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutomationDeviceUnidad_Unitdades_UnidadesId",
                table: "AutomationDeviceUnidad",
                column: "UnidadesId",
                principalTable: "Unitdades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Unitdades_UnitId",
                table: "Operations",
                column: "UnitId",
                principalTable: "Unitdades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Unitdades_UnitId",
                table: "Operations");

            migrationBuilder.DropTable(
                name: "AutomationDeviceUnidad");

            migrationBuilder.DropTable(
                name: "Batch");

            migrationBuilder.DropTable(
                name: "Programmable_Logic_Controller");

            migrationBuilder.DropTable(
                name: "StateChangeRecords");

            migrationBuilder.DropTable(
                name: "Variables");

            migrationBuilder.DropTable(
                name: "AutomationDevices");

            migrationBuilder.DropTable(
                name: "Unitdades");

            migrationBuilder.DropTable(
                name: "Operations");
        }
    }
}
