using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle car1 = new Vehicle() //it is possible because as parent class is abstract

            Corsa car2 = new Corsa();
            Console.WriteLine(car2.wheels);

            Console.ReadLine();
        }
    }

    //Q1: what is an abstract class and what does it do???
    abstract class Vehicle 
    {
        public int wheels = 5;
    }

    class Corsa : Vehicle 
    {
        public int spareWheels = 1;
    }
}
