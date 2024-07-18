using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-Calculator
            int firtnumber, secondnumber;
            Console.WriteLine("first number=");
            firtnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("operation:");
              string operation;
            operation = Console.ReadLine();
            Console.WriteLine("second number=");

            secondnumber = Convert.ToInt32(Console.ReadLine());
            switch(operation)
            {
                case "+": Console.WriteLine($"{firtnumber}+{secondnumber}={firtnumber + secondnumber}"); break;
                case "-":
                    Console.WriteLine($"{firtnumber}-{secondnumber}={firtnumber - secondnumber}");break;
                case "*":
                    Console.WriteLine($"{firtnumber}*{secondnumber}={firtnumber * secondnumber}");break;
                case "/":
                    Console.WriteLine($"{firtnumber}/{secondnumber}={firtnumber / secondnumber}");break;
                default:
                    Console.WriteLine("Operation not found");break;
            }
            //2
            Console.Write("N=");
            int N,s=0;
            again:
            N = Convert.ToInt32(Console.ReadLine());
            if (N > 0)
            {
                for (int i = 1; i < N; i++)
                {
                    s += i;
                }
                Console.WriteLine(s);
            }
            else
                Console.WriteLine("ENTER POSITIVE NUMBER");
            goto again;
            //3
            
           int a = Convert.ToInt32(Console.ReadLine());
            if(a%2==0)
            { Console.WriteLine("number even"); }
            else Console.WriteLine("number even");

        }
    }
}
