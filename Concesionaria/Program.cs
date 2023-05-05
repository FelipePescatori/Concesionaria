using Concesionaria;
#pragma warning disable CS8600, CS8602, CS8603

Concesionario oConcesionaria = new Concesionario();
oConcesionaria.MostrarCoche();

Coche oCoche = new Coche(4, "nazi", "1999", 1300, 20000); //Creamos una tipo de coche para podes añadirlo
oConcesionaria.AniadirCoche(oCoche); //Aca se lo añado
Console.WriteLine("Mostrar coches añadidos");
oConcesionaria.MostrarCoche();
oConcesionaria.EliminarCoche();

Console.WriteLine("Mostrar sin eliminados");
oConcesionaria.MostrarCoche();





