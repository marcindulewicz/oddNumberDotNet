﻿using System;
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







            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static int CheckIsNumber()
        {
            var input = int.TryParse(Console.ReadLine(), out int result);
            if (!input)
            {
                throw new Exception("To nie jest liczba");
            }

            return result;
        }
    }

}
