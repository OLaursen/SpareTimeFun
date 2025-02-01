namespace Kattis_CS;
//https://open.kattis.com/problems/differentdistances
using System;
public class DifferentDistances
{
  public static void Main(string[] args)
  {
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
      var x = Math.Pow(Math.Abs(numbers[0]-numbers[1]), p);
      var y = Math.Pow(Math.Abs(numbers[2]-numbers[3]), p);

      var pnorm = Math.Pow(x - y, 1.0d / p);
      
      Console.WriteLine();
    }
  }
}