﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akios.Domain.Entities
{
    public class Musteri
    {
        public int? MusteriId { get; set; }
        public string Kod { get; set; }
        public string YetkiliKisi { get; set; }
        public string Adi { get; set; }
        public string Adres { get; set; }
        public string Tel { get; set; }
        public string Mobil { get; set; }
        public string Faks { get; set; }
        public string Web { get; set; }
        public string Mail { get; set; }
        public byte[] LogoData { get; set; }
        public string LogoMimeType { get; set; }
    }
}
