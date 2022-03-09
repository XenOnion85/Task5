using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        private int a;
        private int b;
        private int c;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Show()
        {
            Console.WriteLine("Первая сторона: {0}\nВторая сторона: {1}\nТретья сторона: {2}", a, b, c);
        }
        public void Perimeter()
        {
            int p = a + b + c;
            Console.WriteLine("Периметр равен {0}", p);
        }
        public void Square()
        {
            double p = (a + b + c) / 2;
            double P = p * (p - a) * (p - b) * (p - c);
            double s = Math.Sqrt(P);
            Console.WriteLine("Площадь равна {0}", s);
        }
        public void Exist()
        {
            if (a + b > c && b + c > a && c + a > b && a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("Треугольник существует");
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
        }
    }
}
