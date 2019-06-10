public abstract class A
{
    public abstract void F();
}

abstract public class B: A
{
    public void G()
    {
    }
}

class C: B
{
    public override void F()
    {
        
    }
}
