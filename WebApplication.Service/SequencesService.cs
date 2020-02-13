using WebApplication.Service.Interfaces;

namespace WebApplication.Service
{
    public class SequencesService : ISequencesService
    {

        decimal ISequencesService.Fibonacci(int n)
        {
            return Fibonacci(n);
        }

        private static readonly decimal[] fib = new decimal[1000];
        private static decimal Fibonacci(int n)
        {
            // 1 <= N <= 100 else return -1
            if (n < 1 || n > 100) return -1;
            
            if (fib[n] == 0)
            {
                if ((n == 1) || (n == 2))
                {
                    fib[n] = 1;
                }
                else
                {
                    fib[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }

            return fib[n];
        }

        
    }
}