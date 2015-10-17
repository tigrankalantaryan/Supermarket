using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Motorcycle
    {
        public int driverInstans;
        public string name;

        public void SetName(string name)
        {
            this.name = name;
        }
        public void Uraa()
        {
            for (int i = 0; i < driverInstans; i++)
            {
                Console.WriteLine("Uraaaaaaa");
            }
        }
        public Motorcycle()
        {
            Console.WriteLine("esi arandz parametreri");
        }

        public Motorcycle(int instensity) : this(instensity, "")
        {
            Console.WriteLine("esi menak intejerov");
        }

        public Motorcycle(string name) : this(0, name)
        {
            Console.WriteLine("esi menak stringov");
        }

        public Motorcycle(int instensity, string name)
        {
            Console.WriteLine("es el himnakan@, amen inchov :D");
            if (instensity > 10)
            {
                instensity = 10;
            }
            driverInstans = instensity;
            this.name = name;
        }

    }
}
