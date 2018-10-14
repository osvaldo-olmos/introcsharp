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
        Console.WriteLine("Descartable Doing Something.");;
    }
}