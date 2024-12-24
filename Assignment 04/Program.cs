using System;
using System.Numerics;
using System.Threading.Channels;

namespace Assignment_04
{
    internal class Program
    {
        #region Value Type
        //static void Swap(int X, int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}
        // By Reference
        static void Swap(ref int X, ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }
        #endregion
        #region Q2 Reference Type
        // By Valye
        //static int SumArray(int[] Arr)
        //{
        //    int Sum = 0;
        //    //Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //}
        // By Reference
        static int SumArray(ref int[] Arr)
        {
            int Sum = 0;
            //Arr[0] = 100;
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }
        #endregion

        #region Q3
        static void SumAndSub(int Num1, int Num2, out int Sum, out int Sub)
        {
            Sum = Num1 + Num2;
            Sub = Num1 - Num2;
        }
        #endregion
        #region Q4
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return sum;
        }

        static bool IsPrime(int num)
        {
            if (num < 2)

                return false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;

            }
            return true;

        }
        #region Q6
        static void MinMaxArray(ref int[] Arr, out int Max, out int Min)
        {
            Max = Arr[0];
            Min = Arr[0];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Max < Arr[i])
                    Max = Arr[i];
                if (Min > Arr[i])
                    Min = Arr[i];

            }
        }
        #endregion
        #region
        static long factorialOfNumber(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
        static string ChangeChar(string text, int index, char character)
        {
            text = text.Remove(index, 1);
            text = text.Insert(index, character.ToString());
            return text;
        }

        #endregion
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //// By Value
            // int X = 15;
            // int Y = 20;
            // Console.WriteLine($"X: {X} Y: {Y}");
            // Console.WriteLine("After swapwing ");

            // Swap(X, Y);
            // Console.WriteLine($"X: {X} Y: {Y}");

            //// By Reference 
            //int X = 4, Y = 5;
            //Console.WriteLine($"X: {X} Y: {Y} "); // 4 , 5
            //Console.WriteLine("After swapwing ");
            //Swap(ref X, ref Y);
            //Console.WriteLine($"X: {X} Y: {Y} "); // 5 , 4

            #endregion
            #region Q2
            //////By Value
            //int[] Numbers = { 1, 2, 3 };
            //int result = SumArray(Numbers);
            //Console.WriteLine(result); // 105
            //Console.WriteLine(Numbers[0]); // 100
            //// By Reference
            //int[] Numbers = { 1, 2, 3 };
            //int result = SumArray(ref Numbers);
            //Console.WriteLine(result); // 105
            //Console.WriteLine(Numbers[0]); //100
            #endregion
            #region Q3
            //int Num1 = 5, Num2 = 6;
            //int Sum, Sub;
            //SumAndSub(Num1, Num2, out Sum, out Sub);
            //Console.WriteLine($"Sum is equal {Sum}");
            //Console.WriteLine($"Sub is equal {Sub}");
            #endregion

            #region Q4
            //int number;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter A number");
            //    flage = int.TryParse(Console.ReadLine(), out number);

            //}
            //while (!flage);
            //int res = SumOfDigits(number);
            //Console.WriteLine($"The sum of the digits of the number {number} is{res}");
            #endregion

            #region Q5
            //int number;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter A number");
            //    flage = int.TryParse(Console.ReadLine(), out number);

            //}
            //while (!flage);
            //Console.WriteLine(IsPrime(number));
            #endregion
            #region Q6
            //int size;
            //bool flage;
            //do
            //{ 
            //    Console.WriteLine("Enter Array size");
            //    flage = int.TryParse(Console.ReadLine(), out size);

            //} while (!flage);
            //int[] Arr = new int[size];
            //bool flage02;

            //for (int i =0; i< size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter A number");
            //        flage02 = int.TryParse(Console.ReadLine(), out Arr[i]);

            //    } while (!flage02);
            //}
            //int Max, Min;
            //MinMaxArray(ref Arr , out Max, out Min);
            //Console.WriteLine($"Maximum number is: {Max}");
            //Console.WriteLine($"minimun number is: {Min}"); 
            #endregion
            #region Q7
            //int number;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter A number");
            //    flage = int.TryParse(Console.ReadLine(), out number);
            //} while (!flage);
            //long result02 = factorialOfNumber(number);
            //Console.WriteLine(result02);
            #endregion
            #region Q8
            //string text;
            //Console.WriteLine("Enter any word");
            //text = Console.ReadLine();
            //Console.WriteLine("Enter index");
            //int index = int.Parse(Console.ReadLine());
            //Console.WriteLine("char");
            //char c = char.Parse(Console.ReadLine());
            //string result03 = ChangeChar(text, index, c);
            //Console.WriteLine(result03);
            #endregion
            #region Q9
            //int num;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter A number");
            //    flage = int.TryParse(Console.ReadLine(), out num);
            //} while (!flage);
            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j < num; j++)
            //    {
            //        if (i == j)
            //            Console.Write($"{1}");
            //        else
            //            Console.Write($"{0}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Q10
            //int size;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter size");
            //    flage = int.TryParse(Console.ReadLine(), out size);
            //} while (!flage);
            //int[] Arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    bool flage02;
            //    do
            //    {
            //        Console.WriteLine("Enter numbers");
            //        flage02 = int.TryParse(Console.ReadLine(), out Arr[i]);
            //    } while (!flage02);
            //}
            //int sum = 0;
            //for(int i = 0; i < size; i++)
            //{
            //    sum += Arr[i];
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Q11
      

          
            #endregion
            #region Q12
            //int size;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter size");
            //    flage = int.TryParse(Console.ReadLine(), out size);
            //} while (!flage);
            //int[] Arr1 = new int[size];
            //int[] Arr2 = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    bool flage2;
            //    do
            //    {
            //        Console.WriteLine($"enter numbers {i * i}");
            //        flage2 = int.TryParse(Console.ReadLine(), out Arr1[i]);
            //        Arr2[i] = -1;
            //    } while (!flage2);

            //}
            //int  counter = 0; 
            //for (int i = 0; i < size; i++)
            //{
            //    counter = 1;
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (Arr1[i] == Arr1[j])
            //        {
            //            counter++;
            //            Arr2[j] = 0;
            //        }

            //    }
            //    if (Arr2[i] != 0)
            //    {
            //        Arr2[i] = counter;
            //    }
            //}
            //Console.WriteLine("frequancy equal ");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"{Arr1[i]} repeated {Arr2[i]}");
            //}
            #endregion
            #region Q13
            //int size;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter size");
            //    flage = int.TryParse(Console.ReadLine(), out size);
            //} while (!flage);
            //int[] Arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    bool flage02;
            //    do
            //    {
            //        Console.WriteLine("Enter numbers");
            //        flage02 = int.TryParse(Console.ReadLine(), out Arr[i]);
            //    } while (!flage02);
            //}
            //int Max = Arr[0];
            //int Min = Arr[0];
            //for (int i = 0; i < size; i++)
            //{
            //    if (Max <Arr[i])
            //        Max = Arr[i];
            //    if (Min > Arr[i])
            //        Min = Arr[i];
            //}
            //Console.WriteLine($"max is {Max} min is {Min}");
            #endregion
            #region Q14
            //  Write a program in C# Sharp to find the second largest element in an array.
            //int size;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter size");
            //    flage = int.TryParse(Console.ReadLine(), out size);
            //} while (!flage);
            //int[] Arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    bool flage02;
            //    do
            //    {
            //        Console.WriteLine("Enter numbers");
            //        flage02 = int.TryParse(Console.ReadLine(), out Arr[i]);
            //    } while (!flage02);
            //}
            //int num;
            //for (int i = 0; i < size; i++)
            //{
            //  for (int j= i + 1; j < size; j++)
            //    {
            //        if (Arr[i] > Arr[j])
            //        {
            //            num = Arr[i];
            //            Arr[i] = Arr[j];
            //            Arr[j] = num;
            //        }
            //    }
            //}
            //int SecondMax = Arr[size - 2];
            //Console.WriteLine($"The second maxiumum number is: {SecondMax}");
            #endregion
            #region Q15
            //int size;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter size");
            //    flage = int.TryParse(Console.ReadLine(), out size);
            //} while (!flage);
            //int[] Arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    bool flage02;
            //    do
            //    {
            //        Console.WriteLine("Enter numbers");
            //        flage02 = int.TryParse(Console.ReadLine(), out Arr[i]);
            //    } while (!flage02);
            //}
            //int Distance = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (Arr[i] == Arr[j])
            //            if (Distance <j-i - 1)
            //                Distance = j - i - 1;

            //    }
            //}
            //Console.WriteLine($"the distance between is {Distance}");
            #endregion

            #region Q16
            //Console.WriteLine("Enter a sentence:");
            //string sentence = Console.ReadLine();

            //string output = "";
            //string[] words = sentence.Split(" ");

            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    output += words[i] + " ";
            //}
            //Console.WriteLine(output.Trim());
            #endregion

            #region Q17
            //int[,] Arr01 = new int [ 3, 3 ];
            //int[,] Arr02 = new int [ 3, 3 ];
            //for( int i = 0; i <3; i++)
            //{
            //    for(int j = 0; j<3; j++)
            //    {
            //        Console.WriteLine($"Enter Numbers [{i}, {j}]");
            //        Arr01[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Arr02[i, j] = Arr01[i, j];
            //    }
            //}
            //Console.WriteLine("2nd array");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine(Arr02[i, j]);
            //    }
            //}

            #endregion
            #region Q18
            //int size;
            //bool flage;
            //do
            //{
            //    Console.WriteLine("Enter size");
            //    flage = int.TryParse(Console.ReadLine(), out size);
            //} while (!flage);
            //int[] Arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    bool flage02;
            //    do
            //    {
            //        Console.WriteLine("Enter numbers");
            //        flage02 = int.TryParse(Console.ReadLine(), out Arr[i]);
            //    } while (!flage02);
            //}
            //for (int i = Arr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(Arr[i]);
            //}
            #endregion
        }

    }
}
