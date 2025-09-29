using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMEAdapter.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductDocumentWithOwnedTypesNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "ProductDocuments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Data",
                table: "ProductDocuments",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Classification_ClassDescription",
                table: "ProductDocuments",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Classification_ClassId",
                table: "ProductDocuments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Classification_ClassLang",
                table: "ProductDocuments",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Classification_ClassName",
                table: "ProductDocuments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Classification_ClassificationSystem",
                table: "ProductDocuments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Identifier_DomainId",
                table: "ProductDocuments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Identifier_ValueId",
                table: "ProductDocuments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Version_Keywords",
                table: "ProductDocuments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Version_Language",
                table: "ProductDocuments",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Version_OrganisationName",
                table: "ProductDocuments",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Version_OrganisationOfficialName",
                table: "ProductDocuments",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Version_State",
                table: "ProductDocuments",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Version_StateDate",
                table: "ProductDocuments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Version_Summary",
                table: "ProductDocuments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Version_Title",
                table: "ProductDocuments",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Version_Version",
                table: "ProductDocuments",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Classification_ClassDescription",
                table: "ProductDocuments");

            migrationBuilder.DropColumn(
                name: "Classification_ClassId",
                table: "ProductDocuments");

            migrationBuilder.DropColumn(
                name: "Classification_ClassLang",
                table: "ProductDocuments");

            migrationBuilder.DropColumn(
                name: "Classification_ClassName",
                table: "ProductDocuments");

            migrationBuilder.DropColumn(
                name: "Classification_ClassificationSystem",
                table: "ProductDocuments");

            migrationBuilder.DropColumn(
                name: "Identifier_DomainId",
                table: "ProductDocuments");

            migrationBuilder.DropColumn(
                name: "Identifier_ValueId",
                table: "ProductDocuments");

            migrationBuilder.DropColumn(
                name: "Version_Keywords",
                table: "ProductDocuments");

            migrationBuilder.DropColumn(
                name: "Version_Language",
                table: "ProductDocuments");

            migrationBuilder.DropColumn(
                name: "Version_OrganisationName",
                table: "ProductDocuments");

            migrationBuilder.DropColumn(
                name: "Version_OrganisationOfficialName",
                table: "ProductDocuments");

            migrationBuilder.DropColumn(
                name: "Version_State",
                table: "ProductDocuments");

            migrationBuilder.DropColumn(
                name: "Version_StateDate",
                table: "ProductDocuments");

            migrationBuilder.DropColumn(
                name: "Version_Summary",
                table: "ProductDocuments");

            migrationBuilder.DropColumn(
                name: "Version_Title",
                table: "ProductDocuments");

            migrationBuilder.DropColumn(
                name: "Version_Version",
                table: "ProductDocuments");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProductId",
                table: "ProductDocuments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Data",
                table: "ProductDocuments",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");
        }
    }
}
