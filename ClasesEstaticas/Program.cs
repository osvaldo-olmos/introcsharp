using System;

namespace ClasesEstaticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GeneralInfo.CompanyName());
            Console.WriteLine(GeneralInfo.Address());
            Console.WriteLine(GeneralInfo.YearOfCreation());
        }
    }
}
