using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discountprice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter Value for product1");

            int value1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("please enter Value for Product2");

            int value2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("please enter Value for Product3");

            int value3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("please enter Value for product4");

            int value4 = Convert.ToInt32(Console.ReadLine());

            int total = value1 + value2 + value3 + value4;
            int discount = 0;
            if (total >= 0 && total <= 10000)
            {
                discount = total * 5 / 100;
            }
            else if (total > 10000 && total <= 20000)
            {
                discount = total * 10 / 100;
            }
            else
            {
                discount = total * 20 / 100;

            }
            Console.WriteLine(total);
            Console.WriteLine(discount);
            Console.ReadKey();
       }
    }
}
