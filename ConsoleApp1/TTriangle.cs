using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TTriangle
    {
        protected int a = GetSide(0);
        protected int b = GetSide(0);
        protected int c = GetSide(0);

        static int GetSide(int side)
        {
            side = Int32.Parse(Console.ReadLine());
            return side;
        }


        public int Check_The_Triangle(int a, int b, int c)
        {
            if (a + b < c || a + c < b || b + c < a)
            {
                Console.WriteLine("Такий трикутник не існує!");
                a = 1;
            }
            else
            {
                a = 0;
            }

            return a;
        }

        public double Perimeter_Triangle(int a, int b, int c)
        {
            double P = a + b + c;

            return P;
        }


        public double Area_Triangle(double P)
        {
            double p = P / 2;

            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return S;
        }


        public int A
        {
            get
            {
                return a;
            }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
                
            }
        }

        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
            }
        }

        public int C
        {
            get
            {
                return c;
            }
            set
            {
                if (value > 0)
                {
                    c = value;
                }
            }
        }

    }
}
