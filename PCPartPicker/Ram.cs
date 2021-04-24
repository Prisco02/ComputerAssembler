using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCshop
{
    public class Ram : Component
    {
        private int _GB;
        private int _Mhz;
        private int _ddrVersion;

        public int GB { get => _GB; set => _GB = value; }
        public int Mhz { get => _Mhz; set => _Mhz = value; }
        public int DdrVersion { get => _ddrVersion; set => _ddrVersion = value; }

        public Ram() : base() { }
    }
}
