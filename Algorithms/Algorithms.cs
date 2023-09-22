using System;
using System.Linq;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n)
        {
            if (n == 1)
                return 1;
            else if (n == 0)
                return 0;
            else
                return n * GetFactorial(n - 1);
        }

        public static string FormatSeparators(params string[] items)
        {
            string item = "";
            foreach (var item2 in items)
            {
                if (items.Last() == item2) item = item + " and ";
                else if (item != "") item = item + ", ";

                item = item + item2;
            }
            return item;
        }
    }
}