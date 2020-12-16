using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnASP1.Areas.Admin.Models
{
    public class HoaDon
    {
        [Key]
        public string MaHD { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
      
        public string TongTien { get; set; }
       
        [ForeignKey("MaCTHD")]
        public int MaCTHD { get; set; }
        public ICollection<CTHoaDon> CTHoaDon { get; set; }
    }

}
