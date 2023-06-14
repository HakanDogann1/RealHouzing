using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealHouzing.DataAccessLAyer.Migrations
{
    public partial class mig_newTable_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Property4s",
                table: "Property4s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property3s",
                table: "Property3s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property2s",
                table: "Property2s");

            migrationBuilder.RenameTable(
                name: "Property4s",
                newName: "Propertys4");

            migrationBuilder.RenameTable(
                name: "Property3s",
                newName: "Propertys3");

            migrationBuilder.RenameTable(
                name: "Property2s",
                newName: "Propertys2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Propertys4",
                table: "Propertys4",
                column: "Property4ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Propertys3",
                table: "Propertys3",
                column: "Property3ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Propertys2",
                table: "Propertys2",
                column: "Property2ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Propertys4",
                table: "Propertys4");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Propertys3",
                table: "Propertys3");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Propertys2",
                table: "Propertys2");

            migrationBuilder.RenameTable(
                name: "Propertys4",
                newName: "Property4s");

            migrationBuilder.RenameTable(
                name: "Propertys3",
                newName: "Property3s");

            migrationBuilder.RenameTable(
                name: "Propertys2",
                newName: "Property2s");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property4s",
                table: "Property4s",
                column: "Property4ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property3s",
                table: "Property3s",
                column: "Property3ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property2s",
                table: "Property2s",
                column: "Property2ID");
        }
    }
}
