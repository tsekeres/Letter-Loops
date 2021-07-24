using System;

namespace Letter_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please type a random string of letters and press enter.");
            var letterString = Console.ReadLine();
            var letters = letterString.ToLower();
            var counter = 1;
            string newString = "";

            foreach (var letter in letters)
            {
                for (var i = 0; i < counter; i++)
                {
                    newString += letter;
                }
                newString += "-";
                counter++;
            }

            //Capitalize first letter
            char[] multiplyAndCapitalize = newString.ToCharArray();
            if (multiplyAndCapitalize.Length >= 1)
            {
                if (char.IsLower(multiplyAndCapitalize[0]))
                {
                    multiplyAndCapitalize[0] = char.ToUpper(multiplyAndCapitalize[0]);
                }
            }
            
            //Capitalize letters after the dashes
            for (int i = 1; i < multiplyAndCapitalize.Length; i++)
            {
                if (multiplyAndCapitalize[i - 1] == '-')
                {
                    if (char.IsLower(multiplyAndCapitalize[i]))
                    {
                        multiplyAndCapitalize[i] = char.ToUpper(multiplyAndCapitalize[i]);
                    }
                }
            }
            //return new string(multiplyAndCapitalize);

            Console.WriteLine(multiplyAndCapitalize);
        }
    }
}
