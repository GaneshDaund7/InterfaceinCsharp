using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface_In_Csharp
{
   public class Car:IVehiculo
    {
       int AmtOfGasoline=0;

       public bool Refuel(int _AmtOfGasoline)
       {
           AmtOfGasoline += _AmtOfGasoline;
           return true;
       }
       public void Drive()
       {
           if (AmtOfGasoline > 0)
               Console.WriteLine("Car is Driving");
           else
               Console.WriteLine("Please Refuel the car");
       }
       
    }
}
