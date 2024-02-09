using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(MixTwoStrings("aaa", "BBB"));        
        Console.WriteLine(MixTwoStrings("good one", "111"));   
    }

  static string MixTwoStrings(string str1, string str2)
    {
        int maxLength = Math.Min(str1.Length, str2.Length);
        string result = "";

        for (int i = 0; i < maxLength; i++) {
            if (i < str1.Length)
                result += str1[i];
            if (i < str2.Length)
                result += str2[i];
        }
        return result;
    }
}