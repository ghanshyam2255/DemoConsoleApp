using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__All_Programs.Patterns
{
    public class Class1
    {
      public  class PyramidPattern
        {
            public void Pyramid()
            {
                int rows = 10; 
                    
                    

                for (int i = 1; i <= rows; i++)
                {
         
                    for (int j = i; j <= rows - 1; j++)
                    {
                        Console.Write(" ");
                    }

 
                    for (int k = 1; k <= (2 * i - 1); k++)
                    {
                        Console.Write("*");
                    }


                    Console.WriteLine();
                }

                Console.ReadLine();
            }
        }

    }

}





