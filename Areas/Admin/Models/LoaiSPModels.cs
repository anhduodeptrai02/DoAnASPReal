using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnASP1.Areas.Admin.Models
{
    public class LoaiSPModels
    {
        public int id { get; set; }
        public string ten { get; set; }
        public ICollection<SanPhamModels> lstSanPham { get; set; }
    }
}
