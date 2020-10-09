using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть сторони трикутника:");

            TTriangle triangle = new TTriangle();
            int a = triangle.A;
            int b = triangle.B;
            int c = triangle.C;

            Console.WriteLine("Сторони вашого трикутника: {0}, {1}, {2}.", a, b, c);
          
            int check = triangle.Check_The_Triangle(a, b, c);

            if (check != 1)
            {
                double P = triangle.Perimeter_Triangle(a, b, c);
                double S = triangle.Area_Triangle(P);

                Console.WriteLine("Периметр даного трикутника = {0}, площа = {1}.", P, S);
            }

            Console.ReadKey();

        }        

    }
}