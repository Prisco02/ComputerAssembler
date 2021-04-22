using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCshop
{
    public abstract class Archive : Component
    {
        private int _GB;
        private double _write;
        private double _read;

        public int GB { get => _GB; set => _GB= value; }
        public double Write { get => _write; set => _write = value; }
        public double Read { get => _read; set => _read = value; }

        public Archive() : base() { }
    }
}
