using System;

namespace Genericos2
{
    public class Stack
    {
        int _size;
        int _puntero = 0;
        object[] _items;
        public Stack(int size)
        {
            _size = size;
            _items = new object[_size];
        }
        public void Push(object item)
        {
            if (_puntero >= _size)
                throw new StackOverflowException();
            _items[_puntero] = item;
            _puntero++;
        }
        public object Pop()
        {
            _puntero--;
            if (_puntero >= 0)
            {
                return _items[_puntero];
            }
            else
            {
                _puntero = 0;
                throw new InvalidOperationException("El stack esta vacio. No puedo hacer Pop");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Stack stack = new Stack(3);

            //Boxing implicito porque el argumento que le paso es un int y se va a manejar como object
            //stack.Push(1);
            //stack.Push(2);
            
            // No es type safe esta pila
            //stack.Push("jaramillo");


            //Se necesita unboxing   
            //int number = (int)stack.Pop();
            
            GenericStack<int> stack = new GenericStack<int>(3);
            stack.Push(1);
            stack.Push(2);
            
            //Esta lista es type safe !!!
            //stack.Push("sarasa");

            int number =stack.Pop(); 
            Console.WriteLine(number);

        }

        static void InformarTipo<T>()
        {
            var a = typeof(T);
            Console.WriteLine(a.Name);
        }
    }
}
