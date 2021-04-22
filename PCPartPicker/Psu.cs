using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCshop
{
    public class Psu : Component
    {
        private string _quality;

        public string Quality { get => _quality; set => _quality = value; }

        public Psu() : base() { }
    }
}
