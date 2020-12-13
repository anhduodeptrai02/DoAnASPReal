using Microsoft.EntityFrameworkCore.Migrations;

namespace DoAnASP1.Migrations
{
    public partial class sp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maloai = table.Column<int>(type: "int", nullable: false),
                    imel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.id);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSanPham_maloai",
                        column: x => x.maloai,
                        principalTable: "LoaiSanPham",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_maloai",
                table: "SanPham",
                column: "maloai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");
        }
    }
}
