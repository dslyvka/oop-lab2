using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //36.90, 40.00, 0.61
            Convertor convertor = new Convertor(36.90, 40.00, 0.61);
            Console.WriteLine("UAH => USD" + " " + convertor.ToUsd(100));
            Console.WriteLine("UAH => EUR" + " " + convertor.ToEur(100));
            Console.WriteLine("UAH => RUB" + " " + convertor.ToRub(100));
            Console.WriteLine();
            Console.WriteLine("USD => UAH" + " " + convertor.UsdToUah(100));
            Console.WriteLine("USD => UAH" + " " + convertor.EurToUah(100));
            Console.WriteLine("USD => UAH" + " " + convertor.RubToUah(100));
        }
    }
}
