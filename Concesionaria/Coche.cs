using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS8600, CS8602, CS8603

namespace Concesionaria
{
    public class Coche
    {
        private int _id;
        private string _marca;
        private string _modelo;
        private double _km;
        private int _precio;

        public Coche(int id, string marca, string modelo, double km, int precio)
        {
            this._id = id;
            this._marca = marca;
            this._modelo = modelo;
            this._km = km;
            this._precio = precio;
        }
        public int id { get => _id; set => _id = value; }
        public string marca { get => _marca; set => _marca = value; }
        public string modelo { get => _modelo; set => _modelo = value; }
        public double km { get => _km; set => _km = value; }
        public int precio { get => _precio; set => _precio = value; }

        public void CaracteristicasCoche()
        {           
            Console.WriteLine($"ID del Coche:{id}");
            Console.WriteLine($"Precio del Coche:{precio}");
            Console.WriteLine($"Marca del Coche:{marca}");
            Console.WriteLine($"Modelo del Coche:{modelo}");
            Console.WriteLine($"KM del Coche:{km}");
        }
    }
}
