using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Vehicle baseVehicle = new Vehicle(4, 2000, "Green", 55.0d);
            //baseVehicle.Move();
            //Console.WriteLine(baseVehicle.DistanceTraveled);


            Automobile herbie = new Automobile(4, 13, 1, 4, 1500, "White", 88.0d);
            herbie.Move();
            herbie.Move();
            Console.WriteLine("Automobile distance traveled: " + herbie.GetDistanceTraveled());



            Boat boaty = new Boat(2, 500, "Red", 88.0d, .9d);
            boaty.Move(); // made our own version specific to Boat and overrode the original Vehicle move
            boaty.Move();
            Console.WriteLine("Boat Distance Traveled: " + boaty.GetDistanceTraveled());


            Aircraft aircraft1 = new Aircraft(70, 100000, "grey", 600.0d);
            aircraft1.Move(); // used base plus added altitude variable specific to Aircraft
            aircraft1.Move();
            Console.WriteLine("Aircraft " + aircraft1.GetDistanceTraveled());

        }
    }
}
