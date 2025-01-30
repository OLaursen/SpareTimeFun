namespace Kattis_CS;
using System;
public class ASecondOpinion
{
    static void Main(string[] args)
    {
        var seconds = Int32.Parse(Console.ReadLine()!);
        var h = seconds / (60 * 60);
        var m = (seconds - (h * 60 * 60)) / 60;
        var s = seconds - (m * 60) - (h*60*60);
        
        Console.WriteLine($"{h} : {m} : {s} ");
    }
}