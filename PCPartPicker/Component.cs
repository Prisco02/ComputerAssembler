using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCshop
{
    public abstract class Component
    {
        private string _name;
        private double _price;
        private int _power;


        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public int Power { get => _power; set => _power = value; }

        public Component(string nome, double prezzo, int consumo) : base()
        {
            Name = nome;
            Price = prezzo;
            Power = consumo;
        }

        public Component(string nome, double prezzo) : this(nome, prezzo, 0) { }
        public Component(string nome) : this(nome, 0, 0) { }
        public Component() : this("null", 0, 0) { }
    }

    public enum StandardDimension
    {
        MiniITX,
        MicroATX,
        MiniATX,
        ATX,
        eATX
    }
}
