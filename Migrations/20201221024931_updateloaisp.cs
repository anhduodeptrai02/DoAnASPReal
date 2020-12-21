using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAnASP1.Migrations
{
    public partial class updateloaisp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TT",
                table: "LoaiSanPham",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TT",
                table: "LoaiSanPham");
        }
    }
}
