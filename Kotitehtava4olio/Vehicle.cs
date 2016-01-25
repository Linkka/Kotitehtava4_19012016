using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava4olio
{
    class Vehicle
    {
        // properties
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        // don't create any constructor, so default one will be used


        // method to give more speed
        public void Accelerate()
        {
            Speed += 5;
        }

        // method to display vehicle data
        public void PrintData()
        {
            Console.WriteLine("Vehicle data : ");
            Console.WriteLine("- Name : " + Name);
            Console.WriteLine("- Speed : " + Speed);
            Console.WriteLine("- Tyres : " + Tyres);
        }

        // method to give more speed
        public string ToString(string Name, int Speed, int Tyres)
        {
            return (Name + Speed + Tyres);
        }

        // destructor
        ~Vehicle()
        {
            Console.WriteLine("Vehicle object destroyed.");
        }

    }

}
