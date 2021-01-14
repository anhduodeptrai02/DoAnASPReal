using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnASP1.Areas.Admin.Models
{
    public class SanPhamViewModels
    {
        public List<SanPhamModels> SanPhams { get; set; }
        public SelectList SPs { get; set; }
        public string SanPham { get; set; }
        public string SearchString { get; set; }
    }
}
