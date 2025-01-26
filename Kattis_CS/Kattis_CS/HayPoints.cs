using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;


public class HayPoints
{
    public static void HP()
    {
        var hayDict = new Dictionary<String, Int32>();
        var input = Console.ReadLine()!.Split(" ");
        var wordsInHayPoint = Int32.Parse(input[0]);
        var jobDescriptions =  Int32.Parse(input[1]);
        
        for (int i = 0; i < wordsInHayPoint; i++)
        {
            var line = Console.ReadLine()!.Split(" ");
            hayDict.Add(line[0], Int32.Parse(line[1]));
        }

        var jobDesc = new List<String>();
        for(int i = 0; i < jobDescriptions; i++)
        {
            while (true)
            {
                var intermediary = Console.ReadLine()!;
                if (intermediary.Contains('.'))
                {
                    var haypoints = PointCalc(string.Join(" ", jobDesc).Split(" "));
                    Console.WriteLine(haypoints);
                    break;
                }
                jobDesc.Add(intermediary);
            }
            jobDesc.Clear();
        }

        int PointCalc(String[] jobDesc)
        {
            int result = 0;
            for (int i = 0; i < jobDesc.Length; i++)
            {
                result += hayDict.GetValueOrDefault(jobDesc[i], 0);
            }
            return result;
        }
    }
}