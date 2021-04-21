using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Search
{
    public static class StringSearcher
    {
        public delegate void SearchHandler(string foundResult);
        public static event SearchHandler OnFoundResult;

        public static void Search(List<string> list)
        {
            Regex rgx = new Regex(@"^[0-9]");
            foreach (string item in list)
            {
                if (rgx.IsMatch(item))
                {
                    OnFoundResult?.Invoke(item);
                }
            }
        }
    }
}
