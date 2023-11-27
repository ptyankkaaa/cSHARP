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
        var amountOFcredit = Convert.ToInt32(values[0]);
        var interestRate = Convert.ToDouble(values[1]);
        var depositTerm = Convert.ToDouble(values[2]);
        return amountOFcredit * Math.Pow((1+(interestRate/(100*12))),depositTerm);
    }
    static void Main(string[] args)
    {
    
        Console.WriteLine("Enter data:");
        string str = Console.ReadLine();
        Console.WriteLine($"SUM = {Calculate(str)}");
    }
}