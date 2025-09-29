using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace assignTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //Console.Write("Enter a number:  ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 3 == 0 && num % 4 == 0)
            //{
            //    Console.WriteLine("\n yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}
            #endregion
            #region q2
            //Console.Write("Enter a number:  ");
            //int num = int.Parse(Console.ReadLine());
            //if (num < 0)
            //{ Console.WriteLine("\n negative"); }
            //else if (num > 0)
            //{ Console.WriteLine("positive"); }
            //else { Console.WriteLine("number is zero");  }
            #endregion
            #region q3
            //Console.WriteLine("Enter numbers:  ");
            //int num = int.Parse(Console.ReadLine()), num2 = int.Parse(Console.ReadLine()), num3 = int.Parse(Console.ReadLine()), result = 0, result2 = 0 ;

            //result = num;
            //result2 = num;
            //if (num2 > result)           
            //    result = num2;
            //if (num3 > result)
            //    result = num3;
            //if (num2 < result2)
            //    result2 = num2;
            //if (num3 < result2)
            //    result2 = num3;
            //Console.WriteLine($"max number is {result}");
            //Console.WriteLine($"min number is {result2}");
            #endregion
            #region q4
            //Console.Write("Enter a number:  ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //    Console.WriteLine("\n even");
            //else
            //    Console.WriteLine("odd");

            #endregion
            #region q5
            //Console.Write("Enter a letter:  ");
            //char let = char.Parse(Console.ReadLine());
            //switch(let)
            //{
            //    case 'a':
            //        Console.WriteLine("vowel");
            //        break;
            //    case 'o':
            //        Console.WriteLine("vowel");
            //        break;
            //    case 'i':
            //        Console.WriteLine("vowel");
            //        break;
            //    case 'u':
            //        Console.WriteLine("vowel");
            //        break;
            //    case 'e':
            //        Console.WriteLine("vowel");
            //        break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;
            //}
            #endregion
            #region q6
            //Console.Write("enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //for(int i = 1; i<=num; i++)
            //    Console.Write(i);
            #endregion
            #region q7
            //Console.Write("enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //    Console.Write(i * num + " ");
            #endregion
            #region q8
            //Console.Write("enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <num; i++)
            //    Console.Write(i % 2 == 0 ? i : "" + " ");

            #endregion
            #region q9
            //Console.WriteLine("enter number and power: ");
            //int num = int.Parse(Console.ReadLine()), num2 = int.Parse(Console.ReadLine());
            //int num3 = 1;
            //for (int i = 0; i < num2; i++)
            //{
            //    num3 *= num;
            //}
            //Console.WriteLine(num3);
            #endregion
            #region q10
            //Console.WriteLine("enter numbers: ");
            //int[] numbers = new int[5];
            //int reslut = 0;
            //for (int i= 0; i< 5; i++)
            //{
            //   numbers[i]=int.Parse(Console.ReadLine());
            //}
            //for(int i = 0; i<5; i++)
            //{
            //    reslut += numbers[i];
            //}
            //Console.WriteLine($"total number: {reslut}");
            //Console.WriteLine($"avg number: {reslut/5}");
            //Console.WriteLine($"percentage number: {((decimal)reslut/5)/100 * 100}");
            #endregion
            #region q11
            //Console.Write("Enter month number (1-12): ");
            //int month = int.Parse(Console.ReadLine());
            //Console.Write("Enter a year: ");
            //int year = int.Parse(Console.ReadLine());


            //if (month >= 1 && month <= 12)
            //{
            //    int days = DateTime.DaysInMonth(year, month);
            //    Console.WriteLine(days);
            //}

            #endregion
            #region q12
            //Console.Write("Enter first number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter operator (+, -, *, /): ");
            //char op = char.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //double result = 0;
            //bool valid = true;

            //switch (op)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;

            //    case '-':
            //        result = num1 - num2;
            //        break;

            //    case '*':
            //        result = num1 * num2;
            //        break;

            //    case '/':
            //        if (num2 != 0)
            //            result = num1 / num2;
            //        else
            //        {
            //            Console.WriteLine("Error! Division by zero.");
            //            valid = false;
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Invalid operator!");
            //        valid = false;
            //        break;
            //}

            //if (valid)
            //    Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
            #endregion
            #region q13
            //Console.WriteLine("enter a string: ");
            //string test = Console.ReadLine();
            //string ts = "";
            //for (int i = test.Length - 1; i >= 0; i--)
            //{
            //    ts += test[i];
            //}
            //Console.WriteLine(ts);
            #endregion
            #region q14
            //Console.WriteLine("enter a number: ");
            //string test = Console.ReadLine();
            //string ts = "";
            //for (int i = test.Length - 1; i >= 0; i--)
            //{
            //    ts += test[i];
            //}
            //Console.WriteLine(int.Parse(ts));
            #endregion
            #region q15
            //Console.WriteLine("Input starting number of range: ");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input ending number of range: ");
            //int end = int.Parse(Console.ReadLine());

            //if (start > 0 && end > 0)
            //{
            //    for (int i = start; i <= end; i++)
            //    {
            //        bool isPrime = true;

            //        if (i < 2)
            //            isPrime = false;
            //        else
            //        {
            //            for (int j = 2; j <= Math.Sqrt(i); j++)
            //            {
            //                if (i % j == 0)
            //                {
            //                    isPrime = false;
            //                    break;
            //                }
            //            }
            //        }

            //        if (isPrime)
            //            Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region q16
            //Console.WriteLine("enter a number:");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("number i binary form:");
            //Console.WriteLine(Convert.ToString(num, 2));
            #endregion
            #region q17
            //int[,] num = new int[3,2];
            //Console.WriteLine("enter three point: ");
            //for(int i =0; i<3;i++)
            //{
            //    for(int j=0;j<2;j++)
            //    {
            //        num[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //int result = num[0, 0] * (num[1, 1] - num[2, 1]) - num[0, 1] * (num[1, 0] - num[2, 0]) + 1 * ((num[1, 0] * num[2, 1]) - (num[2, 0] * num[1,1]));
            //if (result == 0)
            //    Console.WriteLine("three points are in astraight line");
            //else
            //    Console.WriteLine("three points are not in astraight line");
            #endregion
            #region q18
            //Console.WriteLine("enter number of hours: ");
            //float nofhr = float.Parse(Console.ReadLine());
            //if (nofhr <= 3)
            //    Console.WriteLine("highly efficient.");
            //else if (nofhr > 3 && nofhr <= 4)
            //    Console.WriteLine("increase your speed.");
            //else if (nofhr >4 && nofhr <=5)
            //    Console.WriteLine("train to enhance your speed.");
            //else
            //    Console.WriteLine("leave the company.");
            #endregion
            #region q19
            //Console.Write("Enter the size of identity matrix (n): ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region q20
            //Console.WriteLine("enter size of number and numbers: ");
            //int size =int.Parse(Console.ReadLine());
            //int[] numbers = new int[size];
            //int reslut = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < size; i++)
            //{
            //    reslut += numbers[i];
            //}
            //Console.WriteLine($"total number: {reslut}");

            #endregion
            #region q21
            //Console.Write("Enter size of the arrays: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr1 = new int[n];
            //int[] arr2 = new int[n];
            //int[] merged = new int[2 * n];

            //Console.WriteLine("Enter elements of first array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter elements of second array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    merged[i] = arr1[i];
            //    merged[i + n] = arr2[i];
            //}

            //Array.Sort(merged);
            //for (int i = 0; i < merged.Length; i++)
            //{
            //    Console.Write(merged[i] + " ");
            //}
            //Console.WriteLine();
            #endregion
            #region q22
            //Console.WriteLine("enter size of array");
            //int num = int.Parse(Console.ReadLine());
            //int[] arr = new int[num];
            //Console.WriteLine("enter element to array");
            //for (int i = 0; i < num; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int count = 0;
            //string counter = "";
            //bool[] visited = new bool[num];
            //for (int i = 0; i < num; i++)
            //{
            //    if (visited[i]) continue;

            //    for (int j = 0; j < num; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count += 1;
            //            visited[j] = true; 
            //        }
            //    }
            //    counter += count + ","; 
            //    count = 0; 
            //}
            //Console.WriteLine(counter);
            #endregion
            #region q23
            //Console.Write("Enter number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int max = arr[0];
            //int min = arr[0];

            //for (int i = 1; i < n; i++)
            //{
            //    if (arr[i] > max)
            //        max = arr[i];
            //    if (arr[i] < min)
            //        min = arr[i];
            //}

            //Console.WriteLine($"\nMaximum element: {max}");
            //Console.WriteLine($"Minimum element: {min}");
            #endregion
            #region q24
            //Console.Write("Enter number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter elements of array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //if (n < 2)
            //{
            //    Console.WriteLine("Array must contain at least two elements.");
            //    return;
            //}

            //int firstMax = int.MinValue;
            //int secondMax = int.MinValue;

            //for (int i = 0; i < n; i++)
            //{
            //    if (arr[i] > firstMax)
            //    {
            //        secondMax = firstMax;
            //        firstMax = arr[i];
            //    }
            //    else if (arr[i] > secondMax && arr[i] != firstMax)
            //    {
            //        secondMax = arr[i];
            //    }
            //}
            //Console.WriteLine($"The second largest element is: {secondMax}");
            #endregion
            #region q25
            //Console.Write("Enter size of array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //Console.WriteLine("Enter elements of array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDistance = -1;
            //int valueWithMaxDistance = -1;
            //int firstIndex = -1, lastIndex = -1;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = n - 1; j > i; j--) 
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1;
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //                valueWithMaxDistance = arr[i];
            //                firstIndex = i;
            //                lastIndex = j;
            //            }
            //            break; 
            //        }
            //    }
            //}
            //Console.WriteLine($"the max distance is {maxDistance}.");
            #endregion
            #region q26
            //Console.WriteLine("enter a string: ");
            //string tst = Console.ReadLine();
            //string [] result = tst.Split(" ");
            //foreach(string s in result.Reverse())
            //    Console.Write(s + " ");

            #endregion
            #region q27
            //Console.Write("Enter number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter elements of array:");
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //foreach (int i in arr.Reverse())
            //    Console.WriteLine(i);
            #endregion

        }
    }
}