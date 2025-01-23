namespace Kattis_CS;

using System.Collections.Generic;
using System.Collections;
using System.Runtime;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        /*
         Intro to game:
         
         A board row is N squares with a non-zero integer in them, from 1 to n, left to right.
         a the start the player rolls an n-sided die. And places a frog token on the resulting index.
         Then a player picks a card, wwhich holds the magic/goal number of the game. 
         
         Rules:
         The player can apply the rules as many times as they want, until the game ends:
         
         1. If the frog is on a positively indexed square, k, the frog makes length-k hop to the right. 
         2. If the frog is on a square containing a negative integer, the frog makes a length-|k| jump to the left.
         
         Endgame if:
         
         1. The frog is on the sqaure containing goal number, can happen immeadiately.
         2. The frog falls off the left end of the board
         3. The frog falls off the right end of the board
         4. The frog hops onto a square where the frog has been before, and therefore is trapped in a circle.
          
         */
        var result = new List<String> {"magic", "cycle", "right", "left"};
        var visitedSquares = new List<Int32>();
        var gameInfo = Console.ReadLine()!.Split(" ");

        var n = Int32.Parse(gameInfo[0]);
        var s = Int32.Parse(gameInfo[1]);
        var m = Int32.Parse(gameInfo[2]);

        var squares = new List<Int32>();
        var stringSquares = Console.ReadLine()!.Split(" ");
        foreach (var square in stringSquares)
        {
            squares.Add(Int32.Parse(square));
        }

        //Variables for while-loop
        var hops = 0;
        var currentIndex = s-1;

        while (true)
        { 
            //Check if we've fallen off rightside(Positive)
            if (currentIndex > squares.Count-1)
            {
                Console.WriteLine(result[2]);
                Console.WriteLine(hops);
                break;
            }
            
            //Check if we've fallen off leftside(negative)
            if (currentIndex < 0)
            {
                Console.WriteLine(result[3]);
                Console.WriteLine(hops);
                break;
            }
            
            //Check if current index is goal index
            if (squares[currentIndex] == m)
            {
                Console.WriteLine(result[0]);
                Console.WriteLine(hops);
                break;
            }
            //Check if we've visited current index
            if (visitedSquares.Contains(currentIndex))
            {
                Console.WriteLine(result[1]);
                Console.WriteLine(hops);
                break;
            }
            
            visitedSquares.Add(currentIndex);
            currentIndex += squares[currentIndex];
            hops++;

        }
    }
}