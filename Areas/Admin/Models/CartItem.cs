﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAnASP1.Areas.Admin.Models
{
    public class CartItem
    {
        public int quantity { set; get; }
        public SanPhamModels product { set; get; }
    }
}
