using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskDrectorDataAccess.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Debtor",
                table: "Debtor");

            migrationBuilder.RenameTable(
                name: "Debtor",
                newName: "Debtors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Debtors",
                table: "Debtors",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Debtors",
                table: "Debtors");

            migrationBuilder.RenameTable(
                name: "Debtors",
                newName: "Debtor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Debtor",
                table: "Debtor",
                column: "Id");
        }
    }
}
