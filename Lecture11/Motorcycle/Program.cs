using System;

namespace Motorcycle
{
    class Program
    {
        static void Main(string[] arg)
        {

            DateOnly dateOnly = new DateOnly(DateTime.Now.Year,DateTime.Now.Month, DateTime.Now.Day);
            Motorcycle motorcycle = new Motorcycle( "Honda", "Japan", dateOnly, 99, new Electro (125, 50 ));
            Console.WriteLine(motorcycle);            
           
        }
    }
}