using System;

namespace OOP
{
class Program
{
    static void Main()
    {
        Coche miCoche;
        miCoche = new CocheAceleradorAvanzado("Peugeot", "306", "Azul", "54668742635");
        miCoche.Acelerar(100);

	}
}

}
