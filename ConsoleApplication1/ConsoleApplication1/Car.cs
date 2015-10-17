using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Car
    {
        public int currentSpeed;
        public string petName;

        public Car()
        {
            currentSpeed = 10;
            petName = "anun";
        }

        public Car(string pn)
        {
            petName = pn;
        }

        public Car(string pn,int cs)
        {
            petName = pn;
            currentSpeed = cs;
        }

        public  void PrintState()
        {
            Console.WriteLine($"{petName} is going {currentSpeed} MPH");
        }

        public void SpeedUp(int delta)
        {
            currentSpeed += delta;
        }
    }
}
