namespace Kattis_CS;
using System;
public class AboveAverage
{
    public static void Aboveaverage(String[] args)
    {
        var tests = Int32.Parse(Console.ReadLine()!);

        for (int i = 0; i < tests; i++)
        {
            var scores = (Console.ReadLine()!.Split(" "));
            int[] intScores = new Int32[scores.Length];
            var sum = 0;
            
            for (int j = 0; j < scores.Length; j++)
            {
                intScores[j]=Int32.Parse(scores[j]);
                sum += intScores[j];
            }
            
            int amount = intScores[0];
            var avg = (sum-amount) / amount;
            var studentsAbove = 0;
            for (int j = 1; j < scores.Length; j++)
            {
                if (intScores[j] > avg)
                {
                    studentsAbove++;
                }
            }
            var percentageAboveAvg= studentsAbove/(amount * 1.00) * 100;  
            
            Console.WriteLine($"{Math.Round(percentageAboveAvg, 3):#.000}%");
        }
    }
}