using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DoAnASP1.Areas.Admin.Models;
namespace DoAnASP1.Areas.Admin.Data
{
    public class DPcontext : DbContext
    {
        public DPcontext(DbContextOptions<DPcontext> options)
            : base(options)
        {
        }

        public DbSet<SanPhamModels> SanPham { get; set; }
        public DbSet<LoaiSPModels> LoaiSanPham { get; set; }
        public DbSet<DoAnASP1.Areas.Admin.Models.CTHoaDon> CTHoaDon { get; set; }
        public DbSet<DoAnASP1.Areas.Admin.Models.HoaDon> HoaDon { get; set; }
        public DbSet<DoAnASP1.Areas.Admin.Models.NCC> NCC { get; set; }
        public DbSet<DoAnASP1.Areas.Admin.Models.User> User { get; set; }

    }
}
