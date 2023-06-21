using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTasks
{
    public class Services
    {
        // Q1 
        public static bool CheckHex(string HexCode)
        {
            return Regex.IsMatch(HexCode, @"[#][0-9A-Fa-f]{6}\b"); // Characters has to be length of six and contains number 1 to 9 and A to F
        }

        public static double CalculateAvg(string data)
        {
            string new_data = Regex.Replace(data, "[^A-Za-z ]", "");
            double average_len = new_data.Split(' ').Select(x => x.Length).Average();
            return Math.Round(average_len, 2);
        }

        public static bool Palindrome(string text)
        {
            bool result = Regex.Replace(string.Concat(text.OrderBy(x => x)), @"([a-z])\1{1}", string.Empty).Length <= 1;
            return result;
        }

        public static bool PasswordCheck(string text)
        {
            bool result = text.Length >= 7 && text.Length <= 16
            && Regex.IsMatch(text, "[A-Z]")
            && Regex.IsMatch(text, "[a-z]")
            && Regex.IsMatch(text, @"\d")
            && Regex.IsMatch(text, @"[!-/:-@\[-_{-~]")
            && !Regex.IsMatch(text, @"[^\dA-Za-z!-/:-@\[-_{-~]");
            return result;
        }

        public static string RemoveSpecialCharacters(string text)
        {
            return Regex.Replace(text, "[^0-9A-Za-z _-]", "");
        }

        public static string SeachForWord(string? text, string? word)
        {
            string regex = Regex.Escape(word);
            if (Regex.IsMatch(text, regex))
            {
                return word + " Exists";
            }
            else
            {
                return word + " Dont Exists";
            }

        }
    }
}
}
