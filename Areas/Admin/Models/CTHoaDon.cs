using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnASP1.Areas.Admin.Models
{
    public class CTHoaDon
    {
        [Key]
        public int MaCTHD { get; set; }
        [ForeignKey("MaSP")]
        public int MaSP { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPhamModels SanPham { get; set; }
    }
}
