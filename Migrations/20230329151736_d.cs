using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task2.Migrations
{
    /// <inheritdoc />
    public partial class d : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerTbs",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTbs", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "DroneLocationTbs",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DroneLocationTbs", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "DroneShotTbs",
                columns: table => new
                {
                    DronShotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DroneShotName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DurationInMinutes = table.Column<int>(type: "int", nullable: false),
                    MaxSpeedInMPH = table.Column<int>(type: "int", nullable: false),
                    MaxNumberOfPassengers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DroneShotTbs", x => x.DronShotId);
                });

            migrationBuilder.CreateTable(
                name: "BookingCustomerTbs",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    location_Id = table.Column<int>(type: "int", nullable: false),
                    drone_shot_id = table.Column<int>(type: "int", nullable: false),
                    CustomerTbCustomerId = table.Column<int>(type: "int", nullable: false),
                    DroneLocationTbLocationId = table.Column<int>(type: "int", nullable: false),
                    DroneShotTbDronShotId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteBy = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingCustomerTbs", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_BookingCustomerTbs_CustomerTbs_CustomerTbCustomerId",
                        column: x => x.CustomerTbCustomerId,
                        principalTable: "CustomerTbs",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingCustomerTbs_DroneLocationTbs_DroneLocationTbLocationId",
                        column: x => x.DroneLocationTbLocationId,
                        principalTable: "DroneLocationTbs",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingCustomerTbs_DroneShotTbs_DroneShotTbDronShotId",
                        column: x => x.DroneShotTbDronShotId,
                        principalTable: "DroneShotTbs",
                        principalColumn: "DronShotId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingCustomerTbs_CustomerTbCustomerId",
                table: "BookingCustomerTbs",
                column: "CustomerTbCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingCustomerTbs_DroneLocationTbLocationId",
                table: "BookingCustomerTbs",
                column: "DroneLocationTbLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingCustomerTbs_DroneShotTbDronShotId",
                table: "BookingCustomerTbs",
                column: "DroneShotTbDronShotId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingCustomerTbs");

            migrationBuilder.DropTable(
                name: "CustomerTbs");

            migrationBuilder.DropTable(
                name: "DroneLocationTbs");

            migrationBuilder.DropTable(
                name: "DroneShotTbs");
        }
    }
}
