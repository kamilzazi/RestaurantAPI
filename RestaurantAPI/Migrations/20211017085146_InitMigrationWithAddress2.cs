using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantAPI.Migrations
{
    public partial class InitMigrationWithAddress2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Restaurants_RestaurantId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_RestaurantId",
                table: "Addresses");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_AddressId",
                table: "Restaurants",
                column: "AddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Addresses_AddressId",
                table: "Restaurants",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Addresses_AddressId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_AddressId",
                table: "Restaurants");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_RestaurantId",
                table: "Addresses",
                column: "RestaurantId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Restaurants_RestaurantId",
                table: "Addresses",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
