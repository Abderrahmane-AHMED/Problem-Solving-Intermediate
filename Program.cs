using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Numerics;
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
    static void  DrawingPyramid(int heigth)
    {
        int Star = 1;
        int Space = heigth - 1;

        for (int i = 1; i <= heigth; i++)
        {
            for (int j = 0; j < Space; j++)
            { Console.Write(" "); }

            for (int k = 0; k < Star; k++)
            {Console.Write("*");}
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
    #endregion Problem 3 Multiplication Table From 1 To N
    static void DrawHeader()
    {
        Console.Write("\n\n\t\t\t\t\tMultiplication Table From 1 to N\n\n\n\n");
        Console.Write("\t\t");

        for (int i = 1;i <= 12;i++)
        { Console.Write($"  {i} \t "); }

        Console.Write("\n\t-----------------------------------------------------------------------------------------------------\n");
    }
    static void PrintMultiplicationTable(int Number)
    {
        DrawHeader();

        for (int i = 1; i <= Number; i++)
        {
            Console.Write($"\t{i, 3}   |");

            Console.Write("\t");

            for (int j = 1; j <= 12; j++)
            {   
              Console.Write($"  {i * j} \t");   
            }
            Console.WriteLine();
        }
    }

    #region
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

        int Number = ReadPositiveNumber("Please Enter A Number To Multiply For 1 To Number ?");
        PrintMultiplicationTable (Number);
    }
}
