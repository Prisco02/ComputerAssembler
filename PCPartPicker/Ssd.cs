using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCshop
{
    public class Ssd : Archive
    {
        private bool _mm;

        public bool MM { get => _mm; set => _mm = value; }

        public Ssd() : base() { }
    }
}
