using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

           int a = 0; int b = 1;int  c = 0 ;int d = 0;
            while(b <= 4000000)
            {
                c = a + b;
                a = b;
                b = c;
                
                if(c <= 4000000 && c % 2 == 0)
                {
                    Console.WriteLine(c);
                    d = d + c;
                   
                }
                
            }
            Console.WriteLine(d);

        }
    }
}
