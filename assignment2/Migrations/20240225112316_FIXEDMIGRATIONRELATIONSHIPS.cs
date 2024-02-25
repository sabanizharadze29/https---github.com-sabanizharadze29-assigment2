using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assignment2.Migrations
{
    public partial class FIXEDMIGRATIONRELATIONSHIPS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Person_Id",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Email_Person_Id",
                table: "Email");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_Person_Id",
                table: "PhoneNumber");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PhoneNumber",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "PhoneNumber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Email",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Email",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Address",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PersonId",
                table: "PhoneNumber",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Email_PersonId",
                table: "Email",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_PersonId",
                table: "Address",
                column: "PersonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Person_PersonId",
                table: "Address",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Email_Person_PersonId",
                table: "Email",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_Person_PersonId",
                table: "PhoneNumber",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Person_PersonId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Email_Person_PersonId",
                table: "Email");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_Person_PersonId",
                table: "PhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_PhoneNumber_PersonId",
                table: "PhoneNumber");

            migrationBuilder.DropIndex(
                name: "IX_Email_PersonId",
                table: "Email");

            migrationBuilder.DropIndex(
                name: "IX_Address_PersonId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "PhoneNumber");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Email");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Address");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PhoneNumber",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Email",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Address",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Person_Id",
                table: "Address",
                column: "Id",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Email_Person_Id",
                table: "Email",
                column: "Id",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_Person_Id",
                table: "PhoneNumber",
                column: "Id",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
