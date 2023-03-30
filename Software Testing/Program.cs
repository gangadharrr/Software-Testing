using System;
namespace Software_Testing
{
    
    public class Program
    {
        
        public static int Factorial(int N)
        {

            if(N == 0 || N==1) return 1;
            return N*Factorial(N - 1);

        }
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, World!");
           // throw new Exception("Exception in error");
        }

    }
}