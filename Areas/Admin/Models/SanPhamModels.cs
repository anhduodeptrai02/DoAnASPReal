using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnASP1.Areas.Admin.Models
{
    public class SanPhamModels
    {
        public int id { get; set; }
        public string ten { get; set; }
        public string img { get; set; }
        public string gia { get; set; }
        public int maloai { get; set; }
        public string imel { get; set; }
        [ForeignKey("maloai")]
        public virtual LoaiSPModels loai { get; set; }
    }
}
