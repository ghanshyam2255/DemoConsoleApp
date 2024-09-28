using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C__All_Programs.Factorial
{
    public class FactorialNumbers
    {
        public void CalculateFactorial()
        {
            int Factorial = 1;
            int n = 7;

            for (int i = n; i >= 1; i--)
            {
                Factorial = i * Factorial; // Calculate factorial
            }

            Console.WriteLine(Factorial); // Print result
        }
    }

}