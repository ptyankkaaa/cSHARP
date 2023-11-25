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

        Console.WriteLine("Enter amount of credit");
        double amountOFcredit = Convert.ToDouble(Console.ReadLine());
        

        Console.WriteLine("Enter interest rate in percent");
        double interestRate = Convert.ToDouble(Console.ReadLine());
        

        Console.WriteLine("Enter the deposit term in months");
        double depositTerm = Convert.ToDouble(Console.ReadLine());
        

        Console.WriteLine($"Amount of credit : {amountOFcredit}");
        Console.WriteLine($"interest rate in percent : {interestRate}");
        Console.WriteLine($"Deposit term in month : {depositTerm}");
        Console.WriteLine($"SUM = {Calculate(amountOFcredit, interestRate, depositTerm)}");
        
    }
}