using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.common
{
    public static class StringHandler
    {
        // this function takes in the string to process 
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;
            if (!String.IsNullOrWhiteSpace(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        // Trim any spaces already there(added after second test 
                        // case failed)
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            // added after running the first test case, because it
            //added a spca before first upercase lettert as well.
            result = result.Trim();
            return result;
        }
    }
}
