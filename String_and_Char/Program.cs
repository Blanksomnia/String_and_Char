using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace String_and_Char
{
    internal class Program
    {
        static void ConcatStrings(string string1, string string2)
        {
            Console.WriteLine(string.Concat(string1, string2));
        }
        static void GreetUser(string Name, int Age)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>() { { Name, Age } };
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                var greetUser = $"Hello {kvp.Key}!\nYou are {kvp.Value} years old.";
                Console.WriteLine(greetUser);
                Console.WriteLine($"\ncount of symbols: {greetUser.Length}\nUppercase string: {greetUser.ToUpper()}\nLowercase string: {greetUser.ToLower()}");
            }
        }
        static void SubstringStrings(string string1)
        {
            Console.WriteLine(string1.Substring(0, 5));
        }
        static void StringBuilderString(string array1, string array2, string array3, string arrays4)
        {
            string[] arrays = new string[4] { array1, array2, array3, arrays4 };
            var builder = new StringBuilder();
            foreach (string i in arrays)
            {
                builder.Append(i + " ");
            }
            Console.WriteLine(builder.ToString());
        }
        static void ReplaceWords(string inputString, string wordToReplace, string replacementWord)
        {
            Console.WriteLine(inputString);
            Console.WriteLine(inputString.Replace(wordToReplace, replacementWord));

        }

        static void Main(string[] args)
        {
            Console.WriteLine("####### Task 1 #######");
            ConcatStrings("glasses", " eyes");
            Console.WriteLine("####### Task 2 and 3 #######");
            GreetUser("Max", 12);
            Console.WriteLine("####### Task 4 #######");
            SubstringStrings("Hello, World!");
            Console.WriteLine("####### Task 5 #######");
            StringBuilderString("Apple", "Candy", "Meat", "Water");
            Console.WriteLine("####### Task 6 #######");
            ReplaceWords("Hello world", "world", "universe");





        }
    }
}
