using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("baslangi ededi daxil edin: ");
            int baslangic = Convert.ToInt16(Console.ReadLine());
            Console.Write("baslangi ededi daxil edin: ");
            int son= Convert.ToInt16(Console.ReadLine());
            for (int i = baslangic; i < son; i++)
            {
                int ters = 0;
                int son_reqem = 0;
                int x = i;
                
                while (x > 0)
                {
                    son_reqem = x % 10;
                    x /= 10;
                    ters = ters * 10 + son_reqem;            
                }
                if (i == ters&&ters>10)
                {
                    Console.WriteLine(ters);
                }                   
            }            
            Console.ReadLine();
        }
    }
}
