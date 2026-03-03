using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Numerics;
using System.Reflection.PortableExecutable;
using static System.Runtime.InteropServices.JavaScript.JSType;

class ProblemSolvingIntermediate
{

    #region Functions Generics
    static int ReadPositiveNumber(string Message)
    {
        int Number;
        Console.WriteLine(Message);

        while (!int.TryParse(Console.ReadLine(), out Number) || Number < 0)
        {

            Console.WriteLine($":-( Invalid Input {Message}");

        }
        return Number;
    }
    #endregion

    #region Problem 1 Drawing A Pyramid 
    static void DrawingPyramid(int heigth)
    {
        int Star = 1;
        int Space = heigth - 1;

        for (int i = 1; i <= heigth; i++)
        {
            for (int j = 0; j < Space; j++)
            { Console.Write(" "); }

            for (int k = 0; k < Star; k++)
            { Console.Write("*"); }
            Console.WriteLine();

            Star += 2;
            Space -= 1;
        }
    }
    #endregion

    #region Problem 2 Drawing A Rhombus 
    static void DrawingRhombus(int height)
    {
        int mid = height / 2;

        for (int i = 0; i < height; i++)
        {
            int level = Math.Min(i, height - i - 1);

            int stars = level + 1;
            int spaces = mid - level;

            for (int s = 0; s < spaces; s++)
                Console.Write(" ");

            for (int k = 0; k < stars; k++)
                Console.Write("* ");

            Console.WriteLine();
        }
    }
    #endregion

    #region Problem 3 Multiplication Table From 1 To N
    static void DrawHeader()
    {
        Console.Write("\n\n\t\t\t\t\tMultiplication Table From 1 to N\n\n\n\n");
        Console.Write("\t\t");

        for (int i = 1; i <= 12; i++)
        { Console.Write($"  {i} \t "); }

        Console.Write("\n\t-----------------------------------------------------------------------------------------------------\n");
    }
    static void PrintMultiplicationTable(int Number)
    {
        DrawHeader();

        for (int i = 1; i <= Number; i++)
        {
            Console.Write($"\t{i,3}   |");

            Console.Write("\t");

            for (int j = 1; j <= 12; j++)
            {
                Console.Write($"  {i * j} \t");
            }
            Console.WriteLine();
        }
    }


    #endregion

    #region Problem 4  Print All Prime Number From 1 To N
    enum enIsPrimeNotPrime { Prime = 1, NotPrime = 0 };
    static enIsPrimeNotPrime CheckNumberPrimeNotPrime(double number)
    {
        double min = Math.Round(number / 2);

        for (int i = 2; i <= min; i++)
        {
            if (number % i == 0)
                return enIsPrimeNotPrime.NotPrime;
        }


        return enIsPrimeNotPrime.Prime;
    }
    static void PrintAllPrimeNumber(double number)
    {

        Console.WriteLine($"Prime Number From 1 To {number} Are : ");

        for (int i = 1; i <= number; i++)
        {
            if (CheckNumberPrimeNotPrime(i) == enIsPrimeNotPrime.Prime)
            {
                Console.WriteLine(i);
            }
        }
    }
    #endregion

    #region Problem 5 Print All Perfect Number From 1 To N

    static bool CheckNumberPerfectNotPerfect(int number)
    {
        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        return number == sum;

    }

    static void PrintAllPerfectNumber(int number)
    {
        for (int i = 1; i < number; i++)
        {
            if (CheckNumberPerfectNotPerfect(i))
            {
                Console.WriteLine(i);
            }
        }


    }
    #endregion

    #region  Problem 6 Print it in a Reversed Order
    static void PrintReversedDigits(int number)
    {

        int remainder = 0;
        int number2 = 0;

        while (number > 0)
        {
            remainder = number % 10;
            number = number / 10;
            number2 = number2 * 10 + remainder;

        }

        Console.WriteLine(number2);


        //With LINQ

        foreach (var digit in number.ToString().Reverse())
        {
            Console.WriteLine(digit);
        }
    }
    #endregion

    #region  Problem 7 Print All  Digits Frequency 
    static int CountDigitFrequency(int number, int digitToCheck)
    {

        int frequency = 0;
        int remainder = 0;
        while (number > 0)
        {
            remainder = number % 10;
            number = number / 10;


            if (remainder == digitToCheck)
            {
                frequency++;
            }
        }
        return frequency;

     
    }
    static void PrintAllDigitsFrequency(int number)
    {
      for(int i = 0;i < 10;i++)
      {
             int digitFrequency = 0;

            digitFrequency = CountDigitFrequency(number ,i);

            if (digitFrequency > 0)
            {
               
            }

            Console.WriteLine($"Digit {i} Frequency Is {digitFrequency} Time(s) .");
        }

       
    }
    #endregion
    static void Main(string[] args)
    {
        //Problem 1 Drawing A Pyramid 

        //int height = ReadPositiveNumber("Please Enter Heigth For Drawing A Pyramid ?");
        //DrawingPyramid(height);

        //Problem 2 Drawing Rhombus

        //int height = ReadPositiveNumber("Please Enter Heigth For Drawing A Rhombus ?");
        //DrawingRhombus(height);

        //Problem 3 Multiplication Table From 1 To N 

        //int number = ReadPositiveNumber("Please Enter A Positive Number To Multiply For 1 To Number ?");
        //PrintMultiplicationTable (number);

        //Problem 4 Print All Prime Number 

        //int number = ReadPositiveNumber("Please Enter A Positive Number ?");
        //PrintAllPrimeNumber(number);

        //Problem 5 Is Perfect Or Not Perfect Number

        //int number = ReadPositiveNumber("Please Enter A Positive Number ?");
        //PrintAllPerfectNumber(number);

        //Problem 6 Print It In A Reversed Order
        //
        //int number = ReadPositiveNumber("Please Enter A Positive Number ?");
        //PrintReversedDigits(number);

        //Problem 7 Count Digits Frequency 

        int number = ReadPositiveNumber("Please Enter The A Number ?");
        PrintAllDigitsFrequency(number);

    }
}

