using System;
using System.Collections.Generic;

#nullable disable

namespace CARSDATASET.Models
{
    public partial class Car
    {
        public int Id { get; set; }
        public string CarModel { get; set; }
        public double Mpg { get; set; }
        public byte Cyl { get; set; }
        public double Disp { get; set; }
        public short Hp { get; set; }
        public double Drat { get; set; }
        public double Wt { get; set; }
        public double Qsec { get; set; }
        public bool Vs { get; set; }
        public bool Am { get; set; }
        public byte Gear { get; set; }
        public byte Carb { get; set; }
    }
}
