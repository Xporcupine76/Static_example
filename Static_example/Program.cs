using System;
using System.Text;
using System.Threading.Channels;
namespace Static_example
{

    class Peogram
    {
        static void Main(string[] args)
        {
            double r = Math.Round(35.5);
            Console.WriteLine(r);
            Car.Accelerate();
            Car car = new Car();
            car.SlowDown();
        }
        public class Car
        {

            public static void Accelerate() 
            {
                Console.WriteLine("car is speeding up");

            }
            public void SlowDown()
            {
                Console.WriteLine("car is slowing down ");

            }
        }

    }

}
 