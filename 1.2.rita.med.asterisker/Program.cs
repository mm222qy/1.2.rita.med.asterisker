using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2.rita.med.asterisker
{
    class Program
    {
        static void Main(string[] args)
        {
            int alength = 25;
            int blength = 39;
            int caseswitch = 0;
            for (int i = 0; i < alength; i++)
            {
                caseswitch = i % 3;
                switch (caseswitch)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    default:
                        break;
                }

                    if (i > 0)
                        Console.WriteLine();

                    if (i % 2 == 1)
                         Console.Write(" "); 

                    for (int j = 0; j < blength; j++)
                   {

                            Console.Write("* ");
                    

                   }
            }
            Console.ResetColor();
        }
    }
}
