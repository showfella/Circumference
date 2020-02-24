using System;

namespace Circumference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an Integer for the radius");
            try
            {
                double radius = Convert.ToDouble(Console.ReadLine());
                AreaOfCircle(radius);
            }
            catch (Exception ex)
            {
                var message = ex.Message;
                Console.WriteLine(message);
                Console.WriteLine("You must enter a valid number");
            }

            Console.WriteLine("Ok");
        }

        public static void AreaOfCircle(double radius)
        {
                if(radius <= 0)
                {
                    Console.WriteLine("Yor number is out of range");

                }
                else
                {
                    //calclate circumference of Circle
                    double pie = 3.142;
                    double circum = pie * 2 * radius;
                    double area = pie * radius * radius;
                    Console.WriteLine("The circumference of the circle is  {0} ", circum);

                    //calculate area of the Circle
                    Console.WriteLine("The circumference of the circle is {0}", area);

                }
        }
    }
}
