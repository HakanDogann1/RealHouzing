using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealHouzing.DataAccessLAyer.Migrations
{
    public partial class mig_newTable_Properties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "Properties4");

            migrationBuilder.RenameTable(
                name: "Propertys3",
                newName: "Properties3");

            migrationBuilder.RenameTable(
                name: "Propertys2",
                newName: "Properties2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties4",
                table: "Properties4",
                column: "Property4ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties3",
                table: "Properties3",
                column: "Property3ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties2",
                table: "Properties2",
                column: "Property2ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties4",
                table: "Properties4");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties3",
                table: "Properties3");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties2",
                table: "Properties2");

            migrationBuilder.RenameTable(
                name: "Properties4",
                newName: "Propertys4");

            migrationBuilder.RenameTable(
                name: "Properties3",
                newName: "Propertys3");

            migrationBuilder.RenameTable(
                name: "Properties2",
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
    }
}
