using System;

namespace ychiys
{
    class Program
    {
        static double Fakt(uint number) // функція для обчислення факторіалу
        {
            double result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        static double D_result(uint n, double x, double e) //функція для обчислення суми
        {
            int k = 0;

            int _1k = 1;
            double kf = 1, nkf = Fakt(n), d = 0;

            double x_k = _1k / kf / nkf * Math.Pow(x / 2, (2 * k + n));//значення початкового елемента ряду 

            while (Math.Abs(x_k) >= e) // сумуються елементи, які задовольняють умову
            {
                
                Console.WriteLine("x{1} = {0}", x_k, k);
                d += x_k;
                k++;

                _1k *= -1;
                kf *= k;
                nkf *= (n + k);
                x_k = _1k / kf / nkf * Math.Pow(x / 2, (2 * k + n));
            }
               Console.WriteLine("x{1} = {0}", x_k, k);
            return d;
        }
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            uint n = Convert.ToUInt32(Console.ReadLine());

            Console.Write("Input x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input a precision: ");
            double e = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sum = {0}",D_result(n, x, e));
        }
    }
}
