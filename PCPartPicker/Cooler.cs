using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCshop
{

    public abstract class Cooler : Component
    {
        private int _fans;
        private int _noise;

        public int Fans { get => _fans; set => _fans = value; }
        public int Noise { get => _noise; set => _noise = value; }

        public Cooler() : base() { }

    }
}
