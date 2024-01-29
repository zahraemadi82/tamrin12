using System;
namespace project
{
    class Circle
    {
        private double r;
        double pi = 3.14;
        public double R
        {
            get { return r; }
            set
            {
                if (value > 0)
                    r = value;
            }
        }
        public Circle() { }
        public Circle(double R)
        {
            r = R;
        }
        public double s()
        {
            {
                return Math.Pow(r, 2) * pi;
            }



        }
        public double a()
        {
            return 2 * pi * r;

        }





        class Test
        {
            public static void Main()
            {
                double r = Convert.ToDouble(Console.ReadLine());
                Circle c1 = new Circle();
                c1.R = r;
                double s1 = c1.s();
                Console.WriteLine(s1);
                double a1 = c1.a();
                Console.WriteLine(a1);



            }
        }
    }
}

