using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS8600, CS8602, CS8603, CS8604

namespace Concesionaria
{
     public class Concesionario
    {
        public List<Coche> _Coches = new List<Coche>()
        { new Coche(1, "Audi", "1987", 12700, 200000), new Coche(2,"Fiat", "1998",12313,150000),new Coche(3,"Volkswagen", "2012",10000,30000) };

        public void AniadirCoche(Coche oCoche)
        {
            _Coches.Add(oCoche);
        }
        public void MostrarCoche()
        {
            foreach(var Coche in _Coches)
            {
                Coche.CaracteristicasCoche();
                Console.WriteLine();
            }
        }
        public void VaciarCoche()
        {
            Console.WriteLine("Entre a borrar coche");
            this._Coches.Clear();
        }
        public void EliminarCoche()
        {
            Console.WriteLine("Escriba el Iddddd del coche que quieres eliminar:");
            string IDX = Console.ReadLine();
            int ID = int.Parse(IDX);
            for(int i = 0; i < _Coches.Count; i++) 
            {
                if (_Coches[i].id == ID)
                {
                    _Coches.RemoveAt(i);
                }
            }          
        }

    }
}
