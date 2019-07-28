﻿using System;

/*
 * Genericos vs Interfaces
 */
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

    public class GenericContainer<T>
    {
        public T Content { get; }

        public GenericContainer(T content)
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

            //Bar myBar =otherContainer.Content; Error
            Bar myBar =(Bar)otherContainer.Content; // Unboxing

            //Approach con generics
            GenericContainer<Bar> tercerContenedor =new GenericContainer<Bar>(new Bar());
            Bar otherBar =tercerContenedor.Content; //Todo joya. Y sin unboxing

        }
    }
}
