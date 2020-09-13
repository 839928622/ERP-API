using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP_API.Migrations
{
    public partial class SetSys_UserUUID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Uuid",
                table: "Sys_Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "StocktakingAudit",
                table: "Sys_BranchSetting",
                nullable: false,
                defaultValueSql: "((0))");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Member",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uuid",
                table: "Sys_Users");

            migrationBuilder.DropColumn(
                name: "StocktakingAudit",
                table: "Sys_BranchSetting");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Member",
                type: "int",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
