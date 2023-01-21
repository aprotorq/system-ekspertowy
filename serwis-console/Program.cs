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
            Console.Title = "System Serwisowy";
            Welcome();
            Diagnose();
        }
        public static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("System serwisowy diagnozujący usterki");
            Console.WriteLine("Ditrich Marcin i Proniewicz Andrzej");
            Console.WriteLine("Akademia Humanistyczno - Ekonomiczna w Łodzi\n");
        }
        public static void Diagnose()
        {
            Console.WriteLine("Prosze podać odpowiedź T (tak)/N (nie) - By wyjśc z programu należy wpisać 'Q'");
            Console.WriteLine("Czy diagnozowana jest drukarka? (t/n)");
            string result = Console.ReadLine().ToUpper();
            WrongAnswer(result);

            if (result.Equals("T"))
            {
                Printer printer = new Printer();
            }

            Console.WriteLine("Czy diagnozowany jest komputer? (t/n)");
            result = Console.ReadLine().ToUpper();
            WrongAnswer(result);

            if (result.Equals("T"))
            {
                Console.WriteLine("Czy diagnozowany jest Laptop? (t/n)");
                result = Console.ReadLine().ToUpper();
                WrongAnswer(result);

                if (result.Equals("T"))
                {
                    Laptop laptop = new Laptop();
                }
                Console.WriteLine("Czy diagnozowany jest komputer stacjonarny? (t/n)");
                result = Console.ReadLine().ToUpper();
                if (!(result.Equals("T") || result.Equals("N")))
                {
                    Console.WriteLine("Jako odpowiedź wpisz tylko 't' czyli tak lub 'n' czyli nie");
                    CheckAnswer();
                }

                if (result.Equals("T"))
                {
                    PC pc = new PC();
                }
               
                else
                {
                    Console.WriteLine("Nie został wybrane żadne z dostępnych urządzeń");
                    Diagnose();
                }

            }

        }
        public static void CheckAnswer()
        {
            Diagnose();
        }
        public static void WrongAnswer(string result)
        {
            if (result.Equals("Q"))
            {
                Environment.Exit(0);
            }
            if (!(result.Equals("T") || result.Equals("N")))
            {
                Console.WriteLine("Jako odpowiedź wpisz tylko 't' czyli tak lub 'n' czyli nie");
                CheckAnswer();
            }
            
           
        }
        
        
    }
}
