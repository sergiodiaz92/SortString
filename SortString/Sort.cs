using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    public class Sort
    {
        // function to print string in sorted order
        public static string sortString(String str)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (var c in str)
            {
                if (dic.ContainsKey(c)) dic[c] = dic[c] + 1;
                else dic[c] = 1;
            }
            var list = dic.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
            if (String.IsNullOrEmpty(str)) return "-404";
            string result = "";
            foreach (var item in list)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    result += item.Key;
                }
            }
            return result;
        }
        public static void sortStrings(int n, List<string> listStr)
        {
            string result = "";
            foreach (string str in listStr)
            {
                result = sortString(str);
                Console.WriteLine(result);
            }
        }
    }
}
