using System;

namespace Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Celcius celcius = new Celcius(18);

            Kelvin kelvin = celcius;

            Console.WriteLine(kelvin.Klv + "K");


        }
    }

    public class Kelvin
    {
        public float Klv { get; set; }

        public Kelvin(float kelvin)
        {
            Klv = kelvin;
        }
    }

    public class Celcius
    {
        public float Clc { get; set; }

        public Celcius(float celcius)
        {
            Clc = celcius;
        }

        public static implicit operator Kelvin(Celcius celcius)
        {
            return new Kelvin(celcius.Clc + 270);
        }
    }
}
