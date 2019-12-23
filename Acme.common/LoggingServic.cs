using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.common
{
    // it is static because we do not want instantiate it.
    public static class LoggingServic
    {
        public static void WriteToFile(List<Object> itemsToLog)
        {
            foreach(var item in itemsToLog)
            {
               // Console.WriteLine(item);
            }

        }
    }
}
