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
        // change Object to ILoggable(this aloows us to work with each item
        // in the list through its ILoggable interface.
        public static void WriteToFile(List<ILoggable> itemsToLog)
        {
            foreach(var item in itemsToLog)
            {
                // uniqe shape of log function
                Console.WriteLine(item.Log());
            }
                // the generalise log code does not need to know anything about any
               // of our entity or other classes.
              // it just requires any class that wants to participate in logging
              // implement the ILoggable interface.
        }
    }
}
