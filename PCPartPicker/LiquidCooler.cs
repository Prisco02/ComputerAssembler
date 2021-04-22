using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCshop
{
    public class LiquidCooler : Cooler
    {
        private int _mm;

        public int Mm { get => _mm; set => _mm = value; }

        public LiquidCooler() : base() { }
    }
}
