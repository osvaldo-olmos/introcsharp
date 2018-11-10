using System;

namespace ConstructoresYDestructores.src
{
    abstract class Forma
    {
        public const double pi = Math.PI;
        protected double x, y;

        public Forma(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract double Area();
    }

    class Circulo : Forma
    {
        public Circulo(double radio)
            : base(radio, 0)
        {
        }
        // Area del circulo: PI * radio ^ 2
        public override double Area()
        {
            return pi * Math.Pow(x,2);
        }
    }

    class Cilindro : Circulo
    {
        public Cilindro(double radio, double altura)
            : base(radio)
        {
            y = altura;
        }

        //Area de un cilindro: 2 * Area del circulo + Area del rectangulo
        //Area rectangulo = base * altura. En este caso, la base es el
        //perimetro de los circulos
        public override double Area()
        {
            return (2 * base.Area()) + (2 * pi * x * y);
        }
    }

}