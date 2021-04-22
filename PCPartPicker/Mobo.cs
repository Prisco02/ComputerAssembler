using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCshop
{
    public class Mobo : Component
    {
        private string _socket;
        private bool _wifi;
        private StandardDimension _dimension;

        public string Socket { get => _socket; set => _socket = value; }

        public Mobo() : base() { }
    }
}
