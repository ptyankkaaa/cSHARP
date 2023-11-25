using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole;

class Program
{
    public static double Calculate(double amountOFcredit, double interestRate, double depositTerm)
    {
        return amountOFcredit * Math.Pow((1+(interestRate/(100*12))),depositTerm);
    }
    static void Main(string[] args)
    {
    
        Console.WriteLine("Enter data:");
        double[] str = Console.ReadLine().Split().Select(double.Parse).ToArray();
        Console.WriteLine($"SUM = {Calculate(str[0], str[1], str[2])}");
    }
}