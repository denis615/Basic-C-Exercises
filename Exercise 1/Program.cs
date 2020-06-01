using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write your name?");
            string name = Console.ReadLine();
            string lowerName = name.ToLower();
            Console.WriteLine("Please write a text including the upper name?");
            string text = Console.ReadLine();
            string lowerText = text.ToLower();




            Console.WriteLine($" That Name is mentioned {CountAllTheTimesThisStringAppearsInThatString(lowerText, lowerName)} times in the text");
        


    }

        static Int32 CountAllTheTimesThisStringAppearsInThatString(string orig, string find)
        {
            var s2 = orig.Replace(find, "");
            return (orig.Length - s2.Length) / find.Length;
        }
    }
}
