using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        private static String LongestCommonPrefix(String [] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            String longestCommonPrefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                int j = 0;
                var currenString = strs[i];
                while (j < longestCommonPrefix.Length && j < currenString.Length && longestCommonPrefix.ElementAt(j)==
                    currenString.ElementAt(j))
                {
                    j++;
                }
                if (j == 0)
                {
                    return "";
                }
                longestCommonPrefix = longestCommonPrefix.Substring(0, j);
            }
            return longestCommonPrefix;
        }
    }
}
