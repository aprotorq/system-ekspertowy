using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace serwis_console.FactoryItems
{
    class PC
    {
        public PC()
        {
            PC_T1();
        }
        public void DisplayQuestion(string methodName, string whenTrue, string whenFalse)
        {
            Console.WriteLine(Questions.ResourceManager.GetString(methodName) +": ");
            if (Factory.Question())
            {
                MethodInfo mTrue = GetType().GetMethod(whenTrue);
                mTrue.Invoke(this, new object[] { });
            }
            else
            {
                MethodInfo mFalse = GetType().GetMethod(whenFalse);
                mFalse.Invoke(this, new object[] { });
            }

        }
        public void DisplayQuestion(string methodName)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Questions.ResourceManager.GetString(methodName));
        }
        
        public void PC_N5()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void PC_T1()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "PC_T3", "PC_N1");
        }

        public void PC_T2()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void PC_T4()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            ShowDoc();
            Console.ReadLine();
            Environment.Exit(0);
        }

        private void ShowDoc()
        {
            List<string> issueDescription = new List<string>()
           {
                "1 krótki - problem związany z odswierzaniem pamięci ram",
                "2 krótkie - problem podczas sprawdzania parzystoci pamięci ram",
                "3 krótkie - problem związany z problemem odczytu pierwszego segmentu pamięci ram (64kb)",
                "4 krótkie - błąd związany z zegarem systemowym",
                "5 krótkich - błąd procesora",
                "6 krótkich - problem z kontroloerem klawiatury",
                "7 krótkich - błąd wirtualnego trybu procesora",
                "8 krótkich - błąd wejscia/wyjscia (i/o) pamięci karty graficznej",
                "9 krótkich - błąd podczas sprawdzania sumy kontrolnej biosu",
                "10 krótkich - błąd pamięci cmos",
                "11 krótkich - błąd pamięci cache l2 procesora",
                "1 długi, 2 krótkie - błąd karty graficznej",
                "1 długi, 3 krótkie - błąd podczas testów karty graficznej",
                "1 długi, 8 krótkich - problem z wywietlaniem obrazów przez kartę graficzną",
                "ciągły sygnał - brak pamięci w bankach lub brak podłączanej karty graficznej",
                "1 długi - zakonczony pomyslnie test post"
           };
            foreach (string item in issueDescription)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(item);
            }
        }

        public void PC_T3()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "PC_T5", "PC_N3");
        }

        public void PC_T5()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "PC_T6", "PC_N5");
        }

        public void PC_N2()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }
        public void PC_N3()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "PC_T4", "PC_N4");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void PC_N1()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "PC_T2", "PC_N2");
        }

        public void PC_N4()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void PC_T6()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "PC_T7", "PC_N6");
        }
        public void PC_T7()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }
        public void PC_N6()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void NoSupprt()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
        }


    }
}
