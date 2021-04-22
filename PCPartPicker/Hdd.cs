using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCshop
{
    public class Hdd : Archive
    {
        private int _disks;

        public int Discs { get => _disks; set => _disks = value; }

        public Hdd() : base() { }
    }
}
