using System;
using System.Numerics;
using System.Diagnostics;

namespace BaseLab_7
{
    class Program
    {
        static void Main(string[] args)

        {
            Stopwatch stopwatch = new Stopwatch();
           while(true)
            {
                Console.WriteLine("Введите число");
                int n = int.Parse(Console.ReadLine());
                stopwatch.Restart();
                var res1 = Simpleactorial(n);
                stopwatch.Stop();
                Console.WriteLine(res1);
                Console.WriteLine($"-------Прошло: {stopwatch.Elapsed}");

                stopwatch.Restart();
                var res2 = Simpleactorial(n);
                stopwatch.Stop();
                Console.WriteLine(res2);
                Console.WriteLine($"-------Прошло: {stopwatch.Elapsed}");
                static BigInteger Simpleactorial(int x)
                {
                    var factorial = new BigInteger(1);
                    for (int i = 1; i<= x; i++)
                    {
                        factorial *= i;
                        
                    }
                    return factorial;
                }

                static BigInteger FactorialByRec(int x)
                {
                    if (x == 1) return 1;
                    return x * FactorialByRec(x - 1);
                }
            }
        }
    }
}
