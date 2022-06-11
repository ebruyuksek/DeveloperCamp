using System;
using System.Collections.Generic;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Interfaceden türetilen classların instance'ı alındığında, alınan instance interface tipinde de kabul edilir.
            //örn: CarLoanManager bir ILoanManager'dır.
          
            var applyManager = new ApplyManager();

            applyManager.Apply(new GeneralPurposeLoanManager(), new DatabaseLoggerService());

            Console.ReadLine();
        }
    }
}
