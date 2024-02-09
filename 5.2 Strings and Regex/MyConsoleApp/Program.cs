using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(AlmostOnlyLetters("She is nice."));    
        Console.WriteLine(AlmostOnlyLetters("true 222."));       
    }

    static bool AlmostOnlyLetters(string input)
    {
        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length - 1; i++)
        {
            foreach (char c in words[i])
            {
                if (!char.IsLetter(c))
                {
                    return false;  
                }
            }
        }

        string lastWord = words[words.Length - 1];
        if (lastWord.EndsWith("."))
        {
            string trimmedLastWord = lastWord.TrimEnd('.');
            foreach (char c in trimmedLastWord)
            {
                if (!char.IsLetter(c))
                {
                    return false;  
                }
            }
            return true;  
        }

        return false;  
    }
}
