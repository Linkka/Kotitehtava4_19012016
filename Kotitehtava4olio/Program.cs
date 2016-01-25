using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava4olio
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one vehicle instance
            Vehicle volvo = new Vehicle();
            volvo.Name = "Volvo S60";
            volvo.Speed = 130;
            volvo.Tyres = 4;
            // display vehicle data
            volvo.PrintData();
            Console.ReadLine();
            // return all vehicle's values as a single string.
            volvo.ToString();

            // accelerate, change car's speed value
            volvo.Accelerate();
            // display vehicle data again.
            volvo.PrintData();
            Console.ReadLine();
        }
    }
}
