using System;

namespace Genericos4
{
    public interface IFoo
    {
        
    }
    public class Foo : IFoo
    {
    }

    public class Bar : IFoo
    {
    }

    public class GenericContainer<T> where T : IFoo{
        public T Content {get;}

        public GenericContainer(T content){
            Content = content;
        }
    }

    public class Container{
        public IFoo Content {get;}

        public Container(IFoo content){
            Content = content;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            GenericContainer<Foo> fooContainer =new GenericContainer<Foo>(new Foo());
            Foo foo =fooContainer.Content;

            GenericContainer<Bar> barContainer =new GenericContainer<Bar>(new Bar());
            Bar bar =barContainer.Content;

            Container otherContainer =new Container(new Bar());
            //Estoy forzado a castear
            Bar otherBar =(Bar)otherContainer.Content;


        }
    }
}
