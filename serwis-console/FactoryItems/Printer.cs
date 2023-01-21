using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Resources;

namespace serwis_console.FactoryItems
{
    public class Printer
    {
       
        public Printer()
        {
            IsDefaultPrinter();
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

        public void IsDefaultPrinter()
        { 
            
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "T1", "N5");
        }
      
        public void N5()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "T6", "N6");
        }

        public void T1()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "T2", "N0");
        }
        
        public void N0() 
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }
       
        public void T2()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "NoSupprt", "N0");
        }
        
        public void T4()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void T3()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "T4", "N4");
        }
      
        public void T5()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
        }
        
        public void N2()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "T5", "N3");
        }
        public void N3()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }
        
        public void N1()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name,"T3","N2");
        }
        
        public void N4()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void T6()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "T7", "N0");
        }

        public void N6()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "NoSupprt", "N7");
        }
       
        public void N7()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
        }

        public void T7()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name,"T8","N8");
        }

        public void T8()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
        }
      
        public void N8()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "T9", "N9");
        }

        private void N9()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "NoSupport", "N11");
        }

        public void T9()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "NoSupport", "N10");
        }

        private void N10()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "T10", "N11");
        }

        private void N11()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "T11", "N12");
        }

        private void N12()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "T12", "N13");
        }

        private void N13()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "T13", "N14");
        }

        private void T13()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);

            Console.ReadLine();
            Environment.Exit(0);
        }

        private void N14()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);

            Console.ReadLine();
            Environment.Exit(0);
        }

        private void T12()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);

            Console.ReadLine();
            Environment.Exit(0);
        }

        private void T10()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }

        private void T11()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);

            Console.ReadLine();
            Environment.Exit(0);
        }

        public void NoSupprt()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);

            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
