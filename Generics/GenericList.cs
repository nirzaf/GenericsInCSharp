using System;

namespace Generics
{
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index] => throw new NotImplementedException();
    }
}