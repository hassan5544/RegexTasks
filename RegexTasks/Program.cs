using System;
using System.Text.RegularExpressions; 
namespace RegexTasks
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Q1 Test
            string HexCode = "#CD5C5C";
            Console.WriteLine("Hex Code: " + HexCode + Services.CheckHex(HexCode));
            HexCode = "#f08080";
            Console.WriteLine("\nHex Code: " + HexCode + Services.CheckHex(HexCode));
            HexCode = "#E9967A";
            Console.WriteLine("\nHex Code: " + HexCode + Services.CheckHex(HexCode));
            HexCode = "#EFFA07A";
            Console.WriteLine("\nHex Code: " + HexCode + Services.CheckHex(HexCode));


            //Q2 test 

            string data = "CPP Exercises.";
            Console.WriteLine("text :" + data);
            Console.WriteLine("avrageLength " + Services.CalculateAvg(data));
            data = "C# syntax is highly expressive, yet it is also simple and easy to learn.";
            Console.WriteLine("text :" + data);
            Console.WriteLine("avrageLength " + Services.CalculateAvg(data));
            data = "C# is an elegant and type-safe object-oriented language";
            Console.WriteLine("Text :" + data);
            Console.WriteLine("avrageLength " + Services.CalculateAvg(data));

            // Q3 Test

            string text = "Text: amamd";
            Console.WriteLine(": " + text);
            Console.WriteLine(Services.Palindrome(text));
            text = "pamamd";
            Console.WriteLine("\nText: " + text);
            Console.WriteLine(Services.Palindrome(text));
            text = "ferre";
            Console.WriteLine("\nText: " + text);
            Console.WriteLine(Services.Palindrome(text));

            // Q4 test

            string Password = "Suuu$21g@";
            Console.WriteLine("\nOriginal string: " + text + " is a valid passward ? " + Services.PasswordCheck(Password) + "\n");
            Password = "W#1g@";
            Console.WriteLine("\nOriginal string: " + text + " is a valid passward ? " + Services.PasswordCheck(Password) + "\n");
            Password = "a&&g@";
            Console.WriteLine("\nOriginal string: " + text + " is a valid passward ? " + Services.PasswordCheck(Password) + "\n");
            Password = "sdsd723#$Amid";
            Console.WriteLine("\nOriginal string: " + text + " is a valid passward ? " + Services.PasswordCheck(Password) + "\n");
            Password = "sdsd723#$Amidkiouy";
            Console.WriteLine("\nOriginal string: " + text + " is a valid passward ? " + Services.PasswordCheck(Password) + "\n");


            // Q8 test

            Console.WriteLine("Enter the Text");
            string? Entry = Console.ReadLine();
            if (text == null || text != "")
            {
                Console.WriteLine("Output Text :" + Services.RemoveSpecialCharacters(Entry));
            }
            else
            {
                Console.WriteLine("UnSupported format of Text");

            }


            // Q9 
            Console.WriteLine("Enter the Search word:");
            string? word = Console.ReadLine();

            Console.WriteLine("Enter the Text for Search :");
            string? searchtext = Console.ReadLine();
            Console.WriteLine("The Word " + Services.SeachForWord(searchtext, word));

        }


    }
}