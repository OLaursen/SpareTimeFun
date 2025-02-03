namespace Kattis_CS;
//https://open.kattis.com/problems/differentdistances
using System;
using System.Collections.Generic;
public class DifferentDistances
{
  public static void Dd(string[] args)
  {
    var results = new List<String>();
    while (true)
    {
      var numbers = new List<double>();
      
      var line = Console.ReadLine()!;
      if (line.Equals("0")) 
          break;
      
      foreach(var number in line.Replace(".", ",").Split(" "))
      {
        numbers.Add(double.Parse(number));
      }
      var p = numbers[4];
      var x = Math.Pow(Math.Abs(numbers[0]-numbers[2]), p);
      var y = Math.Pow(Math.Abs(numbers[1]-numbers[3]), p);
      var root = 1/p;
      
      var pnorm = Math.Pow(x + y,root).ToString("F10").Replace(",", ".");
      
      results.Add(pnorm);
    }

    foreach (var result in results)
    {
      Console.WriteLine(result);
    }
  }
}