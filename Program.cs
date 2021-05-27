using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface_In_Csharp
{



    class Program
    {
        static void Main(string[] args)
        {




            // IRegular Polygon


            Console.WriteLine("IRegular PolygonInterface started===>\n");

            Triangle tr = new Triangle(3, 5);
            Console.WriteLine("The Side Lenght Of Triangle is {0}", tr.SideLenght);
            Console.WriteLine("The Area of Triangle is :{0}", tr.GetArea());
            Console.WriteLine("The Perimeter of Triangle is {0}", tr.GetPerimeter());





            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("IVehicluo Interface started===>");



            // Ivehiculo Interface


            Console.WriteLine("Enter the Fuel");
            var fuel = Convert.ToInt32(Console.ReadLine());

            Car car = new Car();
            car.Refuel(fuel);
            car.Drive();
            



            // Expilict interface impemnetation  

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Expilict interface started===>\n");

            I1 i1 = new Expilict();
            I2 i2 = new Expilict();
            i1.ShowMethod();
            i2.ShowMethod();

            Console.ReadLine();
        }
    }
}
