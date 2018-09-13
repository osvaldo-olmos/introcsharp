﻿using System;

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

    public class Container
    {
        public IFoo Content { get; }

        public Container(IFoo content)
        {
            Content = content;
        }
    }

    public class Contenedor<T>
    {
        public T Content { get; }

        public Contenedor(T content)
        {
            Content = content;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Container container =new Container(new Foo());
            Container otherContainer =new Container(new Bar());

            Contenedor<Bar> tercerContenedor =new Contenedor<Bar>(new Bar());
            Bar otherBar =tercerContenedor.Content;

        }
    }
}
