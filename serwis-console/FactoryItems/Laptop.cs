using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace serwis_console.FactoryItems
{
    class Laptop
    {
        public Laptop()
        {
            L_T1();
        }
        public void DisplayQuestion(string methodName, string whenTrue, string whenFalse)
        {
            Console.WriteLine(Questions.ResourceManager.GetString(methodName) + ": ");
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

        public void L_N5()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void L_T1()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "L_T2", "L_N1");
        }

        public void L_N0()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void L_T2()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "L_T3", "L_N2");
        }

        public void L_T4()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name,"L_T5","L_N5");
        }

        public void L_T3()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "L_T6", "L_N3");
        }

        public void L_T5()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void L_N2()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }
        public void L_N3()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void L_N1()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "L_T4", "L_N4");
        }

        public void L_N4()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void L_T6()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "L_T7", "L_N6");
        }
        public void L_T7()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "L_T8", "NoSupport");
        }

        public void L_N6()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name, "L_T9", "L_N7");
        }

        public void L_N7()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }
        public void NoSupport()
        {
            DisplayQuestion(MethodBase.GetCurrentMethod().Name);
            Console.ReadLine();
            Environment.Exit(0);
        }

    }
}
