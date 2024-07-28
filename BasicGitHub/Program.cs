using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace BasicGitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-Calculator
            int firtnumber, secondnumber;
            Console.WriteLine("first number:");
            firtnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("operation:");
          string  operation = Console.ReadLine();
          
            Console.WriteLine("second number:");
           secondnumber = Convert.ToInt32(Console.ReadLine());

           Calculator k = new Calculator();
           k.calculate(firtnumber,secondnumber,operation);
            //2 SUM OF NUMBERS FROM 1 TO N
            Console.Write("N=");
            int N,s=0;
            again:
            N = Convert.ToInt32(Console.ReadLine());
           k.sum_ofnum(N);
            //3//even number or odd number
            
           int a = Convert.ToInt32(Console.ReadLine());
            k.even_or_odd(a);

        }
    }
}
