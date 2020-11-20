using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrNotNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Podaj dowolną liczbę");
                var numberTocheck = CheckIsNumber();

                if (numberTocheck%2 == 0)
                    Console.WriteLine("Podana liczba jest parzysta");
                else
                    Console.WriteLine("Podana liczba jest nieparzysta");



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static int CheckIsNumber()
        {
            
            if (!int.TryParse(Console.ReadLine(), out int result))
            {
                throw new Exception("To nie jest liczba");
            }

            return result;
        }
    }

}
