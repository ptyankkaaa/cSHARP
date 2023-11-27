using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole;

class Program
{
    public static double Calculate(string userInput)
    {
        string[] values = userInput.Split(' ');
        var amountOFcredit = Convert.ToDouble(values[0]);
        var interestRate = Convert.ToInt32(values[1]);
        var depositTerm = Convert.ToInt32(values[2]);
        return amountOFcredit * Math.Pow((1+(interestRate/(100*12))),depositTerm);
    }
    static void Main(string[] args)
    {
    
        Console.WriteLine("Enter data:");
        double[] str = Console.ReadLine();
        Console.WriteLine($"SUM = {Calculate(str)}");
    }
}