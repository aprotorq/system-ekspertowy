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
            if (result.Equals("T"))
                return true;
            else return false;

        }

    }
}
