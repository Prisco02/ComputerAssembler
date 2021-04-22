using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCshop
{
    public class AirCooler : Cooler
    {
        private int _towers;

        public int Towers { get => _towers; set => _towers = value; }

        public AirCooler() : base() { }
    }
}
