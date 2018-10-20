using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSeventeen
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string star = "*";
            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(star);
                    star = (star + " *");
                }
                else
                {
                    Console.WriteLine(star);
                    star = ("* " + star + " *");

                }
                
            }
            Console.ReadKey();
        }
    }
}
