using System;
using System.Globalization;

namespace DB1Start
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos numeros irá digitar?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Informe um numero: ");
                double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Number informedNumber = new Number(number);
                informedNumber.Double();
                informedNumber.EvenOdds();
                informedNumber.PrimeNumber();
                Console.WriteLine(informedNumber);
            }

        }
    }
}
