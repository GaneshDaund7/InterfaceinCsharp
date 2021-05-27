using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface_In_Csharp
{
    public class Triangle : IRegularPplygon
    {

        public int NoOfSides { get; set; }

        public int SideLenght { get; set; }


        public Triangle(int sides, int lenght)
        {
            NoOfSides = sides;
            SideLenght = lenght;
        }

        public  double GetPerimeter()
        {
            return NoOfSides * SideLenght;

        }
        public  double GetArea()
        {
            return SideLenght * SideLenght * (Math.Sqrt(3)/4);
        }
    }
}
