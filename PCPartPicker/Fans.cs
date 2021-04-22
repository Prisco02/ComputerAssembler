using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCshop
{
    public class Fans : Component
    {
        private int _RPM;
        private bool _RGB;
        private int _noise;

        public int RPM { get => _RPM; set => _RPM = value; }
        public bool RGB { get => _RGB; set => _RGB = value; }
        public int Noise { get => _noise; set => _noise = value; }

        public Fans() : base() { }
    }
}
