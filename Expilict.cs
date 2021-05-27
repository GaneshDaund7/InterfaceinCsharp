using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface_In_Csharp
{

    public interface I1
    {
        void ShowMethod();
    }
    public interface I2
    {
        void ShowMethod();
    }

    
    
    
    
    
    class Expilict:I1,I2
    {
        void I1.ShowMethod()
        {
            Console.WriteLine("I1 Show Method");
        }
        void I2.ShowMethod()
        {
            Console.WriteLine("I2 Show Method");
        }
    }
}
