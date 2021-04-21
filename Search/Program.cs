using System.Collections.Generic;

namespace Search
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = new List<string>() {"test", "Test2", "1m", "new test"};
            StringSearcher.OnFoundResult += Handler.DisplayMessage;
            StringSearcher.Search(listOfStrings);
        }
    }
}
