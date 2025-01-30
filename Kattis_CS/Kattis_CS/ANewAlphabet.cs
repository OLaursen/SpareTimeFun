namespace Kattis_CS;
using System;
public class ANewAlphabet
{
    public static void ANewalphabet(String[] args)
    {
        var dictionary = new Dictionary<String, String>();
        dictionary.Add("a", "@");dictionary.Add("b", "8"); dictionary.Add("c", "(");
        dictionary.Add("d", "|)");dictionary.Add("e", "3");dictionary.Add("f", "#");
        dictionary.Add("g", "6");dictionary.Add("h", "[-]");dictionary.Add("i", "|");
        dictionary.Add("j", "_|");dictionary.Add("k", "|<");dictionary.Add("l", "1");
        dictionary.Add("m", "[]\\/[]");dictionary.Add("n", "[]\\[]");dictionary.Add("o", "0");
        dictionary.Add("p", "|D");dictionary.Add("q", "(,)");dictionary.Add("r", "|Z");
        dictionary.Add("s", "$");dictionary.Add("u", "|_|");dictionary.Add("v", "\\/");
        dictionary.Add("w", "\\/\\/");dictionary.Add("x", "}{");dictionary.Add("y", "´/");
        dictionary.Add("z", "2");
        
        var line = Console.ReadLine()!.Split("");
        var result = new String[line.Length];
        
        for (int i = 0; i < line.Length; i++)
        {
            var character = line[i];
            result[i] = dictionary.ContainsKey(character) ? dictionary[character] : character;
        }

        Console.WriteLine(result.ToString);
    }
}