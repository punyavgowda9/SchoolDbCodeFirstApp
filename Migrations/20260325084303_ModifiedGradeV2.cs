using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolDbCodeFirstApp.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedGradeV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Section",
                schema: "School",
                table: "grades",
                newName: "grade_name");

            migrationBuilder.AlterColumn<string>(
                name: "grade_name",
                schema: "School",
                table: "grades",
                type: "Varchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "grade_name",
                schema: "School",
                table: "grades",
                newName: "Section");

            migrationBuilder.AlterColumn<string>(
                name: "Section",
                schema: "School",
                table: "grades",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(25)",
                oldMaxLength: 25);
        }
    }
}
