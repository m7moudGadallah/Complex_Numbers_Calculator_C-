using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Number_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Complex Numbers Calculators :)\n");

            Console.Write("Enter First Number (x+i*y) : ");
            string num1 = Console.ReadLine();

            Console.Write("Enter Second Number (x+i*y): ");
            string num2 = Console.ReadLine();


            string res = "";
            Complex.Add(num1, num2, ref res);       //invoking Add method
            Console.WriteLine($"\nSummation Result: {res}\n");

            Complex.Sub(num1, num2, ref res);           //invoking Sub method
            Console.WriteLine($"Subtraction Result: {res}\n");


            Complex.Multi(num1, num2, ref res);     //invoking Multi method
            Console.WriteLine($"Multiplication Result: {res} \n");

            Complex.Divide(num1, num2, ref res);    //invokin Divide method
            Console.WriteLine($"Divison Result: {res} \n");
        }
    }
}
