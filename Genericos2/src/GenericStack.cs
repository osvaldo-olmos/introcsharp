using System;

namespace Genericos2
{
    public class GenericStack<T>
    {
        int _size;
        int _puntero = 0;
        T[] _items;
        public GenericStack(int size)
        {
            _size = size;
            _items = new T[_size];
        }
        public void Push(T item)
        {
            if (_puntero >= _size)
                throw new StackOverflowException();
            _items[_puntero] = item;
            _puntero++;
        }
        public T Pop()
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
}