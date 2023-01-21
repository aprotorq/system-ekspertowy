using serwis_console.FactoryItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serwis_console
{
    public static class Factory
    {
        public static bool Question()
        {
            string result = Console.ReadLine().ToUpper();
            bool val = false;
            if (!(result.Equals("T") || result.Equals("N")))
            {
                Console.WriteLine("Jako odpowiedź wpisz tylko 't' czyli tak lub 'n' czyli nie");
            }
            if (result.Equals("T"))
                val= true;
            else if(result.Equals("N")) val= false;
            else if (result.Equals("Q")) Environment.Exit(0); 

            return val;
        }

    }
}
