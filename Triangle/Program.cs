using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(3,4,5);
            t1.Show();
            t1.Perimeter();
            t1.Square();
            t1.Exist();
        }
    }
}
