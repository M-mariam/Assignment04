using System;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;

namespace ConsoleApp4
{
    internal class Program
    {
        // 1. class -> function
        // 2. struct -> function
        // 3. Interfaces -> function
        // 4. Enum

        //static void PrintShape()
        //  {
        //      // Body
        //      for (int i = 1; i <= 10; i++)
        //      {
        //          Console.WriteLine("==");

        //      }
        //  }
        static void PrintShape(int Count, string Patern)
        {
            // Body
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Patern);

            }
        }
        static int SumNumbers(int Num01, int Num02)
        {
            return Num01 + Num02;
        }
        static (int sum, int Sub) SumSubNumbers (int[] Arr)
        {
            int sum = Arr[0] + Arr[1];
            int Sub = Arr[2] + Arr[3];
            return (sum , Sub);

        }
        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= num /2 ; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //static void Swap(int X, int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //static void Swap(ref int  X,ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        //static int SumArray(int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr[0] = 100;
        //    for(int i = 0; i <Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //}
        //static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //}
        //static int SumArray( int[] Arr)
        //{
        //    int Sum = 0;
        //    Arr = new int[] {10,20,30};
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //}
     
        static void Main(string[] args)
        {
            #region 1D ARRAY
            //int[] numbers;
            //// declare for ref from type 'array of integers'
            //// numbers : can refer to Object From type 'Array of int'
            //// nUMBERS : REFERE to null
            //// 8 bytes will allocated at stach for the ref
            //// 8 will be allocated at heap

            //numbers = new int[5];
            //Console.WriteLine(numbers[0]); // zero
            //numbers[0] = 12;
            //numbers[1] = 6;
            //numbers[2] = 7;
            //numbers[3] = 10;
            //numbers[3] = 10;
            ////numbers[5] = 15;   // out of range
            //Console.WriteLine(numbers[0]);

            //int[] numbers01 = { 1, 2, 3, 4 };
            //int[] numbers02 = new int [4] { 1, 2, 3, 4 };
            //int[] numbers03 =new int [] { 1, 2, 3, 4 };

            //for (int i = 0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter numbers{(i)}:");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("------------------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] );
            //}
            //Console.WriteLine(numbers.LongLength); // size
            //Console.WriteLine(numbers.Rank); //  dimension -> 1


            #endregion

            #region 2D ARRAY
            //int[,] Marks = new int[3, 3];
            //Marks[0, 0] = 99;
            //Marks[0, 1] = 88;
            //Marks[0, 3] = 99;

            //Marks[1, 0] = 99;
            //Marks[1, 1] = 88;
            //Marks[1, 3] = 99;

            //Marks[2, 0] = 99;
            //Marks[2, 1] = 88;
            //Marks[2, 3] = 99;

            //for(int i = 0; i < 3; i++)
            //{
            //    for (int j =0; j <3; j++)
            //    {
            //        Console.WriteLine($"Enter marks[{i}, {j}]");
            //        Marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("=========================");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{Marks[i,j]} ");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Jadded Array 
            //int[][] Marks = new int[3][];
            //Marks[0] = new int[] { 1, 2, 3 };
            //Marks[1] = new int[] { 1, 2};
            //Marks[3] = new int[] { 1, 2, 3, 4 };
            //Marks[0] = new int[3] ;
            //Marks[1] = new int[5] ;
            //Marks[2] = new int[2];

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.Write($"marks [{i}][{j}]");

            //        Marks[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.Write($"{Marks[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Function
            // Function Prototype
            // 1. Signature
            // 1.1 name
            // 1.2 return type
            // 1.3 Parameters (Input)
            // 2. Body (Code)

            // Calling
            //PrintShape();
            //PrintShape(2);
            //PrintShape(2, "--"); // passing by order
            PrintShape(Patern: "--", Count: 4); // passing by Names
            // Methods:
            // 1. Class Member methode: static
            // 2. Object Member Method: non static 
            SumNumbers(5, 10);
            #endregion

            #region Passing Parameters
            //// 1. Passing by Value
            //int A = 4, B = 5;
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");
            //Console.WriteLine("After swapwing ");
            //Swap(A,B);
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");
            // 2.Passing By Reference 

            //int A = 4, B = 5;
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");
            //Console.WriteLine("After swapwing ");
            //Swap(ref A, ref B);
            //Console.WriteLine($"A: {A}");
            //Console.WriteLine($"B: {B}");

            #endregion

            #region Passing Parameters Reference Type
            // Passing Parameters Ref Type
            // 1. Value
            //int[] Numbers = { 1, 2, 3 };
            //int result = SumArray(Numbers);
            //Console.WriteLine(result); // 105
            //Console.WriteLine(Numbers[0]); // 100
            //// 2. Reference
            //int[] Numbers = { 1, 2, 3 };
            //int result = SumArray(ref Numbers);
            //Console.WriteLine(result); // 105
            //Console.WriteLine(Numbers[0]); 
            // EXO2
            //// Value
            //int[] Numbers = { 1, 2, 3 };
            //int result = SumArray(Numbers);
            //Console.WriteLine(result);  // 60
            //Console.WriteLine(Numbers[0]); // 1
            // Ref

            //int[] Numbers = { 1, 2, 3 };
            //int result = SumArray(ref Numbers);
            //Console.WriteLine(result);  // 60
            //Console.WriteLine(Numbers[0]); //10 
            #endregion

        }
    }
}
