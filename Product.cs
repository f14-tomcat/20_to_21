﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MohammadpourAspNetCoreSaturdayMondayEvening.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int count { get; set; }
        public int price { get; set; }
        public byte[] img { get; set; }
        public byte[] imgThumbnail { get; set; }

        public ICollection<PurchasecartProduct> PurchasecartProducts { get; set; }

    }
}
