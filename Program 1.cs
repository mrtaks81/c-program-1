using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, toplam;
            Console.Write("ilk değeri girin");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("ilk değeri girin");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("{0} ve {1} sayılarının toplamı=",a,b);
           
            toplam=a+b;
            Console.WriteLine("toplam={0}"+(toplam));
            Console.ReadKey();
        }
    }
}
