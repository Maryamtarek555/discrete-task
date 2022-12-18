using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the number");

            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("prime number from 2 to {0}:", num);
            for(int i = 2; i<=num ;i++ )
            {
            bool  number = true;
            for(int j = 2;j<i;j++)
                {
                    if (i % j == 0)
                    {
                        number = false;
                        break;
                    }
                }
            if(number)
                {
                    Console.WriteLine("{0}", i);
                }






                       



            }





                    
        }
    }
}
