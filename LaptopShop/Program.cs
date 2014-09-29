using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Program
    {
        static void Main()
        {
            Laptop pc = new Laptop("Apple Macbook Pro", 2499, null, "Intel Core i5-4210U", "8 GB");
            Console.WriteLine(pc);
        }
    }
}
