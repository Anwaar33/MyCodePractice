using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodePractice
{
    public class newCodeFile
    {

            int a = 10;
            int b = 20;

            int[] numbers = { 1, 4, 2, 8, 6, 9, 3 };
            public void swapNumbrs()
            {
                a = a + b;
                b = a - b;
                a = a - b;

                Console.WriteLine(" value of a: " + a);
                Console.WriteLine(" value of b: " + b);
            }

            public void reverseArray()
            {
                for (int i = numbers.Length - 1; i >= 1; i--)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            public void thirdLargestNumber()
            {

                int firstNumber = numbers[0];
                int secondNumber = numbers[0];
                int thirdNumber = numbers[0];

                foreach (var item in numbers)
                {
                    if (item > firstNumber)
                    {
                        thirdNumber = secondNumber;
                        secondNumber = firstNumber;
                        firstNumber = item;
                    }
                    else if (item > secondNumber)
                    {
                        thirdNumber = secondNumber;
                        secondNumber = item;
                    }
                    else if (item > thirdNumber)
                    {
                        thirdNumber = item;
                    }
                }

                Console.WriteLine(secondNumber);

                //Array.Sort(numbers);
                //Console.Write(numbers[numbers.Length-3]);
            }

            public void findTargetNumber()
            {
                int target = 10;
                bool found = false;

                foreach (var num in numbers)
                {
                    if (num == target)
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    Console.WriteLine("number exest in given araay");
                }
                else
                {
                    Console.WriteLine("number is not exist in given array");
                }
            }

            public void targetNumberUsingLinq()
            {
                int target = 11;

                if (numbers.Contains(target))
                {
                    Console.WriteLine("number exest in given araay");
                }
                else
                {
                    Console.WriteLine("number is not exist in given array");
                }
            }


            public void checkPlandrom()
            {
                int number = 12321;
                int original = number;
                int reverse = 0;

                while (number > 0)
                {
                    int digit = number % 10;
                    reverse = (reverse * 10) + digit;
                    number = number / 10;
                }

                if (original == reverse)
                {
                    Console.WriteLine("The number is a palindrome.");
                }
                else
                {
                    Console.WriteLine("The number is not a palindrome.");
                }
            }
            public void checkPlandromLinq()
            {
                int number = 12321;
                String str = number.ToString();

                string name = "madam";
                if (name.SequenceEqual(name.Reverse()))
                {
                    Console.WriteLine("The number is a palindrome.");
                }
                else
                {
                    Console.WriteLine("The number is not a palindrome.");
                }


            }

            public void checkPlandromString()
            {
                string name = "madam";
                string reverse = "";

                for (int i = name.Length - 1; i >= 0; i--)
                {
                    reverse = reverse + name[i];
                }

                if (name == reverse)
                {
                    Console.WriteLine("The number is a palindrome.");
                }
                else
                {
                    Console.WriteLine("The number is not a palindrome.");
                }

            }

            public void writeFabionicSeries()
            {
                int n = 10;
                int first = 0;
                int second = 1;

                for (int i = 1; i <= n; i++)
                {
                    Console.Write(first + " ");
                    int next = first + second;
                    second = first;
                    first = next;
                }
            }

            public void checkPrimeNumber()
            {
                int n = 9;
                bool isPrime = true;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("is prime");
                }
                else
                {
                    Console.WriteLine("not prime");
                }
            }

            public void PrintPrime()
            {
                int n = 100;

                for (int i = 2; i <= n; i++)
                {
                    bool isPrime = true;

                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.Write(i + " ");
                    }
                }

            }



            // n! = n(n-1)!
            public void FactorialNumber()
            {
                int n = 5;

                int factorial = 1;

                for (int i = 1; i <= n; i++)
                {
                    factorial = factorial * i;
                }

                Console.WriteLine("Factorial of " + n + " is: " + factorial);
            }

            public void sumOfNumbers()
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                int sum = 0;
                foreach (var item in numbers)
                {
                    sum = sum + item;
                }

                Console.WriteLine("Sum of numbers is: " + sum);
            }

            public void sumOfNumber()
            {

                int num = 345;
                int sum = 0;
                while (num > 0)
                {
                    int digit = num % 10;
                    sum = sum + digit;
                    num = num / 10;
                }
                Console.WriteLine("Sum of digits is: " + sum);
            }

            public void FactorOfGivenNumber()
            {
                int n = 10;

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }

            public void printTrianle()
            {
                int n = 5;
                //int counter = 1;
                for (int i = n; i >= 1; i--)
                {
                    for (int j = i; j <= n; j++)
                    {
                        Console.Write("*");
                        //counter++;
                    }
                    Console.WriteLine();
                }
            }

            public void printTriangleWithNumberPatron()
            {
                int numberOfRows = 8;

                for (int row = numberOfRows; row >= 1; row--)
                {
                    for (int col = row; col < +numberOfRows; col++)
                    {
                        Console.Write(col + " ");
                    }
                    Console.WriteLine();
                }
            }
    }
}
