using serwis_console.FactoryItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serwis_console
{
    public class Program
    { 
        static void Main()
        {
            Diagnose();
        }
        public static void Diagnose()
        {
            Console.WriteLine("System serwisowy diagnozujący usterki");
            Console.WriteLine("Ditrich Marcin i Proniewicz Andrzej");
            Console.WriteLine("Akademia Humanistyczno - Ekonomiczna w Łodzi");

            Console.WriteLine("Prosze podać odpowiedź T (tak)/N (nie)");
            Console.WriteLine("Czy diagnozowana jest drukarka? (t/n)");
            string result = Console.ReadLine().ToUpper();
            
            
           if (result.Equals("T"))
            {
                Printer printer = new Printer();
                printer.IsDefaultPrinter();
            }

            
        }
        
    }
}
