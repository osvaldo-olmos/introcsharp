class Coordenada
{
    public int x, y;

    // constructor predeterminado
    public Coordenada()
    {
        x = 0;
        y = 0;
    }

    public Coordenada(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    //Encadenamiento de constructores
    public Coordenada(int x) : this(x, 0)
    {
    }

    ~Coordenada()
    {

    }
}