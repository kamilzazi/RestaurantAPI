using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantAPI.Migrations
{
    public partial class InitMigrationWithAddress1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Addresses_AddressId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_AddressId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_RestaurantId",
                table: "Addresses");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_RestaurantId",
                table: "Addresses",
                column: "RestaurantId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Addresses_RestaurantId",
                table: "Addresses");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_AddressId",
                table: "Restaurants",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_RestaurantId",
                table: "Addresses",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Addresses_AddressId",
                table: "Restaurants",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
