﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketShare.Models
{
    public class Tag
    {
        public int TagID { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}