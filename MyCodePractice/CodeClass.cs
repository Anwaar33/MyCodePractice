using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCodePractice
{
    public class CodeClass
    {

        int a = 10;
        int b = 20;
        int[] number = { 1, 4, 2, 8, 6, 9, 3 };

        // swap two numbers without using third variable
        public void swap()
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
        }

        // reverse an array
        public void reverse()
        {
            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i] + " ");
            }
        }


        // sort an array
        public void Sort()
        {
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] > number[j])
                    {
                        int temp = number[j];
                        number[j] = number[i];
                        number[i] = temp;
                    }
                }
            }
            foreach (var item in number)
            {
                Console.Write(item + " ");
            }
        }

        // find third highest number in array
        public void secongLargeNumber()
        {
            int firstHighest = number[0];
            int secondHighest = number[0];
            int thirdHighest = number[0];

            foreach (var item in number)
            {
                if (item > firstHighest)
                {
                    thirdHighest = secondHighest;
                    secondHighest = firstHighest;
                    firstHighest = item;

                }
                else if (item > secondHighest)
                {
                    thirdHighest = secondHighest;
                    secondHighest = item;
                }
                else if (item > thirdHighest)
                {
                    thirdHighest = item;
                }
            }
            Console.WriteLine("Second Highest: " + firstHighest);
        }
        public void secongSmallNumber()
        {
            var secondhighest = number.Distinct().OrderByDescending(x => x).Skip(3).FirstOrDefault();

            Console.WriteLine("Second Highest: " + secondhighest);
        }

        // find target number in array
        public void targitNo()
        {
            int targitNo = 6;
            bool found = false;

            foreach (var item in number)
            {
                if (item == targitNo)
                {
                    found = true;
                    break;
                }

            }

            if (found)
            {
                Console.WriteLine("Targit No " + targitNo + " Found in given Array");
            }
            else
            {
                Console.WriteLine("Targit No " + targitNo + " Not Found in given Array");
            }
        }

        public void targitNoUsingLinq()
        {
            int targitNo = 6;

            if (number.Contains(targitNo))
            {
                Console.WriteLine("Targit No " + targitNo + " Found in given Array");
            }
            else
            {
                Console.WriteLine("Targit No " + targitNo + " Not Found in given Array");

            }
        }

        // check if number is palindrome or not
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
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
        }

        // write fabionic series
        public void writeFabionicSeries()
        {
            int n = 10;
            int first = 0;
            int second = 1;

            Console.WriteLine("Fibonacci Series:");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(first + " ");
                int next = first + second;
                second = first;
                first = next;
            }
        }

        // check if number is prime or not
        public void checkPrimeNumber()
        {
            int n = 10;
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
                Console.WriteLine(n + " is a prime number.");
            }
            else
            {
                Console.WriteLine(n + " is not a prime number.");
            }

        }

        // print pramery number from 1 to n
        public void printPriemeNumber()
        {
            int n = 10;
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


        //sum of given Array
        public void sumOfNumbers()
        {
            int[] number = { 1, 2, 3, 4, 5 };

            int sum = 0;
            foreach (var item in number)
            {
                sum = sum + item;
            }

            Console.WriteLine("Sum of given numbers: " + sum);
        }

        // sum of given number
        public void sumOfNumber()
        {
            int num = 123;
            int sum = 0;


            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
            }
            Console.WriteLine("Sum of given number: " + sum);
        }

    }
}
