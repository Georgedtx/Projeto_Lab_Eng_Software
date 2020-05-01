using System;
using System.Collections.Generic;

namespace App.ExtensionsMethods
{
    public static class ExtensionMethod
    {
        public static string Concatenar(this IEnumerable<String> list)
        {
            string result = "";

            foreach(string item in list)
            {
                result += (item + "\n\n");
            }

            return result;
        }
    }
}
