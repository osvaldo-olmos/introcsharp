using System;

namespace Genericos6
{
    public class Temperature : IComparable
    {
        // The temperature value
        protected double temperatureF;

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Temperature otherTemperature = obj as Temperature;
            if (otherTemperature != null)
                return this.temperatureF.CompareTo(otherTemperature.temperatureF);
            else
                throw new ArgumentException("Object is not a Temperature");
        }

        public double Fahrenheit
        {
            get
            {
                return this.temperatureF;
            }
            set
            {
                this.temperatureF = value;
            }
        }

        public double Celsius
        {
            get
            {
                return (this.temperatureF - 32) * (5.0 / 9);
            }
            set
            {
                this.temperatureF = (value * 9.0 / 5) + 32;
            }
        }
    }

    public class Temperatura : IComparable<Temperatura>
    {
        public double Fahrenheit {get; }

        public Temperatura(double fahrenheit)
        {
            Fahrenheit =fahrenheit;
        }
        public int CompareTo(Temperatura other)
        {
            return Fahrenheit.CompareTo(other.Fahrenheit);
        }
    }
}