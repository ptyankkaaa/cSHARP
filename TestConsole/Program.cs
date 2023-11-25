using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld;

class Program
{
    public static double Calculate(int amountOFcredit, int interestRate, int depositTerm)
    {
        return amountOFcredit*((1+(interestRate/12))^depositTerm);
    }
    static void Main(string[] args)
    {

        Console.WriteLine("Enter amount of credit");
        int amountOFcredit = Convert.ToInt32(Console.ReadLine());
        

        Console.WriteLine("Enter interest rate in percent");
        int interestRate = Convert.ToInt32(Console.ReadLine());
        

        Console.WriteLine("Enter the deposit term in months");
        int depositTerm = Convert.ToInt32(Console.ReadLine());
        

        Console.WriteLine($"Amount of credit : {amountOFcredit}");
        Console.WriteLine($"interest rate in percent : {interestRate}");
        Console.WriteLine($"Deposit term in month : {depositTerm}");
        Console.WriteLine($"SUM = {Calculate(amountOFcredit, interestRate, depositTerm)}");
        
    }
}