using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface_In_Csharp
{
    public interface IRegularPplygon
    {

         int NoOfSides { get; set; }//its only declaration
         int SideLenght { get; set; }

         double GetPerimeter();
         double GetArea();

    }
}
