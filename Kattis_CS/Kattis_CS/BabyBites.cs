namespace Kattis_CS;

using System;
public class BabyBites
{
    public static void Bb(string[] args)
    {
        var fail = "something is fishy";
        var success = "makes sense";
        var number = int.Parse(Console.ReadLine()!);
        var input = Console.ReadLine().Split(" ");
        
        if (input.Length > number || input.Length < number)
        {
            Console.WriteLine(fail);
        }

        for (int i = 0; i < number; i++)
        {
            if ( !input[i].Equals($"{i+1}") && !input[i].Equals("mumble"))
            {
                Console.WriteLine(fail);
                System.Environment.Exit(0);
            }
        }
        Console.WriteLine(success);
    }
}