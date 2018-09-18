using System;
using System.Text;

namespace vars
{
    class Program
    {
        //var cualquiera; //Error: solo como variables locales
        static void Main(string[] args)
        {
            var numeroElementos = 50;
            var otroNumero = 5L;
            object objetito ="object";
            objetito =78;
            var nombre = "Pirulo";
            var x = nombre + numeroElementos; //string + int = string
            var xz = numeroElementos + nombre; //string + int = string
            var y = numeroElementos + otroNumero; //int +long
            var sb = new StringBuilder();
            var buenEstudiante = new Persona("Osvaldo");

            //var indeciso = null; //Error
        }
    }
}
