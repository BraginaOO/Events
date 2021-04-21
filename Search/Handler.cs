using System;

namespace Search
{
    public static class Handler
    {
        public static void DisplayMessage(string foundString)
        {
            Console.WriteLine($"Found a string matching the pattern (starts from digit): {foundString}");
        }
    }
}
