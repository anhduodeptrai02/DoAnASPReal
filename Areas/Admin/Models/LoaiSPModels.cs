using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnASP1.Areas.Admin.Models
{
    public class LoaiSPModels
    {
        [Key]
        public int MaLoai { get; set; }
        public string Ten { get; set; }
        public ICollection<SanPhamModels> LstSanPham { get; set; }
    }
}
