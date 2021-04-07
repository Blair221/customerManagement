using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multipurpose.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Inserts spaces before each capital letter in a string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces (this string source)
        {
            string result = string.Empty;

            if (!String.IsNullOrEmpty(source))
            {
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        // Trimming any spaces already there
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
            return result;
        }
    }
}
