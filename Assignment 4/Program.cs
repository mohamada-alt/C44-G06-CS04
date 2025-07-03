using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        #region Q1 
        //Write a program that takes a number from the user then print yes if that
        //number can be divided by 3 and 4 otherwise print no.

        Console.WriteLine("Enter A Number");
        int x = int.Parse(Console.ReadLine());
        if (x % 3 == 0 && x % 4 == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        #endregion
        #region Q2
        //Write a program that allows the user to insert an integer then print
        //negative if it is negative number otherwise print positive.

        Console.WriteLine("Enter A Number");
        double x = double.Parse(Console.ReadLine());
        if (x > 0)
        {
            Console.WriteLine(x * -1);
        }
        else
        {
            Console.WriteLine(x * -1);
        }
        #endregion
        #region Q3
        //Write a program that takes 3 integers from the user then prints the max
        //element and the min element.

        Console.WriteLine("Enter 3 Numbers");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());
        int max = x;
        int min = x;

        if (y > max)
            max = y;
        if (z > max)
            max = z;

        if (y < min)
            min = y;
        if (z < min)
            min = z;
        Console.WriteLine("The Max Number Is: " + max);
        Console.WriteLine("The Min Number Is: " + min);
        #endregion
        #region Q4
        //Write a program that allows the user to insert an integer number then
        //check If a number is even or odd.

        Console.WriteLine("Enter A Number");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("The Number Is Even");
        }
        else
        {
            Console.WriteLine("The Number Is Odd");
        }
        #endregion
        #region Q5
        //Write a program that takes character from the user then if it is a vowel
        //chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).

        Console.WriteLine("Enter A Letter");
        string x = Console.ReadLine().ToLower();
        string[] vowel = { "a", "e", "i", "o", "u" };
        if (vowel.Contains(x))
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("consonant");
        }

        #endregion
        #region Q6
        //Write a program that allows the user to insert an integer then print all
        //numbers between 1 to that number.

        Console.WriteLine("Enter A Number");
        int num = int.Parse(Console.ReadLine());
        if (num > 0)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.Write(i + " ");
            }
        }
        else
        {
            for (int i = 1; i >= num; i--)
            {
                Console.Write(i + " ");
            }
        }
        #endregion
        #region Q7
        //Write a program that allows the user to insert an integer then
        //print a multiplication table up to 12.

        Console.WriteLine("Enter A Number");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 12; i++)
        {
            Console.Write(num * i + " ");
        }
        #endregion
        #region Q8
        //Write a program that allows to user to insert number then print all even
        //numbers between 1 to this number

        Console.WriteLine("Enter A Number");
        int num = int.Parse(Console.ReadLine());
        if (num > 0)
        {
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        else
        {
            for (int i = 1; i >= num; i--)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

        }
        #endregion
        #region Q9
        //Write a program that takes two integers then prints the power.

        Console.WriteLine("Enter 2 Numbers");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int result = 1;
        for (int i = 1; i <= num2; i++)
        {
            result *= num1;
        }
        Console.WriteLine(result);
        #endregion
        #region Q10
        //Write a program to enter marks of five subjects and calculate total,
        //average and percentage.

        Console.WriteLine("Enter Marks Of Five Subjects");
        int[] marks = new int[5];
        int total = 0;
        double avg = 0;
        double percent = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Marks Of Subject {i + 1}");
            marks[i] = int.Parse(Console.ReadLine());
            total += marks[i];
        }

        avg = total / 5;
        percent = (total * 100) / 500;
        Console.WriteLine("The Total Is: " + total);
        Console.WriteLine("The Average Is: " + avg);
        Console.WriteLine("The percentage Is: " + percent);

        #endregion
        #region Q11
        //Write a program to input the month number and print the number of days in that month.

        Console.WriteLine("Enter Number Of The Month");
        int n_of_month = int.Parse(Console.ReadLine());
        int[] case1 = { 1, 3, 5, 7, 8, 10, 12 };
        int[] case2 = { 4, 6, 9, 11 };

        if (case1.Contains(n_of_month))
        {
            Console.WriteLine("Number Of Dayes In This Month Is: 31");
        }
        else if (case2.Contains(n_of_month))
        {
            Console.WriteLine("Number Of Dayes In This Month Is: 30");
        }
        else
        {
            Console.WriteLine("Number Of Dayes In This Month Is: 29");
        }
        #endregion
        #region Q12
        //Write a program to create a Simple Calculator.

        Console.WriteLine("Enter Number 1");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter Number 2");
        float num2 = float.Parse(Console.ReadLine());
        float sum = num1 + num2;
        float minus = num1 - num2;
        float multiply = num1 * num2;
        float divid = num1 / num2;
        Console.WriteLine("Choose One Of This Operators +  -  x  /");
        string sign = Console.ReadLine();
        if (sign == "+")
        {
            Console.WriteLine("The Result Is: " + sum);
        }
        else if (sign == "-")
        {
            Console.WriteLine("The Result Is: " + minus);
        }
        else if (sign == "x")
        {
            Console.WriteLine("The Result Is: " + multiply);
        }
        else
        {
            Console.WriteLine("The Result Is: " + divid);
        }
        #endregion
        #region Q13
        //Write a program to allow the user to enter a string and print the REVERSE of it.

        Console.WriteLine("Enter A Text");
        string text = Console.ReadLine();
        for (int i = text.Length - 1; i >= 0; i--)
        {
            Console.Write(text[i]);
        }
        #endregion
        #region Q14
        //Write a program to allow the user to enter int and print the REVERSED of it.

        Console.WriteLine("Enter A Number");
        int num = int.Parse(Console.ReadLine());
        string text = num.ToString();
        for (int i = text.Length - 1; i >= 0; i--)
        {
            Console.Write(text[i]);
        }
        #endregion
        #region Q15
        //Write a program in C# Sharp to find prime numbers within a range of numbers.

        Console.WriteLine("Input starting number of range: ");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Input ending number of range: ");
        int end = int.Parse(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            bool isprime = true;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isprime = false;
                    break;
                }
            }

            if (isprime)
            {
                Console.Write(i + " ");
            }
        }
        #endregion
        #region Q16
        //Create a program that asks the user to input three points(x1, y1), (x2,y2), and(x3, y3), 
        //and determines whether these points lie on a single straight line.

        Console.WriteLine("Enter The First Point");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter The Second Point");
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter The First Point");
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        double area = 0.5 * Math.Abs(x1 * (y2 - y3) +
                                     x2 * (y3 - y1) +
                                     x3 * (y1 - y2));

        if (area == 0)
        {
            Console.WriteLine("The Points Are On a Single Straight Sine");
        }
        else
        {
            Console.WriteLine("The Points Are Not On a Single Straight Sine");
        }

        #endregion
        #region Q17
        Console.WriteLine("The number of hours you take to complete the task");
        double num=int.Parse(Console.ReadLine());
        if (num <= 3)
        {
            Console.WriteLine("Considered Highly Efficient");
        }
        else if (num <= 4) {
            Console.WriteLine("Increase Their Speed");
        }
        else if (num <= 5)
        {
            Console.WriteLine("Training To Enhance Their Speed");
        }
        else if (num > 5)
        {
            Console.WriteLine("Required To Leave The Company.");
        }
        #endregion

    }
}