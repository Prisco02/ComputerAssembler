using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCshop
{
    public class Cpu : Component
    {
        private int _core;
        private double _Ghz;
        private string _socket;
        private double _cache;

        public int Core { get => _core; set => _core = value; }
        public double Ghz { get => _Ghz; set => _Ghz = value; }
        public string Socket { get => _socket; set => _socket = value; }
        public double Cache { get => _cache; set => _cache = value; }

        public Cpu() : base() { }
    }
}
