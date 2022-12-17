using System;
namespace Calculatrice
{
  public  class CalculeSimple
    {
        double number;
        public double Addition( double x , double y)
        { 
        checkArgumentLimit(x, y);
            if (x > double.MaxValue - y || x > double.MaxValue + y || y > double.MaxValue + x || y > double.MaxValue - x)
            {
                throw new ArgumentException("the result surpasses the + double limit");
            }
            if (x < double.MinValue - y || x < double.MinValue + y || y < double.MinValue + x || y < double.MinValue - x)
            {
                throw new ArgumentException("the result surpasses the - double limit");
            }
            number = x + y;
            return number;
        }
        private void checkArgumentLimit(double x, double y)
        {
                if (x == double.MaxValue || y == double.MaxValue)
                {
                    throw new ArgumentException("one of the parameters surpasses the double limit");
                }
            if (x == double.MinValue || y == double.MinValue)
            {
                throw new ArgumentException("one of the parameters surpasses the  - double limit");
            }
        }

        public double Mulitiplication(double x, double y)
        {
            checkArgumentLimit(x, y);
            if (x > double.MaxValue / y || x > double.MaxValue / y || y > double.MaxValue / x || y > double.MaxValue / x)
            {
                throw new ArgumentException("the result surpasses the + double limit");
            }
            if (x < double.MinValue / y || x < double.MinValue / y || y < double.MinValue / x || y < double.MinValue / x)
            {
                throw new ArgumentException("the result surpasses the - double limit");
            }

            number = x * y;
            return number;
        }
        public double Substraction(double x, double y)
        {
            checkArgumentLimit(x, y);
            if (x > double.MaxValue - y || x > double.MaxValue + y || y > double.MaxValue + x || y > double.MaxValue - x)
            {
                throw new ArgumentException("the result surpasses the + double limit");
            }
            if (x < double.MinValue - y || x < double.MinValue + y || y < double.MinValue + x || y < double.MinValue - x)
            {
                throw new ArgumentException("the result surpasses the - double limit");
            }
            number = x - y;
            return number;
        }
        public double Division(double x, double y)
        {
            checkArgumentLimit(x, y);
          
            { number = x / y; }
           
            return number;
        }
        static void Main(string[] args)
        {
        //    CalculeSimple cal = new();
        //    cal.Addition(double.MaxValue, 1);
            Console.WriteLine("calculatrice !");
        }
    }
}
