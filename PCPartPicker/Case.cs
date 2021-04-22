using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCshop
{

    public class Case : Component
    {
        private double _hight;
        private double _width;

        public double Hight { get => _hight; set => _hight = value; }
        public double Width { get => _width; set => _width = value; }

        public Case() : base() { }
    }
}
