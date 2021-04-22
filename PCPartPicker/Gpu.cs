using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCshop
{
    public class Gpu : Component
    {
        private double _teraflops;
        private int _vram;
        private int _gddrVersion;

        public double Teraflops { get => _teraflops; set => _teraflops = value; }
        public int Vram { get => _vram; set => _vram = value; }
        public int Gddr { get => _gddrVersion; set => _gddrVersion = value; }

        public Gpu() : base() { }
    }
}
