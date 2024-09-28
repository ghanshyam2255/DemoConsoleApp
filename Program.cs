using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using C__All_Programs.Factorial;
using C__All_Programs.Febonaci;
using C__All_Programs.Numbers;
using C__All_Programs.Patterns;

using static C__All_Programs.Patterns.Class1;


namespace C__All_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD...!");

            Print10Numbers objPrint10Numbers = new Print10Numbers();
            objPrint10Numbers.foreachloop();

            TrianglePattern objTrianglePattern = new TrianglePattern();
            objTrianglePattern.pattern();

            PyramidPattern objpyramidPattern = new PyramidPattern();
            objpyramidPattern.Pyramid();

            ReversePattern objReversePattern =new ReversePattern();
            objReversePattern.Name();

            FactorialNumbers objFactorialNumbers = new FactorialNumbers();
            objFactorialNumbers.CalculateFactorial();

            //FibonacciSeries objFibonacciSeries = new FibonacciSeries();
            //objFibonacciSeries.fibo();

            Console.ReadLine();




        }
    }
}
