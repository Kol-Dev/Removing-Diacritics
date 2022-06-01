using System;
using System.Collections.Generic;
using System.Threading;

namespace RemoveDiacritics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example :");
            string text = "Я ем crème brûlée, а не mashed potatoes !";
            // for strings
            var newText = text.RemoveDiacritics();
            // for chars
            "Ã"[0].RemoveDiacritics(); // A
            var charsToRemove = new string[] { "@", ",", "?", ".", ";", "!", "&", "'", "#", "(", ")", "{", "}", "[", "]", "-", "_", "$", "*", "=", "+", "/", ":" };
            foreach (var c in charsToRemove)
            {
                newText = newText.Replace(c, string.Empty);
            }
            Console.WriteLine(text);
            Console.WriteLine(newText + "\n");


            // User Input
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter text:");
            Console.ResetColor();
            string textInput = Console.ReadLine();
            var newTextInput = textInput.RemoveDiacritics();
            var removeChars = new string[] { "@", ",", "?", ".", ";", "!", "&", "'", "#", "(", ")", "{", "}", "[", "]", "-", "_", "$", "*", "=", "+", "/", ":" };
            int value = 0;
            foreach (var c in removeChars)
            {
                newTextInput = newTextInput.Replace(c, string.Empty);
            }
            foreach(char c in newTextInput)
            {
                int index = (int)c % 32;
                value += index;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Result:");
            Console.ResetColor();
            Console.WriteLine("'{0}'", newTextInput);
            Console.WriteLine(value);

        }

    }
}