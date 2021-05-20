using Microsoft.EntityFrameworkCore.Migrations;

namespace Tp_grades.Data.Migrations
{
    public partial class numbersasstring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Grade_average",
                table: "Student",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "Grade_3",
                table: "Student",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "Grade_2",
                table: "Student",
                nullable: true,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<string>(
                name: "Grade_1",
                table: "Student",
                nullable: true,
                oldClrType: typeof(float));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Grade_average",
                table: "Student",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Grade_3",
                table: "Student",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Grade_2",
                table: "Student",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Grade_1",
                table: "Student",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
