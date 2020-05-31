using System;

namespace StringToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string nullInput =null;

            numero =Convert.ToInt32(nullInput);
            Console.WriteLine($"1. Numero: {numero}");            
            
            bool result =Int32.TryParse(nullInput, out numero);
            
            if(result){
                Console.WriteLine($"2. Numero: {numero}");
            }else{
                Console.WriteLine($"2. {nullInput} no es un numero");
            }

            numero =Int32.Parse(nullInput);
            Console.WriteLine($"2. Numero: {numero}"); 
        }
    }
}
