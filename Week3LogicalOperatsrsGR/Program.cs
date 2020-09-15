using System;

namespace Week3LogicalOperatsrsGR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What month were you born?");
            string month = Console.ReadLine().ToLower();
            // || - pices alt gr + <
            if(month == "december" || month == "januar" || month == "februar")
            {
                Console.WriteLine("You were born in winter.");
            }else if(month == "December" || month == "january" || month == "february")
            {
                Console.WriteLine("You were born in spring.");
            }else if(month == "march" || month == "aprill" || month == "may")
            {

            }
        }
    }
}
