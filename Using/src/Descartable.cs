using System;

public class Descartable : IDisposable
{
    bool is_disposed = false;
    private IDisposable databaseConnection;
    private IDisposable frameBufferImage;
    public void Dispose()
    {
        Dispose(true);
        // Le aviso al GC que no lo finalice
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (!is_disposed) // Solo si no esta Disposed
        {
            if (disposing)
            {
                Console.WriteLine("Liberando recursos manejados");
                //Ejemplos
                if (this.databaseConnection != null)
                {
                    this.databaseConnection.Dispose();
                    this.databaseConnection = null;
                }
                if (this.frameBufferImage != null)
                {
                    this.frameBufferImage.Dispose();
                    this.frameBufferImage = null;
                }
            }
            Console.WriteLine("Liberando recursos no manejados");
            //Ejemplo
            //Win32.DestroyHandle(this.CursorFileBitmapIconServiceHandle);
        }
        this.is_disposed = true;
    }

    public Descartable()
    {
        Console.WriteLine("Nuevo Descartable.");
    }

    public void DoSomething()
    {
        Console.WriteLine("Descartable Doing Something."); ;
    }
}