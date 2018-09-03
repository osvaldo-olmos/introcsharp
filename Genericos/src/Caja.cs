using System;

namespace Genericos.src
{
    public class CajaLimitada<T> where T : struct
    {

    }

    public class CajaLimitada<X0, X1>
        where X0 : struct
        where X1 : IEquatable<X1>
    {

    }

    public class CajaLimitada<T, U, V>
        where T : struct
        where U : IEquatable<U>
        where V : new()
    {

    }

}