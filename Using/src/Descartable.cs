using System;

public class Descartable : IDisposable
{
    public Descartable()
    {
        Console.WriteLine("Nuevo Descartable.");
    }
    public void Dispose()
    {
        Console.WriteLine("Dispose de Descartable ejecutado.");

    }

    public void DoSomething()
    {
        //throw new ApplicationException("Excepcion !");
        Console.WriteLine("Descartable Doing Something.");;
    }
}