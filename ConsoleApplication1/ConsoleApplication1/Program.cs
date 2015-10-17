using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Car mycar = new Car();
            mycar.currentSpeed = 20;
            mycar.petName = "Tigran";
            for (int i = 0; i < 10; i++)
            {
                mycar.SpeedUp(5);
                mycar.PrintState();
            }
            Car c = new Car();
            c.PrintState();

            Motorcycle mc = new Motorcycle(5);
            mc.name = "armen";
            mc.Uraa();
            Console.WriteLine($"Driver is name {mc.name}");

            Motorcycle mot = new Motorcycle("arturik");
        }
    }
}
