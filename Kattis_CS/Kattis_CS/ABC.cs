

namespace Kattis_CS;
using System;
using System.Linq;
using  System.Collections.Generic;

public class Abc
{
    public static void Main(string[] args)
    {
        var parsedNumbers = new List<int>();
        var numbers = Console.ReadLine()!.Split(" ");
        
        for(int i = 0; i < 3; i++)
        {
            parsedNumbers.Add(int.Parse(numbers[i]));
        }
        
        parsedNumbers.Sort();
        
        var order = Console.ReadLine()!.ToCharArray();

        for (int i = 0; i < 3; i++)
        {
            switch (order[i])
            {
                case 'A':
                    Console.Write(parsedNumbers[0]+ " ");
                    break;
                case 'B':
                    Console.Write(parsedNumbers[1]+ " ");
                    break;
                case 'C':
                    Console.Write(parsedNumbers[2]+ " ");
                    break;
            }
        }

    }
}