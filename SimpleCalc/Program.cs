using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class Program
    {
        static void Main()
        {
            // test submit to git hub ..... ......
            Console.WriteLine("First Integer: ");
            String firstint;
            firstint = Console.ReadLine();
            int parseInt1 = int.Parse(firstint);

            Console.WriteLine("Second Integer: ");
            String secondint;
            secondint = Console.ReadLine();
            int parseInt2 = int.Parse(secondint);

            int result = parseInt1 + parseInt2;
            Console.WriteLine("The result is: " + result);
            Console.ReadLine();

        }
    }
}
