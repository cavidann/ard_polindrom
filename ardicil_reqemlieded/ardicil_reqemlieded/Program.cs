using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ardicil_reqemlieded
{
    class Program
    {
        static void Main(string[] args)
        {
            int baslangic = 10;
            int son = 50;
            for (int i=baslangic; i<son; i++)
            {

                int j = i % 10;
                int j1 = i/ 10;
                int j2;
                j2=j1 + 1;
                if (j == j2)
                {
                    Console.WriteLine(i);
                    
                }
                
            }
            Console.ReadLine();
        }
    }
}
