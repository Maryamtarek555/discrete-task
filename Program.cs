using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, firstnumber, secondnumber;
            int sum = 0;
            Console.WriteLine("please enter firstnumber:");
            firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter secondnumber");
            secondnumber = int.Parse(Console.ReadLine());
            for(i=firstnumber;i<=secondnumber ; i++)
            {
             for(int j =1;j<i ;j++ )
                {
                    if (i % j == 0) 
                    {
                        sum = sum + j;
                    }
                }
             if(sum==i)
                {
                    Console.WriteLine(sum);
                }
            }
            sum = 0;
        }
    }
}
