using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace true_stuff
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int fact(int num) // method to figure out the factorial of a number
            {
                int tn = num;
                int j = 0;
                for (j = 1; j < tn; j++)
                {
                    num = num * j;
                }
                return num;
            }
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            string choice2 = "";
            string nextvalue = "";
            string finalvalue = "";
            string choice = "";
            Console.WriteLine("What option would you like 1 = Addition 2 = Subtraction 3 for Multiplication 4 for Division" +
                "5 for Square roots 6 for basic binomial expansion eg (5 + 3x)^4 7 for SOHCAHTOA triganomatry");
            choice = Console.ReadLine();
            if (choice == "1") //basic addition
            {
                Console.WriteLine("Enter first number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(num1 + num2);

            }
            else if (choice == "2") //basic subtraction
            {
                Console.WriteLine("Enter first number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number to subtract");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(num1 - num2);
                
            }
            else if (choice == "3") //basic multiplication
            {
                Console.WriteLine("Enter first number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(num1 * num2);
            }
            else if (choice == "4") //Basic division
            {
                Console.WriteLine("Enter first number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number to divide by");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            else if (choice == "5") //square roots
            {
                Console.WriteLine("Enter your number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(num1));
            }
            else if (choice == "6") //Binomaial expansion
            {
                Console.WriteLine("Enter values in the format (z + yx)^f.");
                Console.WriteLine("Enter the value for z");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the value for y");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the value for f");
                num3 = int.Parse(Console.ReadLine());
                for (int i = 0; i <= num3; i++)
                {
                    if (i == 0)
                    {
                        nextvalue = ($"{1 * (Math.Pow(num1, num3 - i)) * (Math.Pow(num2, i))}"); //handles when the r in nCr is 0
                        finalvalue = finalvalue + nextvalue + " + ";
                    }
                    else if (num3 - i == 0) //handles when the r in nCr is the same as the n
                    {
                        nextvalue = ($"{1 * (Math.Pow(num1, num3 - i)) * (Math.Pow(num2, i))} x^{num3}");
                        finalvalue = finalvalue + nextvalue;
                    }
                    else //handles the rest of the statements
                    {
                        nextvalue = ($"{(fact(num3)) / (fact(i) * fact(num3 - i)) * (Math.Pow(num1, num3 - i)) * (Math.Pow(num2, i))}x^{i}");
                        finalvalue = finalvalue + nextvalue + " + ";
                    }
                    

                }
                Console.WriteLine(finalvalue);
                

            }
            else if (choice == "7")
            {
                Console.WriteLine("Sin (1) Cos (2) Tan (3)"); //handles basic sohcahtoa
                choice2 = Console.ReadLine();
                if (choice2 == "1") //works out the sine of an angle
                {
                    Console.WriteLine("Enter opposite.");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter hypotoneuse.");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Sin(num1 / num2));
                }
                else if (choice2 == "2") //works out the cosine of an angle
                {
                    Console.WriteLine("Enter adjacent.");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter hypotoneuse.");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Cos(num1 / num2));
                }
                else if (choice2 == "3") //works out the tangent of an angle
                {
                    Console.WriteLine("Enter opposite.");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter adjacent.");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Tan(num1 / num2));
                }
            }
        }
    }
}
