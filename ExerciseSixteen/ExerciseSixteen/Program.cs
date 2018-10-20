using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSixteen
{
    class Program
    {
        static void Main(string[] args)
        {

            string triangle = "*";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(triangle);
                triangle = (triangle + "*");
            }
            Console.ReadKey();
        }
    }
}
