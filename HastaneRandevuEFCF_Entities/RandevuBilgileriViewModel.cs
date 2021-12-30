﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuEFCF_Entities
{
    public class RandevuBilgileriViewModel
    {
        public int RandevuID { get; set; }
        public int DoktorID { get; set; }
        public Doktor Doktor { get; set; }
        public string DoktorAdSoyad { get; set; }
        public int HastaID { get; set; }
        public Hasta Hasta { get; set; }
        public string HastaAdSoyad { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public string Servis { get; set; }



    }
}
